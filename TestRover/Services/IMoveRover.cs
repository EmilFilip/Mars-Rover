using System.Collections.Generic;
using TestRover.Models;

namespace TestRover.Services
{
    public interface IMoveRover
    {
        List<Rover> Move(List<Rover> rovers, PlateauSize plateauSize);
    }
}
