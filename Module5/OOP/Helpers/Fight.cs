using OOP.Characters;
using OOP.Interfaces;
using OOP.Inventory;
using OOP.Skills;
using System.Text;

namespace OOP.Helpers
{
    public class Fight
    {
        public required CharacterBase Character1 { get; set; }
        public required CharacterBase Character2 { get; set; }

        public CharacterBase? Winner { get; set; }
        public CharacterBase? Looser { get; set; }

        private int TurnCounter { get; set; }

        public void StartFight()
        {
            //Combat Start
            TurnCounter = 1;
            Character1.OnCombatStart();
            Character2.OnCombatStart();

            //Fight Loop
            while (!HasWinner())
            {
                //C1 Turn
                ExecuteTurn(Character1, Character2);
                if (HasWinner()) continue;

                //C2 Turn
                ExecuteTurn(Character2, Character1);
                if (HasWinner()) continue;

                TurnCounter++;
            }

            //Fight is over
            Console.Clear();
            Render();
            ConsoleHelper.Speak($"{Winner!.Name} has slain {Looser!.Name}");
            Console.WriteLine();
        }

        private void ExecuteTurn(CharacterBase user, CharacterBase target)
        {
            var turnActive = true;
            user.OnTrunStart();
            CheckForWinner(user, target);
            Render();

            while (turnActive && !HasWinner())
            {
                Render();
                var action = user.GetAction();
                HandleAction(user, action, target, ref turnActive);
                CheckForWinner(user, target);
            }

            user.OnTurnEnd();
            Render();
            CheckForWinner(user, target);
        }

        private void HandleAction(CharacterBase user, ActionInfo action, CharacterBase target, ref bool turnActive)
        {
            switch (action.Type)
            {
                case FightActions.Fight:
                    {
                        var skill = action.ObjectRef as ISkill;
                        skill?.Use(user, target);
                        user.Mana -= skill?.Cost ?? 0;
                    }
                    break;
                case FightActions.Item:
                    {
                        var item = action.ObjectRef as IItem;
                        if (item is not null)
                        {
                            item.Use(user, target);
                            user.Items.Remove(item);
                            ConsoleHelper.Speak($"{user.Name} uses {item.Name}", ConsoleColor.DarkYellow);
                        }
                    }
                    break;

                case FightActions.End_Turn:
                    {
                        turnActive = false;
                    }
                    break;
            }
        }

        private void CheckForWinner(CharacterBase user, CharacterBase target)
        {
            if (target.Health <= 0)
            {
                Looser = target;
                Winner = user;
            }
            else if (user.Health <= 0)
            {
                Looser = user;
                Winner = target;
            }
        }

        public bool HasWinner()
        {
            return Winner is not null && Looser is not null;
        }

        public void Render() {

            var player = Character1;
            var enemy = Character2;

            Console.Clear();

            int consoleWidth = Console.WindowWidth;

            // ---------- TITLE ----------

            Console.WriteLine();
            string title = "============== ⚔ FIGHT ⚔ ==============";
            Console.SetCursorPosition(ConsoleHelper.CenterStartX(title), Console.CursorTop);
            ConsoleHelper.WriteColored(title, ConsoleColor.DarkYellow);
            Console.WriteLine();
            Console.WriteLine();

            // ---------- TOP BAR ----------

            string hpBar = ConsoleHelper.Bar(player.Health, player.MaxHealth, 18);
            string manaBar = ConsoleHelper.Bar(player.Mana, player.MaxMana, 18);

            string fullLine =
                $"Turn {TurnCounter} | " +
                $"HP {player.Health}/{player.MaxHealth} {hpBar} | " +
                $"MP {player.Mana}/{player.MaxMana} {manaBar} | ";

            int startX = ConsoleHelper.CenterStartX(fullLine);
            Console.SetCursorPosition(startX, Console.CursorTop);

            // write segments explicitly
            ConsoleHelper.WriteColored($"Turn {TurnCounter}", ConsoleColor.Gray);
            ConsoleHelper.WriteColored(" | ", ConsoleColor.DarkGray);

            ConsoleHelper.WriteColored($"HP {player.Health}/{player.MaxHealth} ", ConsoleColor.Gray);
            ConsoleHelper.WriteColored(hpBar, ConsoleColor.Red);
            ConsoleHelper.WriteColored(" | ", ConsoleColor.DarkGray);

            ConsoleHelper.WriteColored($"MP {player.Mana}/{player.MaxMana} ", ConsoleColor.Gray);
            ConsoleHelper.WriteColored(manaBar, ConsoleColor.Blue);
            ConsoleHelper.WriteColored(" | ", ConsoleColor.DarkGray);

            Console.WriteLine();

            // Status effects
            var statusEffects = new StringBuilder();
            player.Effects.ForEach(effect => statusEffects.Append(effect.Symbol + " " + effect.Stack + " "));
            ConsoleHelper.WriteCentered(statusEffects.ToString());
            Console.WriteLine();


            string sep = new string('═', consoleWidth);
            ConsoleHelper.WriteColored(sep, ConsoleColor.DarkGray);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // ---------- ENEMY NAME ----------

            string enemyHpBar = ConsoleHelper.Bar(enemy.Health, enemy.MaxHealth, 22);
            string enemyLine =
                $"{enemy.Name} | HP {enemy.Health}/{enemy.MaxHealth} {enemyHpBar}";

            Console.SetCursorPosition(ConsoleHelper.CenterStartX(enemyLine), Console.CursorTop);

            ConsoleHelper.WriteColored(enemy.Name, ConsoleColor.Cyan);
            ConsoleHelper.WriteColored(" | ", ConsoleColor.DarkGray);

            ConsoleHelper.WriteColored($"HP {enemy.Health}/{enemy.MaxHealth} ", ConsoleColor.Gray);
            ConsoleHelper.WriteColored(enemyHpBar, ConsoleColor.Red);

            Console.WriteLine();

            //ENEMY STATUS EFFECTS

            var enemyStatusEffects = new StringBuilder();
            enemy.Effects.ForEach(effect => enemyStatusEffects.Append(effect.Symbol + " " + effect.Stack + " "));
            ConsoleHelper.WriteCentered(enemyStatusEffects.ToString());
            Console.WriteLine();

            // ---------- LOAD SPRITE ----------


            if (!string.IsNullOrWhiteSpace(enemy.SpritePath) && File.Exists(enemy.SpritePath))
            {
                ConsoleHelper.DisplayAsciiArt(enemy.SpritePath);
            }

            ConsoleHelper.WriteColored(sep, ConsoleColor.DarkGray);
            Console.WriteLine();
        }

    }
}
