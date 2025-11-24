using OOP;
using System.Runtime.CompilerServices;

Console.WriteLine("---- Fight Game ----");
Console.WriteLine("Chose Player Name");

var playerName = Console.ReadLine() ?? "Player";


var player = new Player
{
    Name = playerName,
    Level = 1,
    Health = 5
};

var enemy1 = new Enemy
{
    Name = "Fungus",
    Level = 17,
    Health = 10
};

Game.Fight(player, enemy1);




