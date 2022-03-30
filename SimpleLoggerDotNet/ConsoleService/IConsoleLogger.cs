namespace SimpleLoggerDotNet.ConsoleService
{
    public interface IConsoleLogger
    {
        AdditionalMethods Additional { get; }

        /// <summary>
        /// Show info in console
        /// </summary>
        /// <param name="message">Message text</param>
        void Info(string message);

        /// <summary>
        /// Show warning in console
        /// </summary>
        /// <param name="message">Message text</param>
        void Warning(string message);

        /// <summary>
        /// Show error in console
        /// </summary>
        /// <param name="message">Message text</param>
        void Error(string message);

        /// <summary>
        /// Show fatal in console
        /// </summary>
        /// <param name="message">Message text</param>
        void Fatal(string message);
    }
}