using System;

namespace CarDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            ConsoleKeyInfo input;

            Console.WriteLine("Select your car brand :");
            Console.WriteLine();
            foreach (var item in Enum.GetValues(typeof(Car.Brand)))
                Console.WriteLine(item);
            Console.WriteLine();
            var brand = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Input your car color :");
            Console.WriteLine();
            var color = Console.ReadLine();
            Console.Clear();
            do
            {
                Console.Clear();
                Console.WriteLine($"Your car is {color} {brand}");
                Console.WriteLine($"You have driven {car._mileage} km");
                car.ServiceCheck();
                Console.WriteLine("What do you want to do ? :");
                Console.WriteLine("Press D to drive");
                Console.WriteLine("Press S for car service");
                Console.WriteLine("Press H to hack the mileage");
                Console.WriteLine("Press Q to quit");

                input = Console.ReadKey();

                switch (input.KeyChar.ToString())
                {
                    case "d":
                        Console.WriteLine("How many km would you like to drive ?");
                        var mileage = Int32.Parse(Console.ReadLine());
                        car.Drive(mileage);
                        break;
                    case "s":
                        car.DoService();
                        break;
                    case "h":
                        car.HackMileage();
                        break;
                    default:
                        break;
                }
            }
            while (input.Key != ConsoleKey.Q);
        }
    }
}
