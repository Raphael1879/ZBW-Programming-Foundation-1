using OOP.Interfaces;


namespace OOP
{
    internal static class Game
    {



        public static void Fight(CharacterBase player, CharacterBase enemy)
        {
            while (true) {
                player.ShowStats();
                enemy.ShowStats();

                var playerAction = player.GetAction();
                ExecuteAction(player, playerAction, enemy);

                var enemyAction = enemy.GetAction();
                ExecuteAction(enemy, playerAction, player);
            }
        }

        public static void ExecuteAction(CharacterBase sender, Actions action, CharacterBase reciver)
        {
            switch(action)
            {
                case Actions.ATTACK:
                    {
                        sender.Attack(reciver);
                    } break;
            }
        }
    }
}
