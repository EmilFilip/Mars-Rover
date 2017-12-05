using TestRover.Models;

namespace TestRover.Services
{
    public interface IBuildCoordinates
    {
        Coordinates Build(Locations locations, CardinalDirections cardinalDirection);
    }
}
