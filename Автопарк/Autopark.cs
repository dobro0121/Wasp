using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP
{
    internal class Autopark
    {
        String _name;
        List<Car> list;
        public Autopark(String name, List<Car> cars)    
        {
            _name = name;
            list = cars; 

        }
        public override string ToString()
        {
            String vivod = "";
            foreach(Car car in list)
            {
                vivod += car.ToString();
            }
            return vivod;
        }
    }
}
