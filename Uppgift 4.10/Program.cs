using System;

namespace Uppgift_4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många \"X\" vill du ha per grupp?");
            int xNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många \"O\" per grupp?");
            int oNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många \"O\" mönster per rad?");
            int oMönsterNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många rader?");
            int rader = int.Parse(Console.ReadLine());

            for (int i = 0; i < rader; i++)
            {
                for (int j = 0; j < oMönsterNr + 1; j++)
                {
                    for (int n = 0; n < xNr; n++)
                    {
                        Console.Write("X");
                    }

                    if (j < oMönsterNr)
                    {
                        Console.Write("-");
                        for (int l = 0; l < oNr; l++)
                        {
                            Console.Write("O");
                        }
                        Console.Write("-");
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
