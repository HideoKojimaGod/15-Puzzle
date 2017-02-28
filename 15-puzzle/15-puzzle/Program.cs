﻿using System;
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
            try 
            {
                Line.Check(numberedSquare);
                var game = new Puzzle(numberedSquare);
                game.Shift(6);
                Printer.PrintPuzzle(game);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Printer.PrintPuzzle(Puzzle.FromCSV("input.csv"));
             
        }
     }
}
