using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaşağıtMakas
{
    internal class Program
    {
        private static string soru;

        static void Main(string[] args)
        {
            bool yeniden = true;
            başlangıç:
            while (yeniden)
            {
                string sonuc;
                Console.ForegroundColor = ConsoleColor.White;
                string[] tkm = { "Taş", "Makas", "Kağıt" };
                Console.WriteLine("");

                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine((i + 1) +  " - "+ tkm[i]);
                }
                Console.WriteLine("Seç Bakalım :) ");
                int secim = Int32.Parse(Console.ReadLine());
                if (secim >= 4)
                {
                    goto başlangıç;
                }

                
                else
                {   Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seçiminiz : " + tkm[secim - 1]);
                }
                Random rast = new Random();
                int bilg = rast.Next(0,2);

                Console.WriteLine("Bilgisayarın Seçimi : " + tkm[bilg]);
                sonuc = "";


                if (tkm[bilg] == "Taş" && tkm[ secim - 1]== "Kağıt")
                {
                    sonuc = "Kazandıniz";
                }

                else if (tkm[bilg] == "Taş" && tkm [secim - 1]== "Makas")
                {
                    sonuc = "Kaybettiniz";
                }
                else if (tkm[bilg] == "Kağıt" && tkm[secim - 1] == "Taş")
                {
                    sonuc = "Kaybettiniz";
                }
                else if (tkm[bilg] == "Kağıt" && tkm[secim - 1] == "Makas")
                {
                    sonuc = "Kazandınız";
                }

                else if (tkm[bilg] == "Makas" && tkm[secim - 1] == "Taş")
                {
                    sonuc = "Kazandınız";

                }
                else if (tkm[bilg] == "Makas" && tkm[secim - 1] == "Kağıt")
                {
                    sonuc = "Kaybettiniz";
                }

                else if (tkm[bilg] == tkm[secim - 1])
                {
                    sonuc = "Berabere.";
                }



                if (sonuc == "Kazandınız")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (sonuc == "Kaybettiniz")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (sonuc == "Berabere.") 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                }

                Console.WriteLine(sonuc);
                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine("Yeniden E/H ");
                string sorgu = Console.ReadLine().ToUpper();

                if (soru == "H")
                {
                    yeniden = false;
                }
            }
        }
    }
}
