using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Basamak_Sayisi_Bul_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sayi;

            Console.Write("Sayıyı Giriniz:");

            Sayi = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Basamak Sayısı={0}", Sayi.Length);

            Console.ReadKey();
        }
    }
}
