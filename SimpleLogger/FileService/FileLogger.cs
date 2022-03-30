using System;
using System.IO;

namespace SimpleLogger.FileService
{
    public class FileLogger : IFileLogger
    {
        #region private fields

        private enum LogLevel
        { INFO, WARNING, ERROR, FATAL }

        private static string _LogsFolderPath;
        private static bool _InitComplete;
        private readonly string _TimeFormat = "HH:mm:ss";

        #endregion private fields

        #region init

        public FileLogger() => _LogsFolderPath = Environment.CurrentDirectory + "/logs/";

        #endregion init

        #region private methods

        private void CheckInitFolder()
        {
            if (!_InitComplete)
            {
                throw new ArgumentException("Init logs folder before use public methods");
            }
        }

        private string GenerateLogFilename() => $"{DateTime.Now:ddMMyyyy}.log";

        private string GenerateMessageWithLogLevel(string message, LogLevel level) => $"{DateTime.Now.ToString(_TimeFormat)}|{level}|{message}";

        private void CreateOrAppendLogFile(string message, LogLevel level)
        {
            CheckInitFolder();
            string finalFilepath = _LogsFolderPath + GenerateLogFilename();
            if (!File.Exists(finalFilepath))
            {
                using StreamWriter writer = new StreamWriter(finalFilepath);
                writer.WriteLine(GenerateMessageWithLogLevel(message, level));
                writer.Close();
            }
            else
            {
                using StreamWriter writer = new StreamWriter(finalFilepath, true);
                writer.WriteLine(GenerateMessageWithLogLevel(message, level));
                writer.Close();
            }
        }

        #endregion private methods

        #region public methods

        public void SetLogsPath(string path) => _LogsFolderPath = path;

        public void InitLogsFolder()
        {
            if (!Directory.Exists(_LogsFolderPath))
            {
                Directory.CreateDirectory(_LogsFolderPath);
                _InitComplete = true;
            }
            else
            {
                _InitComplete = true;
            }
        }

        public void Info(string message) => CreateOrAppendLogFile(message, LogLevel.INFO);

        public void Warning(string message) => CreateOrAppendLogFile(message, LogLevel.WARNING);

        public void Error(string message) => CreateOrAppendLogFile(message, LogLevel.ERROR);

        public void Fatal(string message) => CreateOrAppendLogFile(message, LogLevel.FATAL);

        #endregion public methods
    }
}