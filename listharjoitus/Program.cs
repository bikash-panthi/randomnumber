using System;
using System.Collections.Generic;
using System.IO;

namespace listharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerlista = new List<int>();

            int intLuku = 0;
            string strLuku = "0";

            while (strLuku.Length >0)
            {
                Console.Write("Anna luku:");
                strLuku = Console.ReadLine();
                if (strLuku != "")
                    if (int.Parse(strLuku)>10000)
                    {
                        Console.WriteLine("Liian suuri luku:" +strLuku);
                    }
                    else
                    {
                        intLuku = int.Parse(strLuku);
                        integerlista.Add(intLuku);
                    }

            }
            integerlista.Sort();
            //integerlista.Reverse();

            for (int i = 0; i < integerlista.Count; i++)
            {
                if (integerlista[i] > 1000)             //if we need least that numeber
                {

                    Console.WriteLine("Listan alkoi(" + i + ")on:" + integerlista[i]);

                }
            }
            //Console.WriteLine("lukjen Summa on: " + intSumma.ToString());
            Console.WriteLine();
            Console.Write("Paina enter Lopettaaksesi");
            Console.ReadLine();
        }
    }
}
