using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Pz0920_WPF_Logger.DebugUtilities
{
    internal class Logger
    {
        enum LogLevel
        {
            Info,
            Warning,
            Error
        }

        const string FILE_EXT = ".log";
        const string DATE_FORMAT = "yyyy-MM-dd HH:mm:ss.fff";
        static readonly object fileLock = new object();

        static string LogFileName { get; set; }
            = $"{AppDomain.CurrentDomain.FriendlyName}{FILE_EXT}";

        public static string LogFilePath { get; private set; }
            = $"{Path.Combine(SettingsFolderLocation, LogFileName)}";

        static string SettingsFolderLocation
        {
            get
            {
                string folderPath =
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                    "EMP SW",
                    AppDomain.CurrentDomain.FriendlyName.ToUpper());

                if (!Directory.Exists(folderPath))
                {
                    try
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    catch(Exception ex)
                    {
                        throw new Exception("Faild to create log folder.", ex);
                    }
                }

                return folderPath;
            }
        }

        static void WriteLine(string text, bool append = false)
        {
            lock (fileLock)
            {
                if(string.IsNullOrWhiteSpace(text))
                    return;

                for(int attempt = 0; attempt < 10; attempt++)
                {
                    try
                    {
                        using (StreamWriter writer = 
                                new StreamWriter(LogFilePath, append, Encoding.UTF8))
                        {
                            writer.AutoFlush = true;
                            writer.WriteLine($"Time: {DateTime.Now.ToString(DATE_FORMAT)}:\t" +
                                $"Message: {text}");
                        }
                        break;
                    }
                    catch(Exception ex)
                    {
                        Thread.Sleep(10);
                    }
                }
            }
        }

        static void WriteFormattedLog(LogLevel level, string text)
        {
            string logLevelString = $"[{level.ToString().ToUpper()}]";
            WriteLine($"{logLevelString} {text}\n", true);
        }

        public static void Error(string text)
            => WriteFormattedLog(LogLevel.Error, text);

        public static void Info(string text)
            => WriteFormattedLog(LogLevel.Info, text);

        public static void Warning(string text)
            => WriteFormattedLog(LogLevel.Warning, text);

    }
}
