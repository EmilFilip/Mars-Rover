using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRover.Models
{
    public class Locations
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Locations(int locationX, int locationY)
        {
            this.X = locationX;
            this.Y = locationY;
        }
    }
}
