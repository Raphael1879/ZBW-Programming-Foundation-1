using OOP.Interfaces;

namespace OOP.Navigation
{
    public class Room
    {
        public string Symbol { get; set; }
        public ConsoleColor Color { get; set; } = ConsoleColor.White;
        public IRoomContent? Content { get; set; }

    }
}
