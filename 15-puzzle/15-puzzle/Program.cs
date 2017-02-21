using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Puzzle(1, 3, 4, 5, 6, 7, 8, 0);
            Console.WriteLine(p[1, 1]);
        }
    }
}
