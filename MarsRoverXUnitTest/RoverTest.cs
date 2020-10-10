using MarsRover.BLL.Derived;
using MarsRover.BLL.Infrastructure;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MarsRoverXUnitTest
{
    public class RoverTest
    {

        Mock<IRoverPosition> _mockRoverPosition;
        Mock<IPlateauGrid> _mockPlateauGrid;
        Rover _rover;
        public RoverTest()
        {
            _mockRoverPosition = new Mock<IRoverPosition>();
            _mockPlateauGrid = new Mock<IPlateauGrid>();

            _rover = new Rover(_mockRoverPosition.Object, _mockPlateauGrid.Object);
        }       

        [Theory]
        [InlineData("1 2 N")]
        public void Initialize_RoverInitialize_InitializedRover(string roverPositionInput)
        {
            var result = _rover.Initialize(roverPositionInput);

            Assert.IsAssignableFrom<bool>(result);

            Assert.True(result);

        }
    }
}
