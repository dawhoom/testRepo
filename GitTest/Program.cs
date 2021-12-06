using System;

namespace GitTest
{
    class Program
    {
        public struct Pazymiai
        {
            public int PirmasTrimestras;
            public int AntrasTrimestras;
            public int TreciasTrimestras;

            public Pazymiai(int pirmasTrimestras, int antrasTrimestras, int treciasTrimestras)
            {
                PirmasTrimestras = pirmasTrimestras;
                AntrasTrimestras = antrasTrimestras;
                TreciasTrimestras = treciasTrimestras;
            }


            public void pazymiuVidurkis()
            {
                int pazymiuVidurkis = (PirmasTrimestras + AntrasTrimestras + TreciasTrimestras) / 3;
                Console.WriteLine($"Vidurkis: {pazymiuVidurkis}");
            }
        }

        static void Main(string[] args)
        {
            Pazymiai pazymys = new Pazymiai(5, 10, 7);
            pazymys.pazymiuVidurkis();
        }
    }
}
