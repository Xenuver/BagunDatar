using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BagunDatar kelas = new BagunDatar();

            kelas.Luas_Persegi();
           
            kelas.Luas_Segitiga();

            kelas.Luas_Lingkaran();

            BagunRuang lele = new BagunRuang();

            lele.volume_balok();

            lele.volume_kubus();

        }
    }
}
