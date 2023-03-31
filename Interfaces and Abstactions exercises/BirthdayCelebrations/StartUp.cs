using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBirthable> birthable = new List<IBirthable>();

            string command;

            while((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(" ");

                if (tokens[0] == "Citizen")
                {
                    IBirthable person = new Citizen(tokens[3], tokens[1], int.Parse(tokens[2]), tokens[4]);
                    birthable.Add(person);
                }
                else if (tokens[0] == "Pet")
                {
                    IBirthable pet = new Pet(tokens[1], tokens[2]);
                    birthable.Add(pet);
                }
            }
            string yearBorn = Console.ReadLine();
            foreach (IBirthable born in birthable)
            {
                if(born.Birthday.EndsWith(yearBorn))
                {
                    Console.WriteLine(born.Birthday);
                }

                
            }

        }

    }
}
