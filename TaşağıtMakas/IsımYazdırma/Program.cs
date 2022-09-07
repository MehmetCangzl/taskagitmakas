using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsımYazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Console.Write("Adını YAzın : ");
            ad = Console.ReadLine();

            Console.Write("Merhaba " + ad);
            Console.ReadLine();
        }
    }
}
