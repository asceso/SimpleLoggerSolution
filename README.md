# SimpleLoggerService

---

### RU

- [Поддерживаемые платформы](#поддерживаемые-платформы)
- [Руководство использования](#руководство-использования)
- [Дополнительные методы](#дополнительные-методы)
- [Файл логгер](#файл-логгер)

---

## Поддерживаемые платформы
Проект нацелен как минимум на .NET Standard 2.0 и .NET Core 3.1.

## Руководство использования
Для работы с логгером необходимо инициализировать его

```C#
IConsoleLogger consoleLogger;

void Main()
{
  consoleLogger = new ConsoleLogger();
}
```

Далее для использования доступны методы Info, Warning, Error, Fatal</br>
Пример использования

```C#
consoleLogger.Info("Test info message");
consoleLogger.Warning("Test warning message");
consoleLogger.Error("Test error message");
consoleLogger.Fatal("Test fatal message");
```

## Дополнительные методы

Для использования дополнительных методов необходимо обращаться к объекту Additional. Реализованы следующие дополнительные методы</br>
Параметр печатать дату в логгере, если установлен true (по умолчанию false) в логах печатается дата</br>
Для управления параметром используются методы EnablePrintDate() и DisablePrintDate()</br>
Пример использования

```C#
//Включает печать дат в логе (true)
consoleLogger.Additional.EnablePrintDate();

//Выключает печать дат в логе (false)
consoleLogger.Additional.DisablePrintDate();
```

При необходимости задать цвет в консоли используется метод EnableColoredPrint(), метод DisableColoredPrint() выключает цвет в консоли</br>
Для изменения цветов используются методы SetConsoleLoggerColors() и SetConsoleLoggerColor()</br>
Пример использования

```C#
//Включает цветную печать в консоли
consoleLogger.Additional.EnableColoredPrint();

//Выключает цветную печать в консоли
consoleLogger.Additional.DisableColoredPrint();

//Устанавлиает цвета перечисляя их в качестве параметров, порядок параметров Info, Warning, Error, Fatal
//По умолчанию после инициализации используются цвета White, DarkYellow, Red, DarkRed
consoleLogger.Additional.SetConsoleLoggerColors(ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Red, ConsoleColor.Yellow);

//Устанавливает определенный цвет по его enum
consoleLogger.Additional.SetConsoleLoggerColor(AdditionalMethods.ColorCode.Fatal, ConsoleColor.Blue);
```

## Файл логгер
Для работы с файл логгером необходимо инициализировать его

```C#
IFileLogger fileLogger;

void Main()
{
  fileLogger = new FileLogger();
  fileLogger.InitLogsFolder();
}
```

По умолчанию директория задается <текущий путь> + /logs/
При необходимости изменить директорию можно использовать метод

```C#
fileLogger.SetLogsPath("your_path");
```

Пример использования
```C#
IFileLogger fileLogger;

void Main()
{
  fileLogger = new FileLogger();
  fileLogger.SetLogsPath("your_path");
  fileLogger.InitLogsFolder();
}
```

Далее для использования доступны методы Info, Warning, Error, Fatal</br>
Пример использования

```C#
fileLogger.Info("Test info message");
fileLogger.Warning("Test warning message");
fileLogger.Error("Test error message");
fileLogger.Fatal("Test fatal message");
```
