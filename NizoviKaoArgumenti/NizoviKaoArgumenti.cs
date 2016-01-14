using System;

namespace Vsite.CSharp
{
    // niz kao argument metode
    class Program
    {
        // U metodi SamVrag() napisati naredbu kojom se jedan od �lanova niza mijenja u neki drugi tekst. Pokrenuti program i usporediti sadr�aj nakon poziva metode. Ispis prekopirati u datoteku "NizoviKaoArgumenti.txt" pridru�enu projektu.
        static void SamVrag(string[] bo�jeZapovjedi)
        {
            bo�jeZapovjedi[1] = "Ne pla�aj porez!";
        }

        static void Main(string[] args)
        {
            string[] parBo�jih = new string[] { "Ne ubij!", "Ne sagrije�i bludno!", "Ne kradi!", };

            foreach (string s in parBo�jih)
                Console.WriteLine(s);

            Console.WriteLine("Nakon poziva metode");

            SamVrag(parBo�jih);

            foreach (string s in parBo�jih)
                Console.WriteLine(s);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
