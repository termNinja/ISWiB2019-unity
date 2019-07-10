namespace Unity01.Part02AdvancedOOP
{
    public class Vec2
    {
        private float _x, _y;

        public Vec2(float x, float y)
        {
            _x = x;
            _y = y;
        }
        
        public Vec2()
        {
            _x = 0f;
            _y = 0f;
        }


        public void Translate(float dx, float dy)
        {
            _x += dx;
            _y += dy;
        }
        
        public void Translate(Vec2 translationVector)
        {
            _x += translationVector._x;
            _y += translationVector._y;
        }


        public float X
        {
            get => _x;
            set => _x = value;
        }

        public float Y
        {
            get => _y;
            set => _y = value;
        }

        public override string ToString()
        {
            return $"({_x}, {_y})";
        }
    }
}