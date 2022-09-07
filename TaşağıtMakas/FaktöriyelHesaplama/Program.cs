using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktöriyelHesaplama
{
    internal class Program
    {

        private static string soru;


        static void Main(string[] args)
        {
            
            Console.Write("Bir Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;

            bool yeniden = true;

            while (yeniden)
            {

                for (int i = 1; i <= sayi; i++)
                {
                     faktoriyel *= i;

                }

                    Console.WriteLine(sayi + "! = " + faktoriyel);
            
                Console.ForegroundColor = ConsoleColor.Red;              
                Console.WriteLine("");
                
               
                Console.WriteLine(faktoriyel.ToString());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Yeniden E/H ");
                string sorgu = Console.ReadLine().ToUpper();

                if (soru == "H")
                {
                    yeniden = false;
                }
                else
                {
                   
                    Console.Write("Bir Sayı Giriniz: ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    faktoriyel = 1;
                }

               
                
            }

            
        }
       


    }

}
