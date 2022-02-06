using System;
using System.Collections.Generic;

namespace EinfachAlex.Utils.Logging
{
    public class Logger
    {
        private static LogLevel logLevel = LogLevel.VERBOSE; //Log all messages by default - should be changed in startup process
        private static bool saveMessages = true;

        private static readonly List<string> messages = new List<string>();

        public static void setLogLevel(LogLevel logLevel) => Logger.logLevel = logLevel;

        public static void c(string logMessage)
        {
            messages.Add(logMessage);

            Logger.log(LogLevel.CRITICAL, logMessage);
        }

        public static void e(string logMessage)
        {
            messages.Add(logMessage);

            Logger.log(LogLevel.ERROR, logMessage);
        }

        public static void w(string logMessage)
        {
            messages.Add(logMessage);

            Logger.log(LogLevel.WARNING, logMessage);
        }

        public static void i(string logMessage)
        {
            messages.Add(logMessage);

            Logger.log(LogLevel.INFO, logMessage);
        }

        public static void s(string logMessage)
        {
            messages.Add(logMessage);

            Logger.log(LogLevel.SUCCESS, logMessage);
        }

        public static void u(string logMessage)
        {
            messages.Add(logMessage);

            Logger.log(LogLevel.USERRETARD, logMessage);
        }

        public static void v(string logMessage)
        {
            messages.Add(logMessage);

            Logger.log(LogLevel.VERBOSE, logMessage);
        }

        /// <summary>
        /// DEPRECATED DO NOT USE ANYMORE
        /// </summary>
        public static void log(LogLevel loggerEnum, string logMessage)
        {
            if (loggerEnum > Logger.logLevel) return;

            Console.Write($"{DateTime.Now}.{DateTime.Now.Millisecond.ToString().PadRight(3)} - ");
            Console.Write($"[{loggerEnumToString(loggerEnum)}]: ");
            logMessageFormattingPrefix(logMessage);
            Console.ResetColor();
            
            if(!saveMessages) messages.Clear();
        }

        private static void logMessageFormattingPrefix(string logMessage)
        {
            if (logMessage.Contains("[") && logMessage.Contains("]"))
            {
                ConsoleColor reset = Console.ForegroundColor;
                
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string[] format = logMessage.Split("[")[1].Split("]");
                Console.Write($"[{format[0]}]");

                Console.ForegroundColor = reset;
                Console.WriteLine(format[1]);
            }
            else
            {
                Console.WriteLine(logMessage);
            }
        }

        private static string loggerEnumToString(LogLevel loggerEnum)
        {
            switch (loggerEnum)
            {
                case LogLevel.CRITICAL:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    return "C";

                case LogLevel.ERROR:
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "E";

                case LogLevel.WARNING:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    return "W";

                case LogLevel.INFO:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    return "I";

                case LogLevel.SUCCESS:
                    Console.ForegroundColor = ConsoleColor.Green;
                    return "S";
                
                case LogLevel.VERBOSE:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    return "V";

                case LogLevel.USERRETARD:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    return "USERRETARD";

                default:
                    throw new Exception();
            }
        }
        
    }
}