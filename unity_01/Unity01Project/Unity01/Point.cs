namespace Unity01
{
    public class Point
    {
        private float _x, _y;

        public Point(float x, float y)
        {
            _x = x;
            _y = y;
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
    }
}