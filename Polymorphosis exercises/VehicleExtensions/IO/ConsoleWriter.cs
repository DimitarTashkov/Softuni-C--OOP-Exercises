using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtensions.IO.Interfaces;

namespace VehiclesExtensions.IO
{
    public class ConsoleWriter : IWriter
    {

        public void WriteLine(string str) => Console.WriteLine(str);
       
    }
}
