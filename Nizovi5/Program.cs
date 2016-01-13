using System;

namespace Nizovi5
{
    class BozjeZapovjedi
    {
        public BozjeZapovjedi()
        {
            m_bozje = new string[] { "Ne kradi!", "Ne ubij!" };
        }

        public string[] DajBozje
        {
            get { return m_bozje; }
        }

        public string[] DajBozje2
        {
            get { return (string[])m_bozje.Clone(); }
        }

        string[] m_bozje;
    }

    class Program
    {
        static void Main(string[] args)
        {
            BozjeZapovjedi bz = new BozjeZapovjedi();
            string[] bZap = bz.DajBozje;
            foreach (string s in bZap)
                Console.WriteLine(s);

            Console.ReadLine();

            bZap[1] = "Ne ulij!";

            foreach (string s in bZap)
                Console.WriteLine(s);

            Console.ReadLine();

            bz = new BozjeZapovjedi();
            bZap = bz.DajBozje2;
            foreach (string s in bZap)
                Console.WriteLine(s);

            Console.ReadLine();

            bZap[1] = "Ne ulij!";

            foreach (string s in bZap)
                Console.WriteLine(s);

            Console.ReadLine();

            foreach (string s in bz.DajBozje)
                Console.WriteLine(s);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
