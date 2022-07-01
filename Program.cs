using System;
using System.IO;
using System.Collections.Generic;



namespace Nyelvvizsga
{
    class Program
    {
        static void Main(string[] args)
        {
            string fajlNev = "nyelvvizsgaUTF8.txt";

            //1. feladat
            int sorokSzama = File.ReadAllLines(fajlNev).Length;
            Console.WriteLine($"1. FELADAT: A fájl sorainak száma: {sorokSzama}\n");


            //2.feladat
            List<Vizsgazo> nyelvvizsgazok = new List<Vizsgazo>();
            
            fajlBeolvasas(fajlNev, nyelvvizsgazok);

            Console.WriteLine($"BEOLVASOTT ADATOK:");
            for (int i = 0; i < nyelvvizsgazok.Count; i++)
            {
                Console.Write($"{nyelvvizsgazok[i].getVizsgazoNev(), -25}\t");
                Console.Write($"{nyelvvizsgazok[i].getVizsgazoAzonosito()}\t");
                Console.Write($"{nyelvvizsgazok[i].getVizsgaszint(), -10}\t");
                Console.WriteLine($"{nyelvvizsgazok[i].getVizsgaPont()}");
             }

            for (int i = 0; i < nyelvvizsgazok.Count; i++)
            {
                if (nyelvvizsgazok[i].szazalekosTeljesitmeny()>=60 && nyelvvizsgazok[i].szazalekosTeljesitmeny()<=70)
                {
                    Console.Write($"{nyelvvizsgazok[i].getVizsgazoNev(), -25}\t");
                    Console.WriteLine(nyelvvizsgazok[i].szazalekosTeljesitmeny().toString());
                }

            }
            Console.ReadKey();
        }



        public static void fajlBeolvasas(string fajl, List<Vizsgazo> lista)
        {
            try
            {
                using (StreamReader olvaso = new StreamReader(fajl))
                {
                    while (!olvaso.EndOfStream)
                    {
                        string[] t = olvaso.ReadLine().Split(";");

                        Vizsgazo v = new Vizsgazo(t[0], Convert.ToInt32(t[1]), t[2], Convert.ToInt32(t[3]));

                        lista.Add(v);
                    }
                }

            } catch(IOException e)
            {
                Console.WriteLine($"IO hiba: {e}");
            }

        }


    }
}


