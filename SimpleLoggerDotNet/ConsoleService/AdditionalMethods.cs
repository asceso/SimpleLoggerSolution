using System;

namespace SimpleLoggerDotNet.ConsoleService
{
    public class AdditionalMethods
    {
        #region private fields

        private readonly ConsoleColor _DefaultColor;
        private ConsoleColor _InfoColor;
        private ConsoleColor _WarningColor;
        private ConsoleColor _ErrorColor;
        private ConsoleColor _FatalColor;
        private bool _PrintDate = false;
        private bool _ColoredPrint = false;

        #endregion private fields

        #region public methods

        /// <summary>
        /// Enable colored print in logger
        /// </summary>
        public void EnableColoredPrint() => _ColoredPrint = true;

        /// <summary>
        /// Disable colored print in logger
        /// </summary>
        public void DisableColoredPrint() => _ColoredPrint = false;

        /// <summary>
        /// Enable print date in logger
        /// </summary>
        public void EnablePrintDate() => _PrintDate = true;

        /// <summary>
        /// Disable print date in logger
        /// </summary>
        public void DisablePrintDate() => _PrintDate = false;

        public enum ColorCode
        { Info, Warning, Error, Fatal }

        /// <summary>
        /// Set console colors
        /// </summary>
        /// <param name="infoColor">Info color, as default set White</param>
        /// <param name="warningColor">Warning color, as default set DarkYellow</param>
        /// <param name="errorColor">Error color, as default set Red</param>
        /// <param name="fatalCollor">Fatal color, as default set DarkRed</param>
        public void SetConsoleLoggerColors(ConsoleColor infoColor = ConsoleColor.White,
                                           ConsoleColor warningColor = ConsoleColor.DarkYellow,
                                           ConsoleColor errorColor = ConsoleColor.Red,
                                           ConsoleColor fatalCollor = ConsoleColor.DarkRed)
        {
            _InfoColor = infoColor;
            _WarningColor = warningColor;
            _ErrorColor = errorColor;
            _FatalColor = fatalCollor;
        }

        /// <summary>
        /// Set single color
        /// </summary>
        /// <param name="colorCode">code for color, enum in additional class</param>
        /// <param name="color">color to set</param>
        public void SetConsoleLoggerColor(ColorCode colorCode, ConsoleColor color)
        {
            switch (colorCode)
            {
                case ColorCode.Info: _InfoColor = color; break;
                case ColorCode.Warning: _WarningColor = color; break;
                case ColorCode.Error: _ErrorColor = color; break;
                case ColorCode.Fatal: _FatalColor = color; break;
                default: break;
            }
        }

        #endregion public methods

        #region ctor

        public AdditionalMethods()
        {
            _PrintDate = false;
            _DefaultColor = Console.ForegroundColor;
            _InfoColor = ConsoleColor.White;
            _WarningColor = ConsoleColor.DarkYellow;
            _ErrorColor = ConsoleColor.Red;
            _FatalColor = ConsoleColor.DarkRed;
        }

        #endregion ctor

        #region internal access

        internal bool IsColoredPrint => _ColoredPrint;

        internal bool IsPrintDate() => _PrintDate;

        internal ConsoleColor GetDefaultConsoleColor() => ConsoleColor.Gray;

        internal ConsoleColor GetColor(ColorCode color)
        {
            switch (color)
            {
                case ColorCode.Info:
                    return _InfoColor;

                case ColorCode.Warning:
                    return _WarningColor;

                case ColorCode.Error:
                    return _ErrorColor;

                case ColorCode.Fatal:
                    return _FatalColor;

                default:
                    return _DefaultColor;
            }
        }

        #endregion internal access
    }
}