using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using TestRover.Models;
using TestRover.Services;

namespace TestRover.UnitTests
{
    [TestClass]
    public class BuildCoordinates
    {
        private IBuildCoordinates _iBuildCoordinates;

        [TestInitialize]
        public void Setup()
        {
            _iBuildCoordinates = MockRepository.GenerateStub<IBuildCoordinates>();
        }

        [TestMethod]
        public void BuildCoordinates_FirstRover_ReturnsNull()
        {
            //arange
            _iBuildCoordinates.Stub(o => o.Build(Arg<Locations>.Is.Anything, Arg<CardinalDirections>.Is.Anything)).Return(null);

            //act
            var result = _iBuildCoordinates.Build(Arg<Locations>.Is.Anything, Arg<CardinalDirections>.Is.Anything);

            //assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void BuildCoordinates_FirstRover_ReturnsNotNull()
        {
            var roverLocations = new Locations(1, 2);
            var cardinalDirection = CardinalDirections.N;

            //arange
            _iBuildCoordinates.Stub(o => o.Build(Arg<Locations>.Is.Anything, Arg<CardinalDirections>.Is.Anything)).Return(new Coordinates(roverLocations.X,roverLocations.Y, cardinalDirection));

            //act
            var result = _iBuildCoordinates.Build(roverLocations, cardinalDirection);

            //assert
            Assert.IsNotNull(result);
        }
    }
}
