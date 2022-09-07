using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfOrBirlikte
{
    internal class Program
    {
        static void Main(string[] args)
        {   Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ünlü şairimiz Mehmet Akif'in soy adı nedir?\nCevabınız :");
            string cevap = Console.ReadLine();


            if (cevap == "Ersoy" || cevap == "ersoy" || cevap == "ERSOY")
            {   Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Tebrikler doğru bildiniz ");
            }

            else
            {
                Console.WriteLine("Cevabınız yanlış");
            }
            Console.ReadLine();
        }
    }
}
