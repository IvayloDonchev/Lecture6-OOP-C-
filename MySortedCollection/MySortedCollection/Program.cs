using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortedCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m1 = new Man("Ivaylo Donchev",    new DateTime(1971,10,12));
            Man m2 = new Man("Georgi Ivanov", new DateTime(1977, 2, 9));
            Man m3 = new Man("Victor Stefanov", new DateTime(1998, 10, 5));
            Man m4 = new Man("Angel Dimitrov",  new DateTime(1998, 10, 4));
            Man m5 = new Man("Petar Hristov", 15, 3, 1990); 

            Man[] array = new Man[] { m1, m2, m3, m4, m5 };
            Array.Sort(array);
            //Array.Sort(array, (x, y) =>  // още един начин за сортиране (без да е необходим интерфейс)
            //        {
            //            if (x.Age < y.Age) return -1;
            //            else if (x.Age == y.Age) return 0;
            //            else return 1;
            //        }
            //);

            foreach (var man in array)
                Console.WriteLine(man);

            List<Man> manList = new List<Man>() { m1, m2, m3, m4, m5 };
            manList.Sort();
            Console.WriteLine();
            foreach(var man in manList)
                Console.WriteLine(man);
        }
    }
}
