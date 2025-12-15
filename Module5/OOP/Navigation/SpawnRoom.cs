
using OOP.Characters;
using OOP.Interfaces;

namespace OOP.Navigation
{
    public class SpawnRoom : IRoomContent
    {
        public bool Cleared { get; set; } = true;

        public void OnRoomEnter(CharacterBase player)
        {
        }
    }
}
