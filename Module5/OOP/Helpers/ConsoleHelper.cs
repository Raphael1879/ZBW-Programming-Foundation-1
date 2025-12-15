using OOP.Characters;
using OOP.Interfaces;
using static System.Net.Mime.MediaTypeNames;


namespace OOP.Helpers
{
    public static class ConsoleHelper
    {
        public static void WriteColored(string text, ConsoleColor color)
        {
            var prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = prev;
        }

        public static void Speak(string text, ConsoleColor color = ConsoleColor.White, int delayMs = 25, bool endPause = true)
        {
            if (text == null) return;

            Console.ForegroundColor = color;

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }

            Console.ResetColor();
            Console.ReadKey(true);
        }


        public static T GetEnumAction<T>() where T : struct, Enum
        {
            while (true)
            {
                Console.WriteLine("---- CHOOSE ACTION ----");

                foreach (T option in Enum.GetValues(typeof(T)))
                {
                    Console.WriteLine($"{Convert.ToInt32(option)} - {option}");
                }

                var keyInfo = Console.ReadKey();
                var input = keyInfo.KeyChar.ToString();

                Console.WriteLine();

                // Parse numeric or string inputs
                if (int.TryParse(input, out int numeric))
                {
                    if (Enum.IsDefined(typeof(T), numeric))
                    {
                        T result = (T)Enum.ToObject(typeof(T), numeric);
                        Console.WriteLine($" -> {result}");
                        return result;
                    }
                }
                else if (Enum.TryParse(input, true, out T parsed))
                {
                    Console.WriteLine($" -> {parsed}");
                    return parsed;
                }

                Console.WriteLine(" Invalid action. Try again.");
            }
        }

        public static Direction ReadDirection()
        {
            while (true)
            {
                var key = Console.ReadKey(intercept: true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        return Direction.Up;

                    case ConsoleKey.DownArrow:
                        return Direction.Down;

                    case ConsoleKey.LeftArrow:
                        return Direction.Left;

                    case ConsoleKey.RightArrow:
                        return Direction.Right;
                }
            }
        }


        public static int CenterStartX(string text)
        {
            if (text.Length >= Console.WindowWidth)
                return 0;

            return (Console.WindowWidth - text.Length) / 2;
        }

        public static void WriteCentered(string text)
        {
            int startX = CenterStartX(text);
            Console.SetCursorPosition(startX, Console.CursorTop);

            Console.WriteLine(text);
        }


        public static string Bar(int value, int max, int width)
        {
            if (max <= 0) max = 1;
            int filled = Math.Clamp((int)(value / (double)max * width), 0, width);
            return new string('█', filled) + new string('░', width - filled);
        }

        public static void DisplayAsciiArt(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found: " + filePath);
                return;
            }



            string[] lines = File.ReadAllLines(filePath);
            int startX = CenterStartX(lines[0]);

            foreach (string line in lines)
            {
                Console.SetCursorPosition(startX, Console.CursorTop);
                Console.WriteLine(line);
            }
        }
    }
}
