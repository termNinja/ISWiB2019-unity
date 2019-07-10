namespace Unity01.Part02AdvancedOOP
{
    public class GameObject
    {
        private Vec2 _position;

        public GameObject(Vec2 position)
        {
            _position = position;
        }
        
        public GameObject()
        {
            _position = new Vec2();
        }

        public Vec2 Position
        {
            get => _position;
        }
    }
}