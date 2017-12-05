using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using TestRover.Models;
using TestRover.Services;

namespace TestRover.UnitTests
{
    [TestClass]
    public class BuildRover
    {
        private IBuildRover _iBuildRover;

        [TestInitialize]
        public void Setup()
        {
            _iBuildRover = MockRepository.GenerateStub<IBuildRover>();
        }

        [TestMethod]
        public void BuildRover_ReturnsNull()
        {
            //arange
            _iBuildRover.Stub(o => o.Build(Arg<Coordinates>.Is.Anything, Arg<string>.Is.Anything)).Return(null);

            //act
            var result = _iBuildRover.Build(Arg<Coordinates>.Is.Anything, Arg<string>.Is.Anything);

            //assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void BuildRover_ReturnsNotNull()
        {
            var roverLocations = new Locations(1, 2);
            var cardinalDirection = CardinalDirections.N;
            var coordinates = new Coordinates(roverLocations.X, roverLocations.Y, cardinalDirection);
            var movements = "LMLMLMLMM";

            //arange
            _iBuildRover.Stub(o => o.Build(Arg<Coordinates>.Is.Anything, Arg<string>.Is.Anything)).Return(new Rover());

            //act
            var result = _iBuildRover.Build(coordinates, movements);

            //assert
            Assert.IsNotNull(result);
        }
    }
}
