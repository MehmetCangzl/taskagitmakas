using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asallıkKOntrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Girn : ");

            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = Asalmi(sayi);

            if (sonuc == 0)
            {
                Console.WriteLine("{0} Asal Sayı Değildir. ", sayi);
            }

            else
            {
                Console.WriteLine("{0} Asal ayıdır. ", sayi);
            }
            Console.ReadKey();

        }

        private static int Asalmi(int sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    return 0;
                }
            }
            if ( i == sayi)
            {
                return 1;
            }
            return 0;
        }
    }
}
