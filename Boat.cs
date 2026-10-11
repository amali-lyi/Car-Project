namespace MyProject
{
    class Boat : IMovable
    {
        public int Speed { get; set; }

        public Boat(int speed)
        {
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"the boat is moving. speed: {Speed} km/h");
        }
    }
}