using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_1184035
{
    public class P2_2_1184035
    {
        static void Main(string[] args)
        {

            double a, b;
            int pilih;

            Console.WriteLine("1. perkalian");
            Console.WriteLine("2. Pembagian");
            Console.Write("Pilih Proses yang akan dilakukan : ");
            pilih = int.Parse(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    Console.Write("Masukkan Bilangan Pertama : ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Bilangan Kedua : ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil Perkalian " + (a * b));
                    break;
                case 2:
                    Console.Write("Masukkan Bilangan Pertama : ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Bilangan Kedua : ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hasil Pembagian " + (a / b));
                    break;
            }

            Console.ReadLine();
        }
    }
}
