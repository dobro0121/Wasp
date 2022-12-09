using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASP
{
    public interface IStoreItem
    {
        double Price{ get; set; }
        void DiscountPrice(int percent);
    }
}
