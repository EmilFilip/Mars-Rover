using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRover.Models
{
    public class Rover
    {
        public int Id { get; set; }
        public Locations Location { get; set; }
        public CardinalDirections direction { get; set; }

        public string Movements { get; set; }
    }
}
