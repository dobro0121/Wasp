using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP
{
    internal class Car
    {
        protected String _car_brand;
        protected int _power, _year;
        public Car(String car_brand, int power, int year) 
        { 
            _car_brand = car_brand;
            _power = power;
            _year = year;
        }
        override public String ToString()
        {
            return String.Format($"Марка автомобиля - {_car_brand}\nМощность - {_power} Год производства - {_year} ");
        }
    }
}
