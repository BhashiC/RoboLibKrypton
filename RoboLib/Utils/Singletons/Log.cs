using RoboLib.Extensions;
using RoboLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoboLib.Utils.Singletons
{
    internal class Log : Singleton<Log>
    {
        List<string> _pendingLog = new List<string>();
        readonly object _lockPendingLog = new object();
        string _logDirectory = string.Empty;
        const string dateTimeFormat = "dd MMM yyyy, HH:mm:ss.fff";

        /// <summary>
        /// Write a log entry
        /// </summary>
        /// <param name="severity"></param>
        /// <param name="procedureName"></param>
        /// <param name="text"></param>
        public void Write(Severities severity, string procedureName, string text)
        {
            if (Robot.Instance != null && Robot.Instance.LogSeverity > severity)
            {
                return;
            }
            else
            {
                WriteEntry(MakeLogString(Thread.CurrentThread.ManagedThreadId, DateTime.Now, severity, procedureName, text));
            }
        }

        void WriteEntry(string log)
        {
            lock (_lockPendingLog)
            {
                _pendingLog.Add(log);
                try
                {
                    string filePath = GetLogFilePath();

                    using (StreamWriter logWriter = new StreamWriter(filePath, true))
                    {
                        foreach (string line in _pendingLog)
                        {
                            logWriter.WriteLine(line);
                        }
                        _pendingLog.Clear();
                    }
                }
                catch { }
            }
        }

        string GetLogFilePath()
        {
            SetLogDirectory();
            if (string.IsNullOrEmpty(_logDirectory))
            {
                throw new RException("Log directory is not set yet!");
            }
            var dateTime = DateTime.Now;
            return string.Format(@"{0}\{1}.log", _logDirectory, dateTime.ToString("dd-MM-yyyy"));
        }

        void SetLogDirectory()
        {
            if (!string.IsNullOrEmpty(_logDirectory))
            {
                return;
            }
            if (!string.IsNullOrEmpty(Robot.Instance.Elvis(x => x.RootFolder)))
            {
                _logDirectory = string.Format(@"{0}\Log", Robot.Instance.RootFolder);
                Robot.Instance.EnsureDirectory(_logDirectory);
            }
            // If RootFolder is not set yet, do it next time
        }

        string MakeLogString(int threadId, DateTime dateTime, Severities severity, string procedureName, string text)
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}",
                                    dateTime.ToString(dateTimeFormat),
                                    severity,
                                    procedureName,
                                    threadId,
                                    text);
        }
    }
}
