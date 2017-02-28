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
            //int[] numberedSquare = Array.;
            // ;
            var pi = new Puzzle(1, 2, 3, 4, 5, 6, 7, 8,9,10,11,12,13,14,15, 0);
            pi.Shift(6);
            Printer.PrintPuzzle(pi);
            Console.WriteLine(pi[1, 1]);
//            if (Math.Sqrt(numberedSquare.Count()) != Math.Truncate(Math.Sqrt(numberedSquare.Count()))
//                    || Math.Sqrt(numberedSquare.Count()) == 1)
//            {
//                throw new ArgumentException("Неверное число параметров");
//            }
//            else
//            {
//                }
//            }
//        }
//            catch (ArgumentException e)
//            {
//                Console.WriteLine(e.Message);
//                System.Environment.Exit(1);
//            }
        }
     }
}
