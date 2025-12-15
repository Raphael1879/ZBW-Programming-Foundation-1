namespace OOP.Navigation
{
    using OOP.Characters;
    using OOP.Interfaces;
    using System;
    using System.ComponentModel;

    public class Dungeon
    {
        public required int Width { get; set; }
        public required int Height { get; set; }
        public required int RoomLimit { get; set; }
        public required int MonsterRooms { get; set; }
        public required int ItemRooms { get; set; }
        public required int TreasureRooms { get; set; }
        public required int Shops { get; set; }




        public RoomGrid? Rooms;

        public Queue<Point> Queue = new Queue<Point>();

        public Point Spawn { get; set; }
        public Point PlayerPosition { get; set; }

        public void Generate()
        {
            Rooms = new RoomGrid(Width, Height);

            Queue.Clear();

            Spawn = GetSpawnCoords();

            Rooms.Set(Spawn, new Room { Symbol = "S", Color = ConsoleColor.Blue, Content = new SpawnRoom() }); //spawn

            Queue.Enqueue(Spawn);

            StartQueue();

            FillEmptyRooms();

            PlayerPosition = Spawn;
        }

        public void Move(CharacterBase player, Direction d)
        {
            if (Rooms is null) return;

            var nextPosition = d switch
            {
                Direction.Up => PlayerPosition.Up(),
                Direction.Right => PlayerPosition.Right(),
                Direction.Down => PlayerPosition.Down(),
                Direction.Left => PlayerPosition.Left(),
                _ => throw new ArgumentOutOfRangeException(),
            };

            if (!Rooms.IsInBounds(nextPosition) || !Rooms.Has(nextPosition)) return;

            var nextRoom = Rooms.Get(nextPosition);
            nextRoom?.Content?.OnRoomEnter(player);

            PlayerPosition = nextPosition;
        }

        private void FillEmptyRooms()
        {
            for(int i = 0; i < MonsterRooms; i++)
            {
                var randomRoom = GetRandomEmptyRoom();
                Rooms.Set(randomRoom, new Room
                {
                    Symbol = "M",
                    Color = ConsoleColor.Red,
                    Content = new MonsterRoom()
                });
            }

            //Todo finish impl

            //for (int i = 0; i < MonsterRooms; i++)
            //{
            //    var randomRoom = GetRandomEmptyRoom();
            //    Rooms.Set(randomRoom, new Room
            //    {
            //        Symbol = "M",
            //        Color = ConsoleColor.Red,
            //        Content = new MonsterRoom()
            //    });
            //}
        }

        private Point GetSpawnCoords()
        {
            var y = (int)Math.Round((double)Height / 2);
            var x = (int)Math.Round((double)Width / 2);

            return new Point(x, y);
        }

        private Room GenerateEmptyRoom()
        {
            if(Rooms.Size >= RoomLimit -1)
            {
                return new Room
                {
                    Symbol = "B",
                    Color = ConsoleColor.DarkRed,
                    Content = new BossRoom()
                };
            }

            return new Room
            {
                Symbol = "☐",
                Color = ConsoleColor.Gray
            };
        }

        private void StartQueue()
        {
            if (Rooms is null)
            {
                return;
            }


            while (Rooms.Size < RoomLimit)
            {
                Point current;

                // Pick next point from queue if available, else random existing room
                if (Queue.Any())
                {
                    current = Queue.Dequeue();
                }
                else
                {
                    current = GetRandomRoom();
                }

                TryGenerateRoomsAround(current);
            }
        }

        private void TryGenerateRoomsAround(Point p)
        {
            var directions = new[]
            {
                p.Up(),
                p.Down(),
                p.Left(),
                p.Right()
            };

            directions = directions
                .Where(p => !Rooms!.Has(p) && Rooms!.IsInBounds(p)) 
                .OrderBy(_ => Random.Shared.Next())
                .ToArray();

            if(directions.Any())
            {
                var d = directions.First();

                Rooms!.Set(d, GenerateEmptyRoom());
                Queue.Enqueue(d);
            }
        }

        public Point GetRandomRoom()
        {
            if (Rooms!.Size == 0)
                throw new InvalidOperationException("No rooms in grid");

            int target = Random.Shared.Next(Rooms!.Size);

            int count = 0;

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {

                    if (!Rooms.Has(new Point(x,y)))
                        continue;

                    if (count == target)
                        return new Point(x, y);

                    count++;
                }
            }

            throw new InvalidOperationException("Room count mismatch");
        }

        public Point GetRandomEmptyRoom()
        {
            if (Rooms is null)
                throw new InvalidOperationException("Dungeon not generated");

            int emptyCount = 0;

            // First pass: count empty rooms
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    var p = new Point(x, y);
                    var room = Rooms.Get(p);

                    if (room is not null && room.Content is null)
                        emptyCount++;
                }
            }

            if (emptyCount == 0)
                throw new InvalidOperationException("No empty rooms available");

            int target = Random.Shared.Next(emptyCount);
            int current = 0;

            // Second pass: select target
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    var p = new Point(x, y);
                    var room = Rooms.Get(p);

                    if (room is null || room.Content is not null)
                        continue;

                    if (current == target)
                        return p;

                    current++;
                }
            }

            throw new InvalidOperationException("Empty room count mismatch");
        }

        public void Render()
        {
            if(Rooms is null)
            {
                return;
            }

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    var p = new Point(x, y);
                    var room = Rooms.Get(p);
                    var symbol = " ";
                    if(room is not null)
                    {
                        Console.ForegroundColor = room.Color;
                        symbol = room.Symbol;

                        if(p == PlayerPosition)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            symbol = "@";

                        }
                    }

                    Console.Write(symbol);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }

}
