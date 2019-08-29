using System;
using System.Collections.Generic;
using System.Text;

namespace CarDrive
{
    class Car
    {
        public enum Brand
        {
            BMW, FIAT, VW, AUDI, SKODA, MERCEDES
        }

        public int _mileage;
        public int _service;

        public int Drive(int mileage)
        {
            _mileage = _mileage + mileage;
            return _mileage;
        }

        public void ServiceCheck()
        {
            _service = _mileage;
            if (_service > 20000)
            {
                Console.WriteLine("Your car needs service !");
            }
        }

        public void DoService()
        {
            _mileage = 0;
        }

        public int HackMileage()
        {
            Console.WriteLine("Enter secret password");
            string pass = Console.ReadLine();
            if (pass == "hackmileage")
            {
                Console.WriteLine("Insert current mileage:");
                int _newmileage = Int32.Parse(Console.ReadLine());
                _mileage = _newmileage;
            }
            else
            {
                Console.WriteLine("Wrong password! Press any button to continue");
                Console.ReadKey();
            }
            return _mileage;
        }
        
    }
}
