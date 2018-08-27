using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06 programa año bisiesto";
         
            for(int i = 1; i <= 2018; i++)
            {
                if (i % 4 == 0)
                {                 
                    if(i % 100 != 0)
                    {
                        Console.WriteLine("\nEl año {0} es bisiesto.", i);
                    }
                }

                if (i % 100 == 0 && i % 400 == 0)
                {
                    Console.WriteLine("\nEl año {0} es bisiesto.", i);
                }                
            }
            Console.ReadLine();
        }
    }
}
