using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP
{
    public class DVD : Disk
    {
        string producer, filmCompany;
        int minutesCount;
        public DVD(string producer, string filmCompany, int minutesCount, string name, string genre) : base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.minutesCount = minutesCount;
        }
        public override int DiskSize { get => (minutesCount/64) * 2; }
        public override void Burn(params string[] values)
        {
            producer = values[0];
            filmCompany = values[1];
            minutesCount = Convert.ToInt32(values[2]);
            name = values[3];
            genre = values[4];
            burnCount++;
        }
        public override string ToString()
        {
            return $"Name - {name}, genre - {genre}, producer - {producer}, film Company - {filmCompany}, count of minutes - {minutesCount}, count of burns - {burnCount}";
        }
    }
}
