using Log.Appenders.Interfaces;
using Log.Enums;
using Log.Loggers.Interfaces;
using Log.Models;
using Log.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Loggers
{
    public class Loggers : ILogger
    {
        private readonly ICollection<IAppender> appenders;
        public Loggers(params IAppender[] appenders) 
        {
            this.appenders = appenders;
        }
        public Loggers(ICollection<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public void Info(string dateTime, string text)
        => AppendAll(dateTime, text, ReportLevel.Info);
        public void Warning(string dateTime, string text)
        => AppendAll(dateTime, text, ReportLevel.Warning);
        public void Error(string dateTime, string text)
        => AppendAll(dateTime, text, ReportLevel.Error);
        public void Critical(string dateTime, string text)
        => AppendAll(dateTime, text, ReportLevel.Critical);
        public void Fatal(string dateTime, string text)
        => AppendAll(dateTime, text, ReportLevel.Fatal);

        private void AppendAll(string dateTime, string text, ReportLevel reportLevel) 
        {
            IMessage message = new Message(dateTime,text,reportLevel);

            foreach (IAppender appender in appenders)
            {
                if(message.ReportLevel >= appender.ReportLevel)
                {
                    appender.AppendMessage(message);
                }
            }
        }

       
    }
}
