using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaasync.Data
{
    public static class MemoryAddresses
    {
        public class PointerBlock
        {
            public Int64[] gX { get; set; }
            public Int64[] gY { get; set; }
            public Int64[] gZ { get; set; }
            public Int64[] sX { get; set; }
            public Int64[] sY { get; set; }
            public Int64[] sZ { get; set; }
            public Int64[] system { get; set; }
            public Int64[] planet { get; set; }
            public Int64[] galaxy { get; set; }
        }
        public class AddressBlock
        {
            public Int64 gX {get; set;}
            public Int64 gY {get; set;}
            public Int64 gZ {get; set;}
            public Int64 sX {get; set;}
            public Int64 sY {get; set;}
            public Int64 sZ {get; set;}
            public Int64 system {get; set;}
            public Int64 planet {get; set;}
            public Int64 galaxy {get; set;}
        }
        public static Dictionary<string, PointerBlock> Data = new Dictionary<string, PointerBlock>() // Version, Addresses
        {
            {
                "0.1.0.0",
                new PointerBlock
                {
                    gX = new Int64[]{ 0 },
                    gY = new Int64[]{ 0 },
                    gZ = new Int64[]{ 0 },
                    sX = new Int64[]{ 0x0157F990, 0x798, 0x568, 0x420, 0x5a0 , 0xb8 }, // 260F3438320 then -4 for Y, -4 for Z
                    sY = new Int64[]{ 0x0157F990, 0x798, 0x568, 0x420, 0x5a0 , 0xb4 },
                    sZ = new Int64[]{ 0x0157F990, 0x798, 0x568, 0x420, 0x5a0 , 0xb0 },
                    system = new Int64[]{ 0 },
                    planet = new Int64[]{ 0x01C54FB8, 0x5a8, 0x5e8, 0xd8, 0x228, 0x7f0 },
                    galaxy = new Int64[]{ 0 },
                }
            }
        };
    }
}
