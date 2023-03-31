using BorderControl.Core.Interfaces;
using BorderControl.Models;
using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<IIdentifiable> community = new List<IIdentifiable>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    IIdentifiable citizen = new Citizen(tokens[2], tokens[0], int.Parse(tokens[1]));
                    community.Add(citizen);
                }
                else
                {
                    IIdentifiable robot = new Robot(tokens[1], tokens[0]);
                    community.Add(robot);
                }
            }

            string invalidIdSuffix = Console.ReadLine();

            foreach (var element in community)
            {
                if (element.Id.EndsWith(invalidIdSuffix))
                {
                    Console.WriteLine(element.Id);
                }
            }

        }
    }
}
