using SimpleLoggerDotNet.ConsoleService;
using SimpleLoggerDotNet.FileService;

namespace SimpleLoggerDotNet.CommonService
{
    public interface ICommonLogger
    {
        /// <summary>
        /// Property get access to console logger
        /// </summary>
        IConsoleLogger Console { get; }

        /// <summary>
        /// Property get access to file logger
        /// </summary>
        IFileLogger File { get; }

        /// <summary>
        /// Method set inited logger interfaces
        /// </summary>
        /// <param name="consoleLogger">console logger interface</param>
        /// <param name="fileLogger">file logger interface</param>
        void SetLoggerInterfaces(IConsoleLogger consoleLogger, IFileLogger fileLogger);

        /// <summary>
        /// Show info in console and write to file
        /// </summary>
        /// <param name="message">Message text</param>
        void Info(string message);

        /// <summary>
        /// Show warning in console and write to file
        /// </summary>
        /// <param name="message">Message text</param>
        void Warning(string message);

        /// <summary>
        /// Show error in console and write to file
        /// </summary>
        /// <param name="message">Message text</param>
        void Error(string message);

        /// <summary>
        /// Show fatal in console and write to file
        /// </summary>
        /// <param name="message">Message text</param>
        void Fatal(string message);
    }
}