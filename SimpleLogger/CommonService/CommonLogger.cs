using SimpleLogger.ConsoleService;
using SimpleLogger.FileService;

namespace SimpleLogger.CommonService
{
    public class CommonLogger : ICommonLogger
    {
        private IConsoleLogger consoleLogger;
        private IFileLogger fileLogger;

        public IConsoleLogger Console => consoleLogger;
        public IFileLogger File => fileLogger;
        public void SetLoggerInterfaces(IConsoleLogger consoleLogger, IFileLogger fileLogger)
        {
            this.consoleLogger = consoleLogger;
            this.fileLogger = fileLogger;
        }
        public void Info(string message)
        {
            consoleLogger.Info(message);
            fileLogger.Info(message);
        }
        public void Warning(string message)
        {
            consoleLogger.Warning(message);
            fileLogger.Warning(message);
        }
        public void Error(string message)
        {
            consoleLogger.Error(message);
            fileLogger.Error(message);
        }
        public void Fatal(string message)
        {
            consoleLogger.Fatal(message);
            fileLogger.Fatal(message);
        }
    }
}
