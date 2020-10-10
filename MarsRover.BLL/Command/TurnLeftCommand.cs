using MarsRover.BLL.Infrastructure;

namespace MarsRover.BLL.Command
{
    public class TurnLeftCommand : ICommand
    {
        IRover rover;

        public TurnLeftCommand(IRover rover)
        {
            this.rover = rover;
        }

        public void Process()
        {
            this.rover.TurnLeft();
        }
    }
}
