using OOP.Characters;

namespace OOP.Navigation.Rooms
{
    public class SpawnRoom : IRoomContent
    {
        public bool Cleared { get; set; } = true;

        public void OnRoomEnter(CharacterBase player)
        {
        }
    }
}
