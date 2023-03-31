using Log.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Models.Interfaces
{
    public interface IMessage
    {
        string CreatedTime { get; }
        string Text { get; }
        ReportLevel ReportLevel { get; }
    }
}
