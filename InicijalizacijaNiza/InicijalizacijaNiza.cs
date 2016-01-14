using System;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    // inicijalizacija �lanova niza
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            int[] nizBrojeva;  // deklaracija reference na niz

            // nizBrojeva inicijalizirati kao niz duljine n (pojedine �lanove ostaviti neinicijaliziranima) te ispisati sve �lanove takvog neinicijaliziranog niza

            nizBrojeva = new int[n];
            foreach (var a in nizBrojeva)
                Console.WriteLine(n);

            Control[] nizKontrola;  // deklaracija reference na niz 

            // nizKontrola inicijalizirati kao niz duljine n (pojedine �lanove ostaviti neinicijaliziranima) te ispisati sve �lanove takvog neinicijaliziranog niza

            nizKontrola = new Control[n];


            // Pokrenuti program te ispis prekopirati u datoteku "InicijalizacijaNiza.txt" u ovom projektu. Obrazlo�iti ispise u gornja dva slu�aja.
       

            // inicijalizacija pojedinih �lanova
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
