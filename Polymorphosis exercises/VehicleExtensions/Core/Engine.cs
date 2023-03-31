using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtensions.Factories.Interfaces;
using VehiclesExtensions.IO.Interfaces;
using VehiclesExtensions.Models.Interfaces;

namespace VehiclesExtensions.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IVehicleFactory vehicleFactory;

        private readonly ICollection<IVehicle> vehicles;
        public Engine(IReader reader, IWriter writer,IVehicleFactory vehicleFactory) 
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;

            vehicles = new List<IVehicle>();
        }
        public void Run()
        {
            vehicles.Add(CreateVehicle());
            vehicles.Add(CreateVehicle());
            vehicles.Add(CreateVehicle());

            int commandsCount = int.Parse(reader.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                try
                {
                    ProcessCommand();
                }
                catch(ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    throw;
                }           
           
            }
            foreach (var vehicle in vehicles)
            {
                writer.WriteLine(vehicle.ToString());
            }

        }

        private IVehicle CreateVehicle()
        {
            string[] tokens = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return vehicleFactory
                .Create(tokens[0],double.Parse(tokens[1]), double.Parse(tokens[2]), double.Parse(tokens[3]));
        }
        private void ProcessCommand()
        {
            string[] commands = reader
                    .ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = commands[0];
            string vehicleType = commands[1];
            IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType);

            if (vehicle == null)
            {
                throw new ArgumentException("Invalid vehicle type");
            }

            if (command == "Drive")
            {
                double distance = double.Parse(commands[2]);
                writer.WriteLine(vehicle.Drive(distance));
            }
            else if (command == "DriveEmpty")
            {
                double distance = double.Parse(commands[2]);
                writer.WriteLine(vehicle.Drive(distance, false));
            }
            else if (command == "Refuel")
            {
                double amount = double.Parse(commands[2]);
                vehicle.Refuel(amount);

            }
        }
    }
}
