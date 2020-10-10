using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Infrastructure
{
    public interface IPlateauGrid
    {
        int GridX { get; set; }
        int GridY { get; set; }
        bool CheckInit { get; }
        bool Initialize(string gridSizeInput);
        IList<IRover> Rovers { get; set; }
    }
}
