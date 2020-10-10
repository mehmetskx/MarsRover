using MarsRover.BLL.Command;
using MarsRover.BLL.Derived;
using MarsRover.BLL.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverConsole
{
   public class Startup
    {
        public static ServiceProvider InitializeDI()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<ICommand, TurnLeftCommand>();
            services.AddTransient<ICommand, TurnRightCommand>();
            services.AddTransient<ICommand, MoveCommand>();
            services.AddTransient<IRoverCommandManager, RoverCommandManager>();
            services.AddTransient<IRoverPosition, RoverPosition>();
            services.AddTransient<IRover, Rover>();
            services.AddTransient<IPlateauGrid, PlateauGrid>();

            return services.BuildServiceProvider();
        }
    }
}
