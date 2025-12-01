using OOP.Interfaces;
using OOP.Skills;
using System.IO.Pipes;
using System.Transactions;

namespace OOP.Characters
{
    internal class Player : CharacterBase
    {
        public List<IItem> Items { get; set; } = [];

        public override ActionInfo GetAction()
        {

            DisplaySkillsAndItemsSideBySide();

            Console.ReadLine();
            var action = new Strike();



            return new ActionInfo
            {
                FightAction = FightActions.Fight,
                ActionRef = action,
            };
        }


        public void DisplaySkillsAndItemsSideBySide()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var skills = Skills;
            var items = Items;

            int leftWidth = 45;
            int rightWidth = 45;

            string leftTitle = " Skills ";
            string rightTitle = " Items ";

            // Top border
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
                $"+{new string('-', leftWidth)}+  +{new string('-', rightWidth)}+");

            // Titles
            Console.WriteLine(
                $"|{leftTitle.PadRight(leftWidth)}|  |{rightTitle.PadRight(rightWidth)}|");

            // Under titles
            Console.WriteLine(
                $"+{new string('-', leftWidth)}+  +{new string('-', rightWidth)}+");

            int maxRows = Math.Max(skills.Count, items.Count);

            for (int i = 0; i < maxRows; i++)
            {
                List<string> leftLines = new();
                List<string> rightLines = new();

                // LEFT column (skills)
                if (i < skills.Count)
                {
                    var s = skills[i];

                    leftLines.Add($"{i + 1}. {s.Name}");

                    // Description wrapping
                    foreach (var line in WrapText($"    Description: {s.Description}", leftWidth - 2))
                        leftLines.Add(line);

                    leftLines.Add($"    Cost: {s.Cost}");
                    leftLines.Add($"    Type: {s.Type}");
                }

                // RIGHT column (items)
                if (i < items.Count)
                {
                    var it = items[i];

                    rightLines.Add($"I{i + 1}. {it.Name}");

                    foreach (var line in WrapText($"   Description: {it.Description}", rightWidth - 2))
                        rightLines.Add(line);
                }

                // Equalize height
                int maxHeight = Math.Max(leftLines.Count, rightLines.Count);
                while (leftLines.Count < maxHeight) leftLines.Add("");
                while (rightLines.Count < maxHeight) rightLines.Add("");

                // Print row lines
                for (int j = 0; j < maxHeight; j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    string left = leftLines[j].PadRight(leftWidth - 1);
                    string right = rightLines[j].PadRight(rightWidth - 1);

                    Console.WriteLine($"| {left}|  | {right}|");
                }

                // Row separator
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(
                    $"+{new string('-', leftWidth)}+  +{new string('-', rightWidth)}+");
            }

            Console.ResetColor();
        }

        // === Helper: wrap long text so borders never move ===
        private List<string> WrapText(string text, int maxWidth)
        {
            List<string> lines = new();
            if (string.IsNullOrEmpty(text))
                return lines;

            while (text.Length > maxWidth)
            {
                lines.Add(text.Substring(0, maxWidth));
                text = "    " + text.Substring(maxWidth);
            }

            lines.Add(text);
            return lines;
        }



        //public override void GetAction()
        //{
        //    Console.Clear();
        //    Game.DisplayFight();
        //    var action = Game.GetEnumAction<FightActions>();
        //    switch (action)
        //    {
        //        case FightActions.Fight:
        //            {
        //                var choosenSkill = ChooseSkill(); 
        //            }
        //            break;
        //        case FightActions.Item:
        //            {

        //            }break;
        //    }

    }
}
