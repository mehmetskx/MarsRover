using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Infrastructure
{
    public interface IRoverCommandManager
    {
        IRover Rover { get; set; }
        void AddCommand(ICommand command);
        void ProcessCommands();
    }
}
