using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRover.Models
{
    public class Coordinates
    {
        public Locations Locations { get; set; }
        public CardinalDirections CardinalDirection { get; set; }

        public Coordinates(int locationX, int locationY, CardinalDirections cardinalDirection)
        {

            this.Locations = new Locations(locationX, locationY);
            this.CardinalDirection = cardinalDirection;
        }
    }
}
