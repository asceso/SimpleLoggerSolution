using SimpleLogger.ConsoleService;
using System;

namespace Demo
{
    class Program
    {
        static IConsoleLogger consoleLogger;
        static void Main()
        {
            consoleLogger = new ConsoleLogger();

            consoleLogger.Info("Test info message");
            consoleLogger.Warning("Test warning message");
            consoleLogger.Error("Test error message");
            consoleLogger.Fatal("Test fatal message");

            consoleLogger.Additional.EnablePrintDate();
            Console.WriteLine();

            consoleLogger.Info("Test info message");
            consoleLogger.Warning("Test warning message");
            consoleLogger.Error("Test error message");
            consoleLogger.Fatal("Test fatal message");

            consoleLogger.Additional.SetConsoleLoggerColors(ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Red, ConsoleColor.Yellow);
            consoleLogger.Additional.DisablePrintDate();
            Console.WriteLine();

            consoleLogger.Info("Test info message");
            consoleLogger.Warning("Test warning message");
            consoleLogger.Error("Test error message");
            consoleLogger.Fatal("Test fatal message");

            consoleLogger.Additional.EnablePrintDate();
            Console.WriteLine();

            consoleLogger.Info("Test info message");
            consoleLogger.Warning("Test warning message");
            consoleLogger.Error("Test error message");
            consoleLogger.Fatal("Test fatal message");

            consoleLogger.Additional.SetConsoleLoggerColor(AdditionalMethods.ColorCode.Fatal, ConsoleColor.Blue);
            consoleLogger.Additional.DisablePrintDate();
            Console.WriteLine();

            consoleLogger.Info("Test info message");
            consoleLogger.Warning("Test warning message");
            consoleLogger.Error("Test error message");
            consoleLogger.Fatal("Test fatal message");

            consoleLogger.Additional.EnablePrintDate();
            Console.WriteLine();

            consoleLogger.Info("Test info message");
            consoleLogger.Warning("Test warning message");
            consoleLogger.Error("Test error message");
            consoleLogger.Fatal("Test fatal message");

            Console.ReadKey();
        }
    }
}
