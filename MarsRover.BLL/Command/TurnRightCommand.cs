using MarsRover.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Command
{
    public class TurnRightCommand : ICommand
    {
        IRover rover;

        public TurnRightCommand(IRover rover)
        {
            this.rover = rover;
        }

        public void Process()
        {
            this.rover.TurnRight();
        }
    }
}
