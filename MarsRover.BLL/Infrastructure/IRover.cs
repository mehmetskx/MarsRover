using System.Collections.Generic;

namespace MarsRover.BLL.Infrastructure
{
    public interface IRover
    {
        IRoverPosition CurrentPosition { get; }
        IPlateauGrid PlateauGrid { get; set; }
        IList<ICommand> Commands { get; set; }
        bool Initialize(string roverPositionInput);
        void CommandParse(string roverCommandInput);
        void Move();
        void TurnRight();
        void TurnLeft();
    }
}
