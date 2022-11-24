using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace WASP
{
    internal class PassengerCar : Car
    {
        private int _kolvo_passengers;
        private Dictionary<String, int> _repair_book;
        public PassengerCar(String car_brand, int power, int year, int kolvo_passengers) : base(car_brand, power, year) {
            _repair_book = new Dictionary<String, int>();
            _kolvo_passengers = kolvo_passengers;
        }
        public void add_spare_parts()
        {
            Console.Write("Enter car brand: ");
            String spare_parts = Console.ReadLine();
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            _repair_book.Add(spare_parts, year);
        }
        public int get_year(String spare_parts)
        {
            if(_repair_book.TryGetValue(spare_parts, out int years))
            {
                return (_repair_book[spare_parts]);
            }
            else
            {
                Console.Write("Doesn't have this spare_part");
                return -1;
            }
        }
        void vivod_repair_book()
        {
            foreach (var znach in _repair_book)
            {
                Console.WriteLine(String.Format($"Запчасть: {znach.Key} - Год замены: {znach.Value}"));
            }
        }
        override public String ToString()
        {
            return base.ToString() + String.Format($"Количество пассажиров - {_kolvo_passengers}\n");
        }
    }
}
