using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇarpımTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {

                for (int i = 1; i < 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write("{0}*{1}={2}\t", i, a, (i * a));
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            

        }
    }
    
}
