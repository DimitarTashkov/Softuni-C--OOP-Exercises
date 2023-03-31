using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Core;
using Vehicles.Factories;
using Vehicles.Factories.Interfaces;
using Vehicles.IO;
using Vehicles.IO.Interfaces;

namespace Vehicles
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
