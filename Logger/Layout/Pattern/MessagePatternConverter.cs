using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Layout.Pattern;

namespace Logger.Layout.Pattern
{
    internal class MessagePatternConverter : PatternLayoutConverter
    {
        protected override void Convert(System.IO.TextWriter writer, log4net.Core.LoggingEvent loggingEvent)
        {
            if (loggingEvent.MessageObject is Logger.Extensions.CustomPatternMessage)
            {
                Logger.Extensions.CustomPatternMessage cpm = loggingEvent.MessageObject as Logger.Extensions.CustomPatternMessage;
                writer.Write(cpm.Message);
            }
        }
    }
}
