using OOP.Interfaces;
using System.Runtime.CompilerServices;

namespace OOP
{
    internal class Player : CharacterBase
    {
        public override Actions GetAction()
        {
            while (true)
            {
                Console.WriteLine("---- CHOOSE ACTION ----");
                foreach (Actions option in Enum.GetValues(typeof(Actions)))
                {
                    Console.WriteLine($"{(int)option} - {option}");
                }

                var keyInfo = Console.ReadKey();
                var input = keyInfo.KeyChar.ToString();

                if (Enum.TryParse(input, true, out Actions action))
                {
                    Console.WriteLine($" -> {action}");
                    return action;
                }

                Console.WriteLine();
                Console.WriteLine(" Invalid action. Try again.");

            }
        }
    }
}
