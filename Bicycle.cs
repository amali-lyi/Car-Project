namespace MyProject
{
    class Bicycle : IMovable
    {
        public int Speed { get; set; }

        public Bicycle(int speed)
        {
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"the bicycle is moving. speed: {Speed} km/h");
        }
    }
}