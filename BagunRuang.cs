using System;

namespace QUIZ09092019
{
    class BagunRuang
    {
        public void volume_balok()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Menghitung Volume Balok");

            int panjang,lebar,tinggi,volume;

            Console.Write("Masukkan Nilai Panjang = ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai Lebar = ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai Tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi;
            Console.WriteLine("Nilai Volume Adalah = "+volume);
            Console.WriteLine("----------------------");
        }

        public void volume_kubus()
        {
            Console.WriteLine("Menghitung Volume Kubus");
            
            int rusuk,volume2;

            Console.Write("Masukkan Nilai Rusuk = ");
            rusuk = Convert.ToInt32(Console.ReadLine());

            volume2 = rusuk * rusuk * rusuk;
            Console.WriteLine("Nilai Rusuk adalah = "+volume2);
            Console.WriteLine("---------------------");
        }
    }
}