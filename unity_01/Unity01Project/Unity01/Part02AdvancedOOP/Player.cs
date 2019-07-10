namespace Unity01.Part02AdvancedOOP
{
    public class Player: GameObject
    {
        private int _health;

        public Player(Vec2 position, int health = 100) : base(position)
        {
            _health = health;
        }

        public Player(int health = 100)
        {
            _health = health;
        }
        
        public override string ToString()
        {
            // As _position is private, we can't access it outside of the class
            // GameObject. Therefore, we must use a public interface to read it.
            // This is solved by not making _position 'private', but rather 'protected'.
            // It's still private to the outside world, but not to the subclass (this class).
            return $"[player] health={_health} position={base.Position}";
        }
    }
}