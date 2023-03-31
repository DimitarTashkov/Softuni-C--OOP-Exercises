using Log.Enums;
using Log.Layouts.Interfaces;
using Log.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Appenders.Interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; }        
            ReportLevel ReportLevel { get; }
        int MessagesAppended { get; }
        void AppendMessage(IMessage message);
    }
}
