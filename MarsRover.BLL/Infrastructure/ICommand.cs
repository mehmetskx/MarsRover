using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.BLL.Infrastructure
{
    public interface ICommand
    {
        void Process();
    }
}
