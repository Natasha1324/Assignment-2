using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_No._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++) 
            {
                if (num % 15 == 0) 
                {
                    Console.WriteLine("Hello Goodbye");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Hello");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            
        }
    }
}
