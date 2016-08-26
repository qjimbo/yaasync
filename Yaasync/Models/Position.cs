using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaasync.Models
{
    public class Position
    {
        public Position()
        {
            gX = GameStatus.gX;
            gY = GameStatus.gX;
            gZ = GameStatus.gX;

            sX = GameStatus.gX;
            sY = GameStatus.gX;
            sZ = GameStatus.gX;

            system = GameStatus.system;
            planet = GameStatus.planet;
            galaxy = GameStatus.galaxy;
        }      
        public float gX { get; set; }
        public float gY { get; set; }
        public float gZ { get; set; }

        public float sX { get; set; }
        public float sY { get; set; }
        public float sZ { get; set; }

        public string system = "System";
        public string planet = "Planet";
        public string galaxy = "Galaxy";
    }
}
