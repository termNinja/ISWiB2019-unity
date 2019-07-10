namespace Unity01.Part01TheGameExample
{
    public class Player
    {
        private int _health;
        private Vec2 _position;

        public Player(int health, Vec2 position)
        {
            this._health = health;
            this._position = position;
        }
        
        public Player(Vec2 position)
        {
            this._health = 100;
            this._position = position;
        }
        
        public Player()
        {
            this._health = 100;
            this._position = new Vec2();
        }


        public void ReduceHealth(int damage)
        {
            _health -= damage;
        }

        public bool IsAlive()
        {
            return _health > 0;
        }

        public int Health
        {
            get => _health;
        }

        public Vec2 Position
        {
            get => _position;
        }

        public override string ToString()
        {
            return $"[player] health={_health} position={_position}";
        }
    }
}