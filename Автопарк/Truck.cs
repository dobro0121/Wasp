using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP
{
    internal class Truck : Car
    {
        private int _max_capacity;
        private String _FI;
        private Dictionary<String, int> _current_cargo;
        public Truck(String car_brand, int power, int year, int max_capacity, String fi) : base(car_brand, power, year)
        {
            _current_cargo = new Dictionary<String, int>();
            _FI = fi;
            _max_capacity = max_capacity;
        }
        public void setFI(String fi)
        {
            _FI = fi;
        }
        public void add_current_cargo()
        {
            Console.Write("Enter name of cargo: ");
            String name = Console.ReadLine();
            Console.Write("Enter weight of cargo: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            _current_cargo.Add(name, weight);
        }
        public void remove_current_cargo()
        {
            Console.Write("Enter name of cargo: ");
            String name = Console.ReadLine();
            if (_current_cargo.ContainsKey(name))
            {
                _current_cargo.Remove(name);
                Console.WriteLine("Element is delited!");
            }
            else
            {
                Console.WriteLine("Element isn't found!");
            }
        }
        void vivod_current_cargo()
        {
            foreach (var znach in _current_cargo)
            {
                Console.WriteLine($"Название груза: {znach.Key} - Вес груза: {znach.Value}");
            }
        }
        override public String ToString()
        {
            return base.ToString() + String.Format($"Максимальная грузоподъёмность - {_max_capacity} ФИ водителя - {_FI}\n");
        }
    }
}
