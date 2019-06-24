﻿using System;
using FFXIV_ACT_Plugin.Logfile;

namespace FFXIV.Framework.XIVHelper
{
    public class XIVLog
    {
        public XIVLog(
            string logLine,
            uint logType = 0)
        {
            this.MessageType = Enum.IsDefined(typeof(LogMessageType), (int)logType) ?
                    (LogMessageType)Enum.ToObject(typeof(LogMessageType), (int)logType) :
                    LogMessageType.LogLine;

            this.Timestamp = logLine.Substring(0, 15).TrimEnd();
            this.Log = logLine.Remove(0, 15);
        }

        public long No { get; set; } = 0;

        public string Timestamp { get; set; } = string.Empty;

        public LogMessageType MessageType { get; set; } = LogMessageType.LogLine;

        public string Log { get; set; } = string.Empty;

        public string LogLine => $"{this.Timestamp} {this.Log}";

        public override string ToString() => this.LogLine;
    }
}
