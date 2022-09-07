using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeşKezİsimYazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {//if ile
            int s = 1;
        yaz:
            Console.WriteLine("Merhaba");
            s = s + 1;
            if (s <= 5) goto yaz;
            Console.WriteLine();

            //for ile
            for ( s = 1; s <= 5; s++)

                Console.WriteLine("Merhaba");
            Console.WriteLine();

            //while ile
            s = 1;

            while (s <= 5)
            {
                Console.WriteLine("Merhaba");
                s++;
            }

            Console.ReadLine();

            
        }
    }
}
