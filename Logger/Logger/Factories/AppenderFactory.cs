using Log.Appenders;
using Log.Appenders.Interfaces;
using Log.Enums;
using Log.IO.Interfaces;
using Log.Layouts.Interfaces;
using Logger.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factories
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout, ReportLevel reportLevel = 0, ILogFile logFile = null)
        {
            switch (type)
            {
                case "ConsoleAppender": return new ConsoleAppender(layout, reportLevel);
                case "FileAppender": return new FileAppender(layout, logFile, reportLevel);
                default: throw new InvalidOperationException("Invalid appender type");
            }
        }
    }
}
