using MarsRover.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Infrastructure
{
    public interface IRoverPosition
    {
        int X { get; set; }
        int Y { get; set; }
        RoverDirection Direction { get; set; }
    }
}
