using System;

namespace SimpleLogger.ConsoleService
{
    public class ConsoleLogger : IConsoleLogger
    {
        #region init

        private readonly AdditionalMethods _Additional;
        public ConsoleLogger() => _Additional = new AdditionalMethods();

        #endregion
        #region private methods

        public AdditionalMethods Additional { get => _Additional; }

        private enum LogLevel { INFO, WARNING, ERROR, FATAL }
        private readonly string _DateTimeFormat = "dd.MM.yy|HH:mm:ss";
        private readonly string _TimeFormat = "HH:mm:ss";

        private void WriteMessageWithLogLevel(string message, LogLevel level)
        {
            Console.WriteLine($"{DateTime.Now.ToString(Additional.IsPrintDate() ? _DateTimeFormat : _TimeFormat)}|{level}|{message}");
        }
        private void SetColorAndSendMessage(ConsoleColor color, string message, LogLevel level)
        {
            if (Additional.IsColoredPrint)
            {
                Console.ForegroundColor = color;
                WriteMessageWithLogLevel(message, level);
                Console.ForegroundColor = Additional.GetColor(AdditionalMethods.ColorCode.Default);
            }
            else
            {
                if (Console.ForegroundColor != Additional.GetColor(AdditionalMethods.ColorCode.Default))
                {
                    Console.ForegroundColor = Additional.GetColor(AdditionalMethods.ColorCode.Default);
                }
                WriteMessageWithLogLevel(message, level);
            }
        }

        #endregion
        #region public methods

        public void Info(string message) => SetColorAndSendMessage(Additional.GetColor(AdditionalMethods.ColorCode.Info), message, LogLevel.INFO);
        public void Warning(string message) => SetColorAndSendMessage(Additional.GetColor(AdditionalMethods.ColorCode.Warning), message, LogLevel.WARNING);
        public void Error(string message) => SetColorAndSendMessage(Additional.GetColor(AdditionalMethods.ColorCode.Error), message, LogLevel.ERROR);
        public void Fatal(string message) => SetColorAndSendMessage(Additional.GetColor(AdditionalMethods.ColorCode.Fatal), message, LogLevel.FATAL);

        #endregion
    }
}
