using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger.Extensions
{
    public class CustomPatternMessage
    {
        private string _eventName;
        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; }
        }

        private string _userIP;
        public string UserIP
        {
            get { return _userIP; }
            set { _userIP = value; }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private DateTime _recordTime=DateTime.Now;

        public DateTime RecordTime
        {
            get { return _recordTime; }
            set
            {
                _recordTime = value;
            }
        }
    }
}
