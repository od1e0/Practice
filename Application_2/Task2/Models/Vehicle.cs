namespace Task2.Models
{
    public abstract class Vehicle
    {
        private int _speed;
        public int Speed { get { return _speed; } set { _speed = value; } }

        protected Vehicle(int speed) 
        {
            _speed = speed;
        }

        
    }
}
