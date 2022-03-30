using NUnit.Framework;
using SimpleLoggerDotNet.ConsoleService;
using SimpleLoggerDotNet.FileService;
using System;
using System.Collections.Generic;

namespace LoggerTests
{
    public class TestsDotNet
    {
        private IConsoleLogger logger;
        private IFileLogger fileLogger;
        private readonly int bulkTestCount = 10000;

        [SetUp]
        public void Setup()
        {
            logger = new ConsoleLogger();
            fileLogger = new FileLogger();
        }

        [Test]
        public void TestConsoleLogger()
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

        [Test]
        public void TestFileLogger()
        {
            fileLogger.InitLogsFolder();
            fileLogger.Info("Test info message");
            fileLogger.Warning("Test warning message");
            fileLogger.Error("Test error message");
            fileLogger.Fatal("Test fatal message");
            Assert.Pass();
        }

        [Test]
        public void TestFileLoggerWithBulkData()
        {
            List<string> randomWords = new List<string>()
            {
                "Гнездиться",
                "Девятисотлетний",
                "Мрачный",
                "Надрать",
                "Начатки",
                "Непреложный",
                "Откуда",
                "Полосчатый",
                "Резь",
                "Шип",
                "Венчаться",
                "Гербарий",
                "Дрель",
                "Запустение",
                "Зоосад",
                "Лесостепь",
                "Огневой",
                "Растяжимый",
                "Умственный",
                "Фуражка"
            };

            fileLogger.InitLogsFolder();
            Random random = new Random();
            for (int i = 0; i < bulkTestCount; i++)
            {
                int firstWordIndex = random.Next(randomWords.Count);
                int secondWordIndex = random.Next(randomWords.Count);

                string message = $"{randomWords[firstWordIndex]} {randomWords[secondWordIndex]}";
                int level = random.Next(0, 4);
                switch (level)
                {
                    case 0: fileLogger.Info(message); break;
                    case 1: fileLogger.Warning(message); break;
                    case 2: fileLogger.Error(message); break;
                    case 3: fileLogger.Fatal(message); break;
                }
            }
            Assert.Pass();
        }
    }
}