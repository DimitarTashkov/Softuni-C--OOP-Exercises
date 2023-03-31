using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Core;
using WildFarm.Factories;
using WildFarm.Factories.Interfaces;
using WildFarm.IO;
using WildFarm.IO.Interfaces;

namespace WildFarm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IAnimalFactury animalFactory = new AnimalFactory();
            IFoodFactury foodFactory = new FoodFactury();

            IEngine engine = new Engine(reader,writer,animalFactory,foodFactory);
            engine.Run();

        }
    }
}
