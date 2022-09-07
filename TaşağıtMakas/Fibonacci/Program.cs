using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 1, s2 = 1, s3, s = 2, n;
            Console.Write("n değeri:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            while (s <= n)
            {
                s3 = s1 + s2;
                Console.WriteLine(s3);
                s1 = s2;
                s2 = s3;
                s++;
            }
            Console.ReadLine();
        }
    }
}
