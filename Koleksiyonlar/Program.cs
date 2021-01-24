using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            name.Add("Kadir");
            name.Add("Berna");

            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
          
            name.Add("Miray");
            Console.WriteLine(name[2]);
            Console.WriteLine(name[0]);

        }
    }
}
