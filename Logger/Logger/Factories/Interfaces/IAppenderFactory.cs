using Log.Appenders.Interfaces;
using Log.Enums;
using Log.IO.Interfaces;
using Log.Layouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factories.Interfaces
{
    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout, ReportLevel reportLevel, ILogFile logFile = null);
    }
}
