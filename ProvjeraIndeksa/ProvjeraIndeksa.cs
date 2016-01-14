using System;

namespace Vsite.CSharp
{
    // primjer poziva 
    class Program
    {
        private const int m_brojElemenata = 10;

        static void Main(string[] args)
        {
            int[,] dvaDpolje = new int[m_brojElemenata, m_brojElemenata];
            try 
            {
                Console.WriteLine("Pozivam Sigurno:");
                Console.WriteLine(ZbrojiSigurno(dvaDpolje));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine();

            try
            {
                Console.WriteLine("Pozivam Nesigurno:");
                // TODO: Odkomentirajte donju naredbu i metodu koja se poziva. U postavkama projekta potra�ite i aktivirajte opciju "Allow unsafe code" da se omogu�i prevo�enje koda.
                Console.WriteLine(ZbrojiNesigurno(dvaDpolje));
                // TODO: Pokrenite program i ispis prekopirajte u datoteku "ProvjeraIndeksa.txt" pridru�enu projektu. Obrazlo�ite rezultat ispisa metode ZbrojiNesigurno.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        static int ZbrojiSigurno(int[,] polje)
        {
            int zbroj = 0;
            for (int redak = 0; redak < m_brojElemenata + 1; ++redak)
            {
                for (int stupac = 0; stupac < m_brojElemenata; ++stupac)
                {
                    zbroj += polje[redak, stupac];
                }
            }
            return zbroj;
        }

        
        unsafe static int ZbrojiNesigurno(int[,] polje)
        {
            int zbroj = 0;
            // 'fixed' omogu�ava da se dohvati adresa �lanova 'polje' te ih
            // se fiksira tako da ih GC ne mo�e realocirati
            fixed (int* element = polje) 
            {
                for (int redak = 0; redak < m_brojElemenata + 1; ++redak)
                {
                    int po�etakRetka = redak * m_brojElemenata;
                    for (int stupac = 0; stupac < m_brojElemenata; ++stupac)
                    {
                        zbroj += element[po�etakRetka + stupac];
                    }
                }
            }
            return zbroj;
        }
        
        
    }
}
