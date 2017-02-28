using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_puzzle
{
    static class Printer
    {
        static public void PrintPuzzle(Puzzle puzzle)
        {
            for (int i = 0; i < puzzle.SizeOfFrame; i++)
            {
                for (int j = 0; j < puzzle.SizeOfFrame; j++)
                {
                    Console.Write(puzzle[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
