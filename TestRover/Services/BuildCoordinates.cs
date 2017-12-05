using TestRover.Models;

namespace TestRover.Services
{
    public class BuildCoordinates : IBuildCoordinates
    {
        public Coordinates Build(Locations locations, CardinalDirections cardinalDirection)
        {
            return new Coordinates(locations.X, locations.Y, cardinalDirection);
        }
    }
}
