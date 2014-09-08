using System;

namespace Problem6
{
    class StringsAndObjects
    {
        static void Main()
        {
            string a = "Hello";
            string b = "World";
            object c = a +" "+ b;
            string d= ((string) c);
            Console.WriteLine(d);
        }
    }
}
