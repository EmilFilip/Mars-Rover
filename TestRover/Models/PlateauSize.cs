using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRover.Models
{
    public class PlateauSize
    {
        public Locations UpperLocations { get; set; }
        public Locations LowerLocations { get; set; }


        public PlateauSize(int upperX, int upperY)
        {
            this.UpperLocations = new Locations(5, 5);
            this.LowerLocations = new Locations(0, 0);
        }
    }
}
