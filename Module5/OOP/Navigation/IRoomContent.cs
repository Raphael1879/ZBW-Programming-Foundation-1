using OOP.Characters;

namespace OOP.Navigation
{
    public interface IRoomContent
    {
        public bool Cleared { get; set; }
        public void OnRoomEnter(CharacterBase player);
    }
}
