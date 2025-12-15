using OOP.Interfaces;

namespace OOP.Navigation
{
    public class RoomGrid
    {
        private readonly Room[,] _rooms;

        public int Size { get; private set; } = 0;


        public RoomGrid(int width, int height)
        {
            _rooms = new Room[width, height];
        }

        public Room? Get(Point p)
        {
            return IsInBounds(p) ? _rooms[p.X, p.Y] : null;
        }

        public void Set(Point p, Room room)
        {
            if (!IsInBounds(p))
                throw new ArgumentOutOfRangeException(nameof(p));

            
            if(Get(p)?.Content is null)
                Size++;
            
                

            _rooms[p.X, p.Y] = room;

 
        }

        public bool Has(Point p) => Get(p) is not null;

        public bool IsInBounds(Point p) =>
            p.X >= 0 && p.Y >= 0 &&
            p.X < _rooms.GetLength(0) &&
            p.Y < _rooms.GetLength(1);



    }

}
