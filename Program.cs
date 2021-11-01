using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jędrzejewska_PO_2
{
    class Tablica
    {
        public float[] mTab;

        public Tablica()
        {
            Console.WriteLine("Wpisz liczby, oddziel enterem: ");
            string napis = Console.ReadLine();
            float liczba = Convert.ToSingle(napis);

            mTab = new float[0];

            while (liczba != 0)
            {
                Array.Resize(ref mTab, mTab.Length+1 );
                mTab[mTab.Length-1] = liczba;
                 napis = Console.ReadLine();
                 liczba = Convert.ToSingle(napis);
            } 

            //string[] napisy = napis.Split(' ');
            //mTab = new float[napisy.Length];
           // Console.WriteLine("{0}", napisy.Length);
           // for (int nrNapisu = 0; nrNapisu < napisy.Length; ++nrNapisu)
            //{
           //     mTab[nrNapisu] = Single.Parse(napisy[nrNapisu]);
           // }
        }

        public void wyswietlLiczby()
        {
            for (int i = 0; i < mTab.Length; i++)
            {
                Console.WriteLine("{0} ", mTab[i]);
            }
            Console.WriteLine();
        }
    }
    class GlownaKlasa
    {
        static void Main(string[] args)
        {
            Tablica tablica = new Tablica();
            tablica.wyswietlLiczby();
            Console.WriteLine("Liczb: {0}", tablica.mTab.Length);
            Console.ReadLine();
        }

        
    }
        
}

