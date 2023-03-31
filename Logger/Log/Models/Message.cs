using Log.Enums;
using Log.Exceptions;
using Log.Models.Interfaces;
using Log.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Models
{
    public class Message : IMessage
    {
        private string createdTime;
        private string text;

        public Message(string createdTime, string text, ReportLevel reportLevel)
        {
            CreatedTime = createdTime;
            Text = text;
            ReportLevel = reportLevel;
        }

        public string CreatedTime
        {
            get => createdTime;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyCreatedTimeException();
                }

                if(!DateTimeValidator.ValidateDateTime(value))
                {
                    throw new InvalidDateTimeException();
                }

                //TODO validate if date can be created //FORMAT
                createdTime = value;
            }
        }

        public string Text 
        {
            get => text;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyMessageException();
                }
                text = value;
            }
        }

        public ReportLevel ReportLevel { get; private set; }
    }

}
