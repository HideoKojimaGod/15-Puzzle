using System;
using System.IO;
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
            int[] numberedSquare = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
            Puzzle game;
            try 
            {
                Line.Check(numberedSquare);
                game = new Puzzle(numberedSquare);
                try
                {
                    game.Shift(12);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                Printer.PrintPuzzle(game);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Printer.PrintPuzzle(Puzzle.FromCSV("input.csv"));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            





        }
     }
}
