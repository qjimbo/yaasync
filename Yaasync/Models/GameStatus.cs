using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Yaasync.Data;

namespace Yaasync.Models
{
    static class GameStatus
    {
        static public bool Open { get; set; }
        static public IntPtr Process { get; set; }
        static public Int64 MainModuleOffset { get; set; }
        static public MemoryAddresses.PointerBlock PointerBlock { get; set; }
        static public MemoryAddresses.AddressBlock AddressBlock { get; set; }

        static public float gX { get; set; }
        static public float gY { get; set; }
        static public float gZ { get; set; }

        static public float sX { get; set; }
        static public float sY { get; set; }
        static public float sZ { get; set; }

        static public string system = "System";
        static public string planet = "Planet";
        static public string galaxy = "Galaxy";

        static public string gameStatusGalaxyXYZ
        {
            get
            {
                return "X: " + GameStatus.gX.ToString("0.00") +
                ", Y: " + GameStatus.gY.ToString("0.00") +
                ", Z: " + GameStatus.gZ.ToString("0.00");
            }
        }

        static public string gameStatusSurfaceXYZ
        {
            get
            {
                return "X: " + GameStatus.sX.ToString("0.00") +
                ", Y: " + GameStatus.sY.ToString("0.00") +
                ", Z: " + GameStatus.sZ.ToString("0.00");
            }
        }

        static public string gameStatusString
        {
            get
            {
            return "System: " + GameStatus.system + Environment.NewLine +
            "Planet: " + GameStatus.planet + Environment.NewLine +
            "Galaxy: " + GameStatus.galaxy + Environment.NewLine +

            "Galaxy XYZ: " + GameStatus.gameStatusGalaxyXYZ + Environment.NewLine +
            "Surface XYZ: " + GameStatus.gameStatusSurfaceXYZ;
            }
        }


    }
}
