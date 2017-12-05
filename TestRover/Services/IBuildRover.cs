using TestRover.Models;

namespace TestRover.Services
{
    public interface IBuildRover
    {
        Rover Build(Coordinates coordinates, string movements);
    }
}
