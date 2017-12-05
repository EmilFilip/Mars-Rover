using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System.Collections.Generic;
using TestRover.Models;
using TestRover.Services;

namespace TestRover.UnitTests
{
    [TestClass]
    public class MoveRover
    {
        private IMoveRover _iMoveRover;

        [TestInitialize]
        public void Setup()
        {
            _iMoveRover = MockRepository.GenerateStub<IMoveRover>();
        }

        [TestMethod]
        public void MoveRover_ReturnsNull()
        {
            //arange
            _iMoveRover.Stub(o => o.Move(Arg<List<Rover>>.Is.Anything, Arg<PlateauSize>.Is.Anything)).Return(null);

            //act
            var result = _iMoveRover.Move(Arg<List<Rover>>.Is.Anything, Arg<PlateauSize>.Is.Anything);

            //assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void BuildRover_ReturnsNotNull()
        {
            var plateauSize = new PlateauSize(5, 5);
            var rovers = new List<Rover>();

            //arange
            _iMoveRover.Stub(o => o.Move(Arg<List<Rover>>.Is.Anything, Arg<PlateauSize>.Is.Anything)).Return(new List<Rover>());

            //act
            var result = _iMoveRover.Move(rovers, plateauSize);

            //assert
            Assert.IsNotNull(result);
        }
    }
}
