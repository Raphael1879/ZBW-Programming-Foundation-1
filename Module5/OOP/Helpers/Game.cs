using OOP.Characters;
using OOP.Interfaces;
using OOP.Inventory;
using OOP.Navigation;
using OOP.Skills;

namespace OOP.Helpers
{
    internal static class Game
    {
        public static Dungeon? Dungeon = null;
        public static int Layer = 1;
        public static double LayerMultiplier = 1;

        public static void StartNewGame()
        {
            ConsoleHelper.DisplayAsciiArt("Sprites/title.txt");
            Console.WriteLine("Chose Player Name");

            var playerName = Console.ReadLine() ?? "Player";

            var player = new Player
            {
                Name = playerName,
                Level = 1,
                Health = 50,
                MaxHealth = 50,
                MaxMana = 3,
                Mana = 3,
                Skills = [new Strike(), new Slice()],
                Items = [new RagePotion(), new RagePotion(), new RagePotion(), new CleansePotion()],
            };



            Dungeon = new Dungeon { Height = 10, Width = 10, RoomLimit = 20, MonsterRooms = 5, ItemRooms = 1, Shops = 1, TreasureRooms = 1 };
            Dungeon.Generate();



            while (player.Health > 0)
            {
                Console.Clear();
                Dungeon.Render();
                var direction = ConsoleHelper.ReadDirection();

                Dungeon.Move(player, direction);
                //Dungeon.DisplayAsciiMapVertical();

                //var menuAction = ConsoleHelper.GetEnumAction<MenuActions>();

                //if (menuAction == MenuActions.GO_DEEPER)
                //{
                //    var nextRoom = Dungeon.Advance();
                //    nextRoom?.OnRoomEnter(player);
                //}

            }

            if (player.Health >= 0)
            {
                Console.Clear();
                ConsoleHelper.Speak("G A M E O V E R", ConsoleColor.DarkRed, 200, true);
            }
        }


        public static double GetLayerMultiplier(int layer)
        {
            if (layer <= 1) return 1;
            double multiplier = 0.9 * Math.Pow(1.6, layer);
            return multiplier;
        }

        public static void GiveXpBasedOnEnemy(CharacterBase gainer, CharacterBase slainEnemy)
        {
            gainer.GiveXp(slainEnemy.Level * 2);
            Console.ReadKey(true);
        }
    }
}
