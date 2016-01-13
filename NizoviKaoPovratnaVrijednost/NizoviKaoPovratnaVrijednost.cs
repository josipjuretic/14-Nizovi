using System;

namespace Vsite.CSharp
{
    // kako onemoguciti promjene izvan klase koristenjem Clone metode
    class PrimBrojevi
    {
        // TODO: Svojstvu "Brojevi" napisati get metodu koja vraæa referencu na polje primovi
        public int[] Brojevi
        {
            get { throw new NotImplementedException(); }
        }

        // TODO: Svojstvu "KloniraniBrojevi" napisati get metodu koja vraæa referencu na presliku (dobivenu metodom Clone) polja primovi
        public int[] KloniraniBrojevi
        {
            get { throw new NotImplementedException(); }
        }

        int[] primovi = new int[] { 2, 3, 5, 7 };
    }

    class Program
    {
        // TODO: Pokrenuti program te ispis prekopirati u "NizoviKaoPovratnaVrijednost.txt"
        static void Main(string[] args)
        {
            PrimBrojevi pb = new PrimBrojevi();
            foreach (var a in pb.Brojevi)
                Console.WriteLine(a);

            Console.WriteLine("Mijenjam [1] u 128");
            pb.Brojevi[1] = 128;

            foreach (var a in pb.Brojevi)
                Console.WriteLine(a);

            Console.WriteLine("Drugi pokušaj");

            PrimBrojevi pbk = new PrimBrojevi();

            foreach (var a in pbk.KloniraniBrojevi)
                Console.WriteLine(a);

            Console.WriteLine("Mijenjam [1] u 128");
            pbk.KloniraniBrojevi[1] = 128;

            foreach (var a in pbk.KloniraniBrojevi)
                Console.WriteLine(a);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
