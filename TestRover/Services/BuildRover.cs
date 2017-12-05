using TestRover.Models;

namespace TestRover.Services
{
    public class BuildRover : IBuildRover
    {
        Rover _rover;

        public BuildRover()
        {
        }
        public Rover Build(Coordinates coordinates, string movements)
        {
            _rover = new Rover();

            this._rover.Location = coordinates.Locations;
            this._rover.direction = coordinates.CardinalDirection;
            this._rover.Movements = movements;


            return _rover;
        }
    }
}
