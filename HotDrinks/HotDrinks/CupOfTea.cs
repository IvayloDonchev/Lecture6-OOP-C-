using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinks
{
    public class CupOfTea : IHotDrink
    {
        public CupOfTea()
        {
            LeafType = "Green";
            Instant = false;
            Milk = true;
            Shugar = 3;
            Description = $"{LeafType} cup of tea";
        }
        public CupOfTea(string leafType, bool instant, bool milk, byte shugar)
        {
            LeafType = leafType;
            Instant = instant;
            Milk = milk;
            Shugar = shugar;
            Description = $"{LeafType} cup of tea";
        }
        public string LeafType { get; }
        public bool Instant { get; set; }
        public bool Milk { get; set; }
        public byte Shugar { get; set; }
        public string Description { get; } = "Cuf of tea";
        public byte AddShugar(byte amount)
        {
            Shugar += amount;
            return Shugar;
        }
        public override string ToString() => $"{LeafType} {(Instant ? " instant" : "")} cup of tea {(Milk ? " with milk" : "")} and {(Shugar>0 ? "shugar" : "no shugar ")}";   
    }
}
