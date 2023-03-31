using Log.Appenders;
using Log.Appenders.Interfaces;
using Log.Layouts;
using Log.Layouts.Interfaces;
using Log.Loggers;
using Log.Loggers.Interfaces;
using Log.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ILayout simpleLayout = new SimpleLayout();

            IAppender consoleAppender = new ConsoleAppender(simpleLayout);

            ILogger logger = new Loggers(consoleAppender);

            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            

            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");
        }
    }
}
