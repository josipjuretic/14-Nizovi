using System;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    // inicijalizacija èlanova niza
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            int[] nizBrojeva;  // deklaracija reference na niz

            // TODO: nizBrojeva inicijalizirati kao niz duljine n (pojedine èlanove ostaviti neinicijaliziranima) te ispisati sve èlanove takvog neinicijaliziranog niza




            Control[] nizKontrola;  // deklaracija reference na niz 

            // TODO: nizKontrola inicijalizirati kao niz duljine n (pojedine èlanove ostaviti neinicijaliziranima) te ispisati sve èlanove takvog neinicijaliziranog niza




            // TODO: Pokrenuti program te ispis prekopirati u datoteku "InicijalizacijaNiza.txt" u ovom projektu. Obrazložiti ispise u gornja dva sluèaja.

            // inicijalizacija pojedinih èlanova
            nizKontrola[0] = new Button();
            nizKontrola[1] = new Form();
            nizKontrola[2] = nizKontrola[0];
            nizKontrola[3] = new TextBox();

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine(string.Format("{0}. kontrola: {1}", i, nizKontrola[i]));
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
