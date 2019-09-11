using System;

namespace QUIZ09092019
{
    class BagunDatar
    {
        public void Luas_Persegi()
        {
            int sisi, luas;
            Console.WriteLine("Menghitung Luas Persgi ");

            Console.Write("Masukan nilai sisi = ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi;

            Console.WriteLine("Luas Persegi adalah "+luas);
            Console.WriteLine("-------------------------");
        }

        public void Luas_Segitiga()
        {
            int alas, tinggi, luas;
            Console.WriteLine("Menghitung Luas Segitiga ");

            Console.Write("Masukan Nilai Alas = ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Nilai Tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = alas * tinggi * 1/2;

            Console.WriteLine("Luas Segitiga adalah = "+luas);
            Console.WriteLine("-------------------------");            
        }

        public void Luas_Lingkaran()
        {
            double luas;
            const double pi = 3.14;
            
            int r;
            Console.WriteLine("Menghitung Luas Lingkaran ");

            Console.Write("Masukan Nilai r = ");
            r = Convert.ToInt32(Console.ReadLine());

            luas = (pi * r * r);
            Console.WriteLine("Luas Lingkaran Adalah = "+luas);
        }
        
    }
}
