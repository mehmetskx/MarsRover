using MarsRover.BLL.Infrastructure;

namespace MarsRover.BLL.Command
{
    public class MoveCommand : ICommand
    {
        IRover rover;

        public MoveCommand(IRover rover)
        {
            this.rover = rover;
        }

        public void Process()
        {
            this.rover.Move();
        }
    }
}
