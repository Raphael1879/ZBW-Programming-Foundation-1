
namespace OOP.Map
{
    using OOP.Interfaces;
    using System;
    using System.Collections.Generic;

    public class Dungeon
    {
        private readonly Random _rng = new Random();

        public List<Room> Path { get; private set; } = new List<Room>();
        public int CurrentPosition { get; private set; } = 0;

        public Dungeon(int length)
        {
            GeneratePath(length);
        }

        public void GeneratePath(int length)
        {
            Path.Clear();
            Path.Add(new Room { RoomType = RoomType.Empty });

            for (int i = 0; i < (length-1); i++)
            {
                // Pick a random event type
                Array values = Enum.GetValues(typeof(RoomType));

                RoomType type = (RoomType)values.GetValue(_rng.Next(1,values.Length-1));


                Path.Add(new Room { RoomType = type });
            }

            Path.Add(new Room { RoomType = RoomType.Boss });

            CurrentPosition = 0;
        }

        // Move player forward and return the Room
        public Room? Advance()
        {
            if (CurrentPosition >= Path.Count - 1)
            {
                return null; // Reached end
            }

            CurrentPosition++;
            return Path[CurrentPosition];
        }



        public void DisplayAsciiMapVertical()
        {
            Console.Clear();
            Console.WriteLine("=== DUNGEON DESCENT ===\n");

            for (int i = 0; i < Path.Count; i++)
            {
                DrawRoom(i);
            }

            Console.WriteLine($"\nDepth: {CurrentPosition} / {Path.Count - 1}");
        }

        private void DrawRoom(int index)
        {
            var point = Path[index];

            ConsoleColor color = point.RoomType switch
            {
                RoomType.Monster => ConsoleColor.Red,
                RoomType.Item => ConsoleColor.Green,
                RoomType.Campfire => ConsoleColor.Yellow,
                RoomType.Random => ConsoleColor.Cyan,
                RoomType.Boss => ConsoleColor.DarkRed,
                _ => ConsoleColor.White
            };

            string symbol = point.RoomType switch
            {
                RoomType.Empty => " ",
                RoomType.Monster => "M",
                RoomType.Item => "I",
                RoomType.Campfire => "C",
                RoomType.Random => "?",
                RoomType.Boss => "B",
                _ => "?"
            };

            bool playerHere = (index == CurrentPosition);
            if( playerHere)
            {
                symbol = "@";
                color = ConsoleColor.Blue;
            }

            // Top border
            Console.WriteLine(" +-------+");
                Console.Write(" |   ");
                Console.ForegroundColor = color;
                Console.Write(symbol);
                Console.ResetColor();
                Console.Write("   |");
                if (playerHere) Console.Write("  <--");
                Console.WriteLine();

            // Bottom border
            Console.WriteLine(" +-------+");

            // Connector to next room
            if (index < Path.Count - 1)
            {
                Console.WriteLine("     │");
            }
        }


    }

}
