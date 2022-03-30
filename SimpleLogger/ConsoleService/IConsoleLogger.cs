namespace SimpleLogger.ConsoleService
{
    public interface IConsoleLogger
    {
        public AdditionalMethods Additional { get; }

        /// <summary>
        /// Show info in console
        /// </summary>
        /// <param name="message">Message text</param>
        public void Info(string message);

        /// <summary>
        /// Show warning in console
        /// </summary>
        /// <param name="message">Message text</param>
        public void Warning(string message);

        /// <summary>
        /// Show error in console
        /// </summary>
        /// <param name="message">Message text</param>
        public void Error(string message);

        /// <summary>
        /// Show fatal in console
        /// </summary>
        /// <param name="message">Message text</param>
        public void Fatal(string message);
    }
}