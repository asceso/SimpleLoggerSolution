using SimpleLogger.ConsoleService;
using SimpleLogger.FileService;

namespace SimpleLogger.CommonService
{
    public interface ICommonLogger
    {
        /// <summary>
        /// Property get access to console logger
        /// </summary>
        public IConsoleLogger Console { get; }

        /// <summary>
        /// Property get access to file logger
        /// </summary>
        public IFileLogger File { get; }

        /// <summary>
        /// Method set inited logger interfaces
        /// </summary>
        /// <param name="consoleLogger">console logger interface</param>
        /// <param name="fileLogger">file logger interface</param>
        public void SetLoggerInterfaces(IConsoleLogger consoleLogger, IFileLogger fileLogger);

        /// <summary>
        /// Show info in console and write to file
        /// </summary>
        /// <param name="message">Message text</param>
        public void Info(string message);

        /// <summary>
        /// Show warning in console and write to file
        /// </summary>
        /// <param name="message">Message text</param>
        public void Warning(string message);

        /// <summary>
        /// Show error in console and write to file
        /// </summary>
        /// <param name="message">Message text</param>
        public void Error(string message);

        /// <summary>
        /// Show fatal in console and write to file
        /// </summary>
        /// <param name="message">Message text</param>
        public void Fatal(string message);
    }
}