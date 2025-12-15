using OOP.Characters;

namespace OOP.Interfaces
{
    public interface IRoomContent
    {
        public bool Cleared { get; set; }
        public void OnRoomEnter(CharacterBase player);
    }
}
