using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP
{
    internal class Program_2
    {
        static void Main(string[] args)
        {
            PassengerCar PassengerCar_1 = new PassengerCar("Infiniti", 150, 2019, 5);
            Truck Truck_1 = new Truck("Volvo", 200, 2012, 3000, "Николаев Антон Валерьевич");
            PassengerCar PassengerCar_2 = new PassengerCar("Hyundai", 100, 2020, 7);
            PassengerCar PassengerCar_3 = new PassengerCar("Tesla", 300, 2022, 5);
            Truck Truck_2 = new Truck("Mercedes-Benz", 300, 2018, 4000, "Цапля Эдуард Вениаминович");
            Autopark autopark = new Autopark("Autopark", new List<Car>
            {
                PassengerCar_1,
                Truck_1,
                PassengerCar_2,
                Truck_2,
                PassengerCar_3,
            });
            Console.WriteLine(autopark.ToString());
            Console.ReadKey();
        }
    }
}
