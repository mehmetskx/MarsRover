using MarsRover.BLL.Command;
using MarsRover.BLL.Derived;
using MarsRover.Data;
using System;
using Xunit;

namespace MarsRoverXUnitTest
{
    public class PlateauGridTest
    {
        [Theory]
        [InlineData("5 5")]
        public void Initialize_SetGridSize_GridIsInitialize(string gridSize)
        {
            var plateauGrid1 = new PlateauGrid();

            var result = plateauGrid1.Initialize(gridSize);

            Assert.IsAssignableFrom<bool>(result);

            Assert.True(result);

          
        }
    }
}
