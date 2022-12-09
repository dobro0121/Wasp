using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP
{
    public class Disk : IStoreItem
    {
        protected string name, genre;
        protected int burnCount;
        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
            burnCount = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Genre
        {
            get { return name; }
            set { name = value; }
        }
        public double Price { get; set; }
        public virtual int DiskSize { get; set;}
        public virtual void Burn (params string[] values) { }
        public void DiscountPrice( int percent)
        {
            Price *= ((100 - percent) / 100.0);
        }

    }
}
