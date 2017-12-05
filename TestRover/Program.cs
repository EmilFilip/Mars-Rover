using System;
using System.Collections.Generic;
using TestRover.Models;
using TestRover.Services;

namespace TestRover
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuildRover iBUildRover = new BuildRover();
            IMoveRover iMoveRover = new MoveRover();
            IBuildCoordinates iBuildCoordinates = new BuildCoordinates();

            var plateauSize = new PlateauSize(4, 4);

            //Create coordinates for the first rover
            var roverLocations = new Locations(1, 2);
            var cardinalDirection = CardinalDirections.N;
            var movements = "LMLMLMLMM";

            //Create coordinates for the second rover
            var rover2Locations = new Locations(3, 3);
            var cardinalDirection2 = CardinalDirections.E;
            var movements2 = "MMRMMRMRRM";

            //Build first rover
            var coordinates = iBuildCoordinates.Build(roverLocations, cardinalDirection);
            var startingRover = iBUildRover.Build(coordinates, movements);
            startingRover.Id = 1;

            //Build second rover
            var coordinates2 = iBuildCoordinates.Build(rover2Locations, cardinalDirection2);
            var startingRover2 = iBUildRover.Build(coordinates2, movements2);
            startingRover2.Id = 2;

            var startingRovers = new List<Rover>() { startingRover, startingRover2 };

            //Move rovers
            var arrivedRovers = iMoveRover.Move(startingRovers, plateauSize);

            foreach (var rover in arrivedRovers)
            {
                Console.WriteLine(string.Format("Rover {0} final position: ", rover.Id) + rover.Location.X.ToString() + rover.Location.Y.ToString() + rover.direction);
            }


            Console.ReadKey();
        }
    }
}
