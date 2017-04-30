using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinks
{
    interface IHotDrink
    {
        bool Instant { get; set; }
        bool Milk { get; set; }
        byte Shugar { get; set; }
        string Description { get; }
        byte AddShugar(byte amount);
    }
}
