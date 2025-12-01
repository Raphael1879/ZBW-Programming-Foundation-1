using OOP;
using OOP.Characters;
using OOP.Interfaces;
using OOP.Inventory;
using OOP.Map;
using OOP.Skills;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.ResetColor();

Console.WriteLine("---- Fight Game ----");
Console.WriteLine("Chose Player Name");

var playerName = Console.ReadLine() ?? "Player";

var player = new Player
{
    Name = playerName,
    Level = 1,
    Health = 5,
    MaxHealth = 5,
    Luck = 1,
    Strength = 1,
    MaxMana = 3,
    Mana = 3,
    Skills = [new Strike()],
    Items = [new RagePotion(), new RagePotion(), new RagePotion(), new RagePotion()],
};



var dungeon = new Dungeon(10);

while(true)
{


    //Game.WriteColored($"You are at {depth}m Deep in the Dungeon", ConsoleColor.Red);
    //Console.WriteLine();

    dungeon.DisplayAsciiMapVertical();

    var menuAction = Game.GetEnumAction<MenuActions>();

    if (menuAction == MenuActions.GO_DEEPER)
    {
        var nextRoom = dungeon.Advance();
        nextRoom?.OnRoomEnter(player);
        //Game.Fight(player, enemy1);
        //depth += 10;
    }

}








