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
            int leeső;           
            do
            {
                leeső = Leesősorsoló(golyók);
                Kiíró(golyók);
                Console.WriteLine(leeső);
            } while (golyók.Contains(8));                     
            Console.ReadKey();
        }

        private static void Kiíró(List<int> golyók)
        {
            foreach (int item in golyók)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static int Leesősorsoló(List<int> golyók)
        {
            Random sorsoló = new Random();          
            int szám = sorsoló.Next(golyók.Count);
            golyók.Remove(golyók[szám]);          
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
