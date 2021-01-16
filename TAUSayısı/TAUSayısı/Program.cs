using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAUSayısı
{
    class Program
    {
        //Main 
        static void Main(string[] args)
        {
            int sayi;
            while (true)
            {
                Console.Write("Hangi sayıya kadar olan TAU Sayıları listelensin = ");
                sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                if (sayi < 0) {
                    Console.WriteLine("Lütfen 0 dan küçük sayı girmeyiniz");
                }
                else
                {
                    break;
                }
            }
            TAUSayisi tau = new TAUSayisi();
            tau.TAUSayi(sayi);
        }


    }
}
