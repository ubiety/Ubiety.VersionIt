﻿using System;
using System.Drawing;
using Colorful;

namespace Ubiety.Console.Ui
{
    public class Platform : IPlatform
    {
        public VerbosityLevel Verbosity { get; set; }

        public void Exit(int exitCode)
        {
            Environment.Exit(exitCode);
        }

        public void WriteLine(string message, Color color, Formatter[] formatters = null)
        {
            if (Verbosity == VerbosityLevel.Silent) return;

            if (formatters is null)
                Colorful.Console.WriteLine(message, color);
            else
                Colorful.Console.WriteLineFormatted(message, color, formatters);
        }

        public void WriteLine(string message, Formatter[] formatters = null)
        {
            WriteLine(message, Color.Empty, formatters);
        }
    }
}