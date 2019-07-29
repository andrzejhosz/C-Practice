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

        public int Drive(int mileage)
        {
            _mileage = _mileage + mileage;
            return _mileage;
        }

        public int _service;
        
        public void ServiceCheck()
        {
            _service = _mileage;
        }
    }
}
