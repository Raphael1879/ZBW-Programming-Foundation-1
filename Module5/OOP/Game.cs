using OOP.Characters;
using OOP.Interfaces;

namespace OOP
{
    internal static class Game
    {

        public static void Fight(CharacterBase player, CharacterBase enemy)
        {
            Console.Clear();
            Speak($"{enemy.Name} Comes out of Nowhere and Attacks", ConsoleColor.DarkMagenta);

            while (true) {
                

                //player Turn
                player.Mana = player.MaxMana;
                var playerTurn = true;
                while (playerTurn)
                {
                    Console.Clear();
                    DisplayFight(player,enemy);
                    var action = player.GetAction();
                    HandleAction(player, action, enemy, ref playerTurn);
                }


                player.GetAction();
            
            }
        }


        public static void HandleAction(CharacterBase user, ActionInfo action, CharacterBase target, ref bool turnActive)
        {
            switch (action.FightAction)
            {
                case FightActions.Fight:
                    {
                        var skill = (ISkill)action.ActionRef;

                        skill.Use(user, target);

                        user.Mana -= skill.Cost;
                        
                    }break;
                case FightActions.End_Turn:
                    {
                        turnActive = false;
                    }break;
            }
        }

        public static void GiveXpBasedOnEnemy(CharacterBase player, CharacterBase slainEnemy)
        {
            player.GiveXp(slainEnemy.Level * 2);
        }

        public static void WriteColored(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void Speak(string text, ConsoleColor color, int delayMs = 50, int endPause = 1000)
        {
            if (text == null) return;

            Console.ForegroundColor = color;

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }

            Console.ResetColor();
            Thread.Sleep(endPause);
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

        public static void DisplayFight(CharacterBase left, CharacterBase right)
        {
            int columnWidth = 38; // a bit wider

            string Pad(string text) => text.PadRight(columnWidth+3);

            // Combines base + temp (if nonzero)
            string StatWithTemp(string label, int baseVal, int tempVal)
            {
                if (tempVal == 0)
                    return $"{label}: {baseVal}";
                return $"{label}: {baseVal} +{tempVal}";
            }

            void WriteRow(string leftText, ConsoleColor leftColor, string rightText, ConsoleColor rightColor)
            {
                WriteColored(Pad(leftText), leftColor);
                WriteColored(Pad(rightText), rightColor);
                Console.WriteLine();
            }

            string Bar(int value, int max, int width, ConsoleColor color)
            {
                int filled = Math.Max(0, Math.Min(width, (int)(value / (double)max * width)));
                int empty = width - filled;

                Console.ForegroundColor = color;
                string segment = new string('█', filled);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                segment += new string('░', empty);

                Console.ResetColor();
                return segment;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("============== ⚔ FIGHT ⚔ ==============");
            Console.ResetColor();
            Console.WriteLine();


            // Borders aligned
            string border = new string('═', columnWidth);
            WriteColored(border, ConsoleColor.DarkGray);
            Console.Write("  ");
            WriteColored(border, ConsoleColor.DarkGray);
            Console.WriteLine();

            // Names
            WriteRow($"🧍 {left.Name}", ConsoleColor.Cyan,
                     $"🧍 {right.Name}", ConsoleColor.Cyan);

            // Level
            WriteRow($"Level: {left.Level}", ConsoleColor.Green,
                     $"Level: {right.Level}", ConsoleColor.Green);

            // Health
            var leftHpColor = left.Health <= left.MaxHealth * 0.30 ? ConsoleColor.Red : ConsoleColor.Green;
            var rightHpColor = right.Health <= right.MaxHealth * 0.30 ? ConsoleColor.Red : ConsoleColor.Green;

            WriteRow(
                $"HP: {left.Health}/{left.MaxHealth}", leftHpColor,
                $"HP: {right.Health}/{right.MaxHealth}", rightHpColor
            );

            // HP Bars
            WriteRow(
                Bar(left.Health, left.MaxHealth, 22, leftHpColor), leftHpColor,
                Bar(right.Health, right.MaxHealth, 22, rightHpColor), rightHpColor
            );

            // Mana
            WriteRow(
                $"Mana: {left.Mana}/{left.MaxMana}", ConsoleColor.Blue,
                $"Mana: {right.Mana}/{right.MaxMana}", ConsoleColor.Blue
            );

            // Mana Bars
            WriteRow(
                Bar(left.Mana, left.MaxMana, 22, ConsoleColor.Blue), ConsoleColor.Blue,
                Bar(right.Mana, right.MaxMana, 22, ConsoleColor.Blue), ConsoleColor.Blue
            );


            // Strength + TemporaryStrength
            WriteRow(
                StatWithTemp("Strength", left.Strength, left.TempoaryStrengt), ConsoleColor.Magenta,
                StatWithTemp("Strength", right.Strength, right.TempoaryStrengt), ConsoleColor.Magenta
            );

            // Luck + TemporaryLuck
            WriteRow(
                StatWithTemp("Luck", left.Luck, left.TempoaryLuck), ConsoleColor.Yellow,
                StatWithTemp("Luck", right.Luck, right.TempoaryLuck), ConsoleColor.Yellow
            );

            // Bottom border
            WriteColored(border, ConsoleColor.DarkGray);
            Console.Write("  ");
            WriteColored(border, ConsoleColor.DarkGray);
            Console.WriteLine();

            Console.WriteLine();
        }

    }
}
