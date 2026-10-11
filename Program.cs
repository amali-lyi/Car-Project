using System;
using System.Collections.Generic;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMovable> transports = new List<IMovable>
            {
                new Car(120),
                new Bicycle(25),
                new Boat(60)
            };

            foreach (IMovable item in transports)
            {
                item.Move();
            }

            Console.WriteLine("\nsorting by speed:");

            List<Car> cars = new List<Car>
            {
                new Car(120),
                new Car(80),
                new Car(150)
            };

            cars.Sort();

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Speed);
            }

            Console.WriteLine("\nsorting by class name:");

            transports.Sort(new TransportComparer());

            foreach (IMovable item in transports)
            {
                Console.WriteLine(item.GetType().Name);
            }

            Console.WriteLine("\ntransport fleet:");

            TransportPark park = new TransportPark();

            park.Add(new Car(100));
            park.Add(new Bicycle(20));
            park.Add(new Boat(50));

            foreach (IMovable item in park)
            {
                item.Move();
            }
        }
    }
}