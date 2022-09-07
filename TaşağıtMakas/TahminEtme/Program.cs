using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahminEtme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 ile 100 arasında bir sayı giriniz : ");

            int sayi = Convert.ToInt32(Console.ReadLine());
            int defa = 0; Random rnd = new Random();
            int aklimdakiSayı = rnd.Next(0 , 100);
            do
            {
                defa++;

                if (sayi > aklimdakiSayı)
                {
                    Console.WriteLine("Daha küçük sayı girin");
                    sayi = Convert.ToInt32(Console.ReadLine());
                } 
                else if (sayi < aklimdakiSayı)
                {
                    Console.WriteLine("Daha büyük bir sayı girin");
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (sayi != aklimdakiSayı);
            Console.WriteLine("Tebrikler Sayıyı {0}. Defa da buldunuz." ,defa) ;
            Console.ReadLine();
        }

        
        

    }
}
