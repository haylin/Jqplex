﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Layout;
using log4net.Util;
using log4net.Layout.Pattern;
using System.Collections;
using System.IO;
using log4net.Core;

namespace Logger.Layout
{
    public class MyPatternLayout : LayoutSkeleton
    {
        #region copy from PatternLayout

        public sealed class ConverterInfo
        {
            private string m_name;
            private Type m_type;
       
            public string Name
            {
                get
                {
                    return this.m_name;
                }
                set
                {
                    this.m_name = value;
                }
            }
       
            public Type Type
            {
                get
                {
                    return this.m_type;
                }
                set
                {
                    this.m_type = value;
                }
            }
        }
     
        public const string DefaultConversionPattern = "%message%newline";
       
        public const string DetailConversionPattern = "%timestamp [%thread] %level %logger %ndc - %message%newline";
      
        private static Hashtable s_globalRulesRegistry;
        
        private string m_pattern;
       
        private PatternConverter m_head;
     
        private Hashtable m_instanceRulesRegistry = new Hashtable();
   
        public string ConversionPattern
        {
            get
            {
                return this.m_pattern;
            }
            set
            {
                this.m_pattern = value;
            }
        }
        static MyPatternLayout()
        {
            MyPatternLayout.s_globalRulesRegistry = new Hashtable(45);
            MyPatternLayout.s_globalRulesRegistry.Add("message", typeof(Logger.Layout.Pattern.MessagePatternConverter));
            MyPatternLayout.s_globalRulesRegistry.Add("event_name", typeof(Logger.Layout.Pattern.EventNamePatternConverter));
            MyPatternLayout.s_globalRulesRegistry.Add("user_ip", typeof(Logger.Layout.Pattern.UserIPPatternConverter));
            MyPatternLayout.s_globalRulesRegistry.Add("log_date", typeof(Logger.Layout.Pattern.RecordTimePatternConverter));
        }

        public MyPatternLayout()
            : this("%message%newline")
        {
        }

        public MyPatternLayout(string pattern)
        {
            this.IgnoresException = true;
            this.m_pattern = pattern;
            if (this.m_pattern == null)
            {
                this.m_pattern = "%message%newline";
            }
            this.ActivateOptions();
        }

        protected virtual PatternParser CreatePatternParser(string pattern)
        {
            PatternParser patternParser = new PatternParser(pattern);
            foreach (DictionaryEntry dictionaryEntry in MyPatternLayout.s_globalRulesRegistry)
            {
                patternParser.PatternConverters[dictionaryEntry.Key] = dictionaryEntry.Value;
            }
            foreach (DictionaryEntry dictionaryEntry in this.m_instanceRulesRegistry)
            {
                patternParser.PatternConverters[dictionaryEntry.Key] = dictionaryEntry.Value;
            }
            return patternParser;
        }

        public override void ActivateOptions()
        {
            this.m_head = this.CreatePatternParser(this.m_pattern).Parse();
            for (PatternConverter patternConverter = this.m_head; patternConverter != null; patternConverter = patternConverter.Next)
            {
                PatternLayoutConverter patternLayoutConverter = patternConverter as PatternLayoutConverter;
                if (patternLayoutConverter != null)
                {
                    if (!patternLayoutConverter.IgnoresException)
                    {
                        this.IgnoresException = false;
                        break;
                    }
                }
            }
        }

        public override void Format(TextWriter writer, LoggingEvent loggingEvent)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (loggingEvent == null)
            {
                throw new ArgumentNullException("loggingEvent");
            }
            for (PatternConverter patternConverter = this.m_head; patternConverter != null; patternConverter = patternConverter.Next)
            {
                patternConverter.Format(writer, loggingEvent);
            }
        }

        public void AddConverter(PatternLayout.ConverterInfo converterInfo)
        {
            this.AddConverter(converterInfo.Name, converterInfo.Type);
        }
  
        public void AddConverter(string name, Type type)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            if (!typeof(PatternConverter).IsAssignableFrom(type))
            {
                throw new ArgumentException("The converter type specified [" + type + "] must be a subclass of log4net.Util.PatternConverter", "type");
            }
            this.m_instanceRulesRegistry[name] = type;
        }
        #endregion
    }
}
