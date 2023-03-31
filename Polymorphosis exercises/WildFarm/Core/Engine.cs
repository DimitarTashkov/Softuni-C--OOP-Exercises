using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factories.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private IAnimalFactury animalFactury;
        private IFoodFactury foodFactory;

        private readonly ICollection<IAnimal> animals;

        public Engine(IReader reader, IWriter writer, IAnimalFactury animalFactury, IFoodFactury foodFactory)
        {
            this.reader = reader;
            this.writer = writer;

            this.animalFactury = animalFactury;
            this.foodFactory = foodFactory;

            animals = new List<IAnimal>();
        }

        public void Run()
        {
            string command;
            while((command = reader.ReadLine())!= "End")
            {
                IAnimal animal = null;

                try
                {
                     animal = CreateAnimal(command);

                    IFood food = CreateFood();

                    writer.WriteLine(animal.ProduceSound());

                    animal.Eat(food);
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {

                    throw;
                }
                animals.Add(animal);
                
            }
            foreach (IAnimal animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }
        }

        private IAnimal CreateAnimal(string command)
        {
            string[] animalTokens = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return animalFactury.CreateAnimal(animalTokens);
        }
        private IFood CreateFood()
        {
            string[] foodTokens = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string foodType = foodTokens[0];
            int foodQuantity = int.Parse(foodTokens[1]);

            return foodFactory.CreateFood(foodType,foodQuantity);

        }
    }
}
