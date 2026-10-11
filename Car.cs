namespace MyProject
{
    class Car : IMovable, IComparable<Car>
    {
        public int Speed { get; set; }

        public Car(int speed)
        {
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"the car is moving. speed: {Speed} km/h");
        }

        public int CompareTo(Car other)
        {
            return Speed.CompareTo(other.Speed);
        }
    }
}