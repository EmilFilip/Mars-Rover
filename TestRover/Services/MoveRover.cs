using System.Collections.Generic;
using TestRover.Models;
using TestRover.Utils;

namespace TestRover.Services
{
    public class MoveRover : IMoveRover
    {
        public List<Rover> Move(List<Rover> rovers, PlateauSize plateauSize)
        {
            return new List<Rover>(MoveRovers(rovers, plateauSize));
        }

        private IEnumerable<Rover> MoveRovers(List<Rover> rovers, PlateauSize plateauSize)
        {
            foreach (var rover in rovers)
            {
                List<TurningDirections> directions = new List<TurningDirections>(Util.BuildMovements(rover.Movements));

                foreach (var turnToDirection in directions)
                {
                    if (turnToDirection == TurningDirections.L)
                    {
                        rover.direction = TurnLeft(rover.direction, turnToDirection);
                    }
                    else if (turnToDirection == TurningDirections.R)
                    {
                        rover.direction = TurnRight(rover.direction, turnToDirection);
                    }
                    else if (turnToDirection == TurningDirections.M)
                    {
                        rover.Location = MoveForward(rover.direction, rover.Location, plateauSize);
                    }
                }

                yield return rover;
            }
        }

        private CardinalDirections TurnLeft(CardinalDirections roverDirection, TurningDirections turnToDirection)
        {
            switch (roverDirection)
            {
                case CardinalDirections.N:
                    return CardinalDirections.W;
                case CardinalDirections.S:
                    return CardinalDirections.E;
                case CardinalDirections.W:
                    return CardinalDirections.S;
                case CardinalDirections.E:
                    return CardinalDirections.N;
                default:
                    return CardinalDirections.W;
            }
        }

        private CardinalDirections TurnRight(CardinalDirections roverDirection, TurningDirections turnToDirection)
        {
            switch (roverDirection)
            {
                case CardinalDirections.N:
                    return CardinalDirections.E;
                case CardinalDirections.S:
                    return CardinalDirections.W;
                case CardinalDirections.W:
                    return CardinalDirections.N;
                case CardinalDirections.E:
                    return CardinalDirections.S;
                default:
                    return CardinalDirections.W;
            }
        }

        private Locations MoveForward(CardinalDirections roverDirection, Locations roverLocation, PlateauSize plateauSize)
        {
            if (roverDirection == CardinalDirections.N && roverLocation.Y <= plateauSize.UpperLocations.Y)
            {
                roverLocation.Y++;
            }
            else if (roverDirection == CardinalDirections.E && roverLocation.X <= plateauSize.UpperLocations.X)
            {
                roverLocation.X++;
            }
            else if (roverDirection == CardinalDirections.S && roverLocation.Y >= plateauSize.LowerLocations.Y)
            {
                roverLocation.Y--;
            }
            else if (roverDirection == CardinalDirections.W && roverLocation.X >= plateauSize.LowerLocations.X)
            {
                roverLocation.X--;
            }

            return roverLocation;
        }
    }
}
