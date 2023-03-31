using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtensions.Core;
using VehiclesExtensions.Factories;
using VehiclesExtensions.Factories.Interfaces;
using VehiclesExtensions.IO;
using VehiclesExtensions.IO.Interfaces;

namespace VehiclesExtensions
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IVehicleFactory factory = new VehicleFactory();

            IEngine engine = new Engine(reader,writer,factory);
            engine.Run();
        }
    }
}
