using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinks
{
    public class CupOfCoffee : IHotDrink
    {
        public string BeanType { get; }
        public bool Instant { get; set; }
        public bool Milk { get; set; }
        public byte Shugar { get; set; }
        public CupOfCoffee()
        {
            BeanType = "Arabica";
            Instant = false;
            Milk = false;
            Shugar = 2;
            Description = $"{BeanType} coffee";
        }
        public CupOfCoffee(string beanType, bool instant, bool milk, byte shugar, string description)
        {
            this.BeanType = beanType;
            this.Instant = instant;
            this.Milk = milk;
            this.Shugar = shugar;
        }
        public string Description { get; }
        public byte AddShugar(byte amount)
        {
            Shugar += amount;
            return Shugar;
        }
        public override string ToString() => $"{BeanType}{(Instant ? " instant" : "")} cup of coffee {(Milk ? "with milk" : "")}{(Milk && Shugar>0 ? "and shugar" : "")}{(Shugar>0 ? "with shugar" : "no shugar ")}";
    }
}
