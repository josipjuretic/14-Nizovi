using System;

namespace Vsite.CSharp
{
    // niz kao argument metode
    class Program
    {
        // U metodi SamVrag() napisati naredbu kojom se jedan od èlanova niza mijenja u neki drugi tekst. Pokrenuti program i usporediti sadržaj nakon poziva metode. Ispis prekopirati u datoteku "NizoviKaoArgumenti.txt" pridruženu projektu.
        static void SamVrag(string[] božjeZapovjedi)
        {
            božjeZapovjedi[1] = "Ne plaèaj porez!";
        }

        static void Main(string[] args)
        {
            string[] parBožjih = new string[] { "Ne ubij!", "Ne sagriješi bludno!", "Ne kradi!", };

            foreach (string s in parBožjih)
                Console.WriteLine(s);

            Console.WriteLine("Nakon poziva metode");

            SamVrag(parBožjih);

            foreach (string s in parBožjih)
                Console.WriteLine(s);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
