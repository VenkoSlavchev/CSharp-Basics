using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10_BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            Console.WriteLine("Set the time ");
            string time = Console.ReadLine();
            string[] hour = time.Split(':');
            int numhour = int.Parse(hour[0]);
            int index = time.LastIndexOf(":");
            string minutes = time.Substring(index + 1, 2);
            int numminutes = int.Parse(minutes);
            string designator = time.Substring(index + 3, 2);
            if ((numhour >= 12) || (0 > numminutes) || (numminutes > 59))
            {
                Console.WriteLine("Invalid time");
            }
            else
            {
                if (((numhour >= 1) && (numminutes >= 0) && (designator == "PM")) || ((numhour < 3) && (numminutes >= 0) && (designator == "AM")))
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
        }
    }
}