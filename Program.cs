﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MorseCodeWithSound
{
    class Program
    {
        static void Main(string[] args)
        {
            int windowHeight = Console.WindowHeight;
            int developerInfoLine = windowHeight - 2;
            int windowWidth = Console.WindowWidth;
            string dividerLine = new string('-', windowWidth);
            string developerInfo = "Developer: Manish Joshi | Contact: joshimanish7@outlook.com | GitHub: https://github.com/Manish102866 | Version: 1.0.0";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Green;
            string paddedDeveloperInfo = developerInfo.PadRight(windowWidth);
            Console.SetCursorPosition(0, developerInfoLine);
            Console.WriteLine(dividerLine);
            Console.WriteLine(paddedDeveloperInfo);
            Console.ResetColor();

            Console.SetCursorPosition(0, 0);
            Console.Write("Enter text to convert to Morse code: ");
            string input = Console.ReadLine().ToLower();

            Console.SetCursorPosition(0, 2);
            Dictionary<char, string> morseCode = new Dictionary<char, string>()
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {'0', "-----"},
                {' ', " "}
            };
            StringBuilder morseBuilder = new StringBuilder();
            foreach (char c in input)
            {
                if (morseCode.ContainsKey(c))
                {
                    morseBuilder.Append(morseCode[c] + " ");
                }
            }
            string morseCodeString = morseBuilder.ToString();
            foreach (char c in morseCodeString)
            {
                if (c == '.')
                {
                    Console.Write(".");
                    SystemSounds.Beep.Play();
                    System.Threading.Thread.Sleep(200);
                }
                else if (c == '-')
                {
                    Console.Write("-");
                    SystemSounds.Beep.Play();
                    System.Threading.Thread.Sleep(600);
                }
                else if (c == ' ')
                {
                    Console.Write(" ");
                    System.Threading.Thread.Sleep(400);
                }
            }

            Console.SetCursorPosition(0, windowHeight - 1);
            Console.WriteLine(dividerLine);
            Console.WriteLine(paddedDeveloperInfo);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}