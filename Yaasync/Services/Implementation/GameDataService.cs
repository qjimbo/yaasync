using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Runtime.InteropServices; // DllImport
using Yaasync.Models;
using Yaasync.Data;

namespace Yaasync.Services.Implementation
{
    public class GameDataService : IGameDataService
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            int dwSize,
            int lpNumberOfBytesWritten
        );
        const int PROCESS_WM_READ = 0x0010;

        public void LoadFromProcess()
        {
            if(!GameStatus.Open)
            {
                if(!MemoryAddresses.Data.ContainsKey(YaasyncStatus.GameVersion))
                {
                    // Error and close
                } else {
                    GameStatus.Process = OpenProcess(PROCESS_WM_READ, false, YaasyncStatus.GameProcess.Id);
                    GameStatus.Open = true;
                    GameStatus.MainModuleOffset = ReadMainModuleOffset();
                    GameStatus.PointerBlock = MemoryAddresses.Data[YaasyncStatus.GameVersion];
                    GameStatus.AddressBlock = PopulateAddressBlockFromPointerBlock(GameStatus.PointerBlock);
                }
            }    
            if(GameStatus.Open)
            {
                GameStatus.planet = ReadProcessMemoryString(GameStatus.AddressBlock.planet);
                GameStatus.sX = ReadProcessMemoryFloat(GameStatus.AddressBlock.sX);
                GameStatus.sY = ReadProcessMemoryFloat(GameStatus.AddressBlock.sY);
                GameStatus.sZ = ReadProcessMemoryFloat(GameStatus.AddressBlock.sZ);
            }
        }

        public static Int64 ReadMainModuleOffset()
        {
            return YaasyncStatus.GameProcess.Modules[0].BaseAddress.ToInt64();
        }

        public static Int64 ReadProcessMemoryInt64(Int64 addr)
        {

            try
            {
                byte[] data = new byte[sizeof(long)];
                ReadProcessMemory(GameStatus.Process, (IntPtr)addr, data, data.Length, 0);
                return BitConverter.ToInt64(data, 0);
            }
            catch { return 0; }
        }

        public static string ReadProcessMemoryString(Int64 addr)
        {

            try
            {
                byte[] data = new byte[64];
                ReadProcessMemory(GameStatus.Process, (IntPtr)addr, data, data.Length, 0);
                return System.Text.Encoding.UTF8.GetString(data).Trim();
            }
            catch {
                return string.Empty;
            }
        }

        public static float ReadProcessMemoryFloat(Int64 addr)
        {

            try
            {
                byte[] data = new byte[64];
                ReadProcessMemory(GameStatus.Process, (IntPtr)addr, data, data.Length, 0);
                return BitConverter.ToSingle(data, 0);
            }
            catch
            {
                return 0f;
            }
        }

        public static MemoryAddresses.AddressBlock PopulateAddressBlockFromPointerBlock(MemoryAddresses.PointerBlock pointerBlock)
        {
            var addressBlock = new MemoryAddresses.AddressBlock();
            
            addressBlock.planet = tracePointers(GameStatus.MainModuleOffset, pointerBlock.planet);
            addressBlock.sX = tracePointers(GameStatus.MainModuleOffset, pointerBlock.sX);
            addressBlock.sY = tracePointers(GameStatus.MainModuleOffset, pointerBlock.sY);
            addressBlock.sZ = tracePointers(GameStatus.MainModuleOffset, pointerBlock.sZ); 
            return addressBlock;
        }

        public static Int64 tracePointers(Int64 startOffset, Int64[] listOffsets)
        {
            Globals.debugMsg("Tracing Pointer from Main module offset (0x" + GameStatus.MainModuleOffset.ToString("X") + ")");
            Int64 currentOffset = startOffset;
            for (int i = 0; i < listOffsets.Length; i++)
            {
                Int64 nextOffset = listOffsets[i];
                var newOffset = currentOffset + nextOffset;
                Globals.debugMsg("Prv offset (0x" + currentOffset.ToString("X") + ") + Offset (0x" + nextOffset.ToString("X") + ") = New Offset 0x" + newOffset.ToString("X"));


                if (i == listOffsets.Length - 1) { Globals.debugMsg("Last offset so returning value: 0x" + newOffset.ToString("X")); return newOffset; }
                currentOffset = ReadProcessMemoryInt64(newOffset);
                Globals.debugMsg("Read value from (0x" + newOffset.ToString("X") + "). Result is 0x" + currentOffset.ToString("X"));
                if (currentOffset == 0) return 0;
            }
            return currentOffset;
        }
    }
}
