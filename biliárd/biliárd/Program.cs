using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biliárd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyók = new List<int>();
            Kezdés(golyók);
            for (int i = 0; i < golyók.Count; i++)
            {
                Console.WriteLine(golyók[i]);
            }
            int leeső = Leesősorsoló(golyók);
            Kiíró(golyók);
            Console.ReadKey();
        }

        private static void Kiíró(List<int> golyók)
        {
            foreach (int item in golyók)
            {
                Console.Write($"{item} ");
            }
        }

        private static int Leesősorsoló(List<int> golyók)
        {
            Random sorsoló = new Random();
            int szám = sorsoló.Next(golyók.Count);
            golyók.Remove(szám);
            return golyók[szám];
        }

        private static void Kezdés(List<int> golyók)
        {
            for (int i = 1; i <= 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}
