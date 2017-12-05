using System.Collections.Generic;
using System.Linq;
using TestRover.Models;

namespace TestRover.Utils
{
    public static class Util
    {
        public static IEnumerable<TurningDirections> BuildMovements(string movements)
        {
            foreach (var movement in movements.ToArray())
            {
                if (movement == 'R')
                {
                    yield return TurningDirections.R;
                }
                else if (movement == 'L')
                {
                    yield return TurningDirections.L;
                }
                else if (movement == 'M')
                {
                    yield return TurningDirections.M;
                }
                else
                {
                    yield return TurningDirections.None;
                }
            }
        }
    }
}
