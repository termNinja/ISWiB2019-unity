namespace Unity01.Part02AdvancedOOP
{
    public class NamedPlayer: Player
    {
        private string _name;
        
        public NamedPlayer(string name, Vec2 position, int health = 100) : base(position, health)
        {
            _name = name;
        }

        public NamedPlayer(string name, int health = 100) : base(health)
        {
            _name = name;
        }

        public string Name
        {
            get => _name;
        }

        public override string ToString()
        {
            return base.ToString() + $" name={_name}";
        }
    }
}