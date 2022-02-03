using NUnit.Framework;
using SimpleLogger.ConsoleService;

namespace LoggerTests
{
    public class Tests
    {
        IConsoleLogger logger;

        [SetUp]
        public void Setup()
        {
            logger = new ConsoleLogger();
        }

        [Test]
        public void TestAllMethods()
        {
            logger.Info("Test info message");
            logger.Warning("Test warning message");
            logger.Error("Test error message");
            logger.Fatal("Test fatal message");

            logger.Additional.EnablePrintDate();

            logger.Info("Test info message");
            logger.Warning("Test warning message");
            logger.Error("Test error message");
            logger.Fatal("Test fatal message");
            Assert.Pass();
        }
    }
}