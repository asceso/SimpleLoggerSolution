namespace SimpleLogger.FileService
{
    public interface IFileLogger
    {
        /// <summary>
        /// Set path to write logs
        /// </summary>
        /// <param name="path">path</param>
        public void SetLogsPath(string path);

        /// <summary>
        /// Init logs folder, if folder not exist method create it
        /// </summary>
        public void InitLogsFolder();

        /// <summary>
        /// Write info in file
        /// </summary>
        /// <param name="message">Message text</param>
        public void Info(string message);

        /// <summary>
        /// Write warning in file
        /// </summary>
        /// <param name="message">Message text</param>
        public void Warning(string message);

        /// <summary>
        /// Write error in file
        /// </summary>
        /// <param name="message">Message text</param>
        public void Error(string message);

        /// <summary>
        /// Write fatal in file
        /// </summary>
        /// <param name="message">Message text</param>
        public void Fatal(string message);
    }
}