using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    public readonly record struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point Left() => new(X - 1, Y);
        public Point Right() => new(X + 1, Y);
        public Point Up() => new(X, Y - 1);
        public Point Down() => new(X, Y + 1);
    }
}
