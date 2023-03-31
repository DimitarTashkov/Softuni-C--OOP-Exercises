using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Core.Interfaces;
using Telephony.Models.Interfaces;
using Telephony.Models;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ");

            string[] urls = Console.ReadLine().Split(" ");

            foreach (var phoneNumber in phoneNumbers)
            {
                ICallable phone;
                if (phoneNumber.Length == 10)
                {
                    phone = new Smartphone();
                }
                else
                {
                    phone = new StationaryPhone();
                }

                try
                {
                    Console.WriteLine(phone.Call(phoneNumber));
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var url in urls)
            {
                IBrowsable phone = new Smartphone();
                try
                {
                    Console.WriteLine(phone.Browse(url));
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
