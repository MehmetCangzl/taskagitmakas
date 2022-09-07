using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozitif_sayıların_karesini_alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, kare;
        sayi_al:

            Console.Write("Sayı:");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < 0)
                goto sayi_al;

            kare = x * x;

            Console.Write("Sayı=" + x + "karesi=" + kare);
            Console.ReadLine();
            for (int i = 0; i < length; i++)
            {

            }
        }
        
    }
}
