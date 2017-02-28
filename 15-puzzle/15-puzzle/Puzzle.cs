using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_puzzle
{
    class Puzzle
    {
        private List<List<int>> frame;
        public readonly int SizeOfFrame;
        private Dictionary<int, Position> positions;
        public Puzzle(params int[] numberedSquare)
        {
            try
            {
                if (Math.Sqrt(numberedSquare.Count()) != Math.Truncate(Math.Sqrt(numberedSquare.Count())) 
                    || Math.Sqrt(numberedSquare.Count()) == 1)
                {
                    throw new ArgumentException("Неверное число параметров");
                }
                else
                {
                    positions = new Dictionary<int,Position>();
                    SizeOfFrame = Convert.ToInt32(Math.Sqrt(numberedSquare.Count()));
                    frame = new List<List<int>>();
                    for (int i = 0; i < SizeOfFrame; i++)
                    {
                        frame.Add(new List<int>());
                        for (int j = 0; j < SizeOfFrame; j++)
                        {
                            int value = Convert.ToInt32(numberedSquare[i * SizeOfFrame + j]);
                            frame[i].Add(value);
                            positions.Add(value, new Position(i, j));
                        }
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                System.Environment.Exit(1);
            }
            
        }
        public int this[int x, int y]
        {
            get
            {
                return frame[x][y];
            }
        }
        public Position GetLocation(int value)
        {       
           return positions[value];   
        }
        public void Shift(int value)
        {
            try
            {
                if (positions[value] - positions[0] == 1)
                {
                    Position positionZero = positions[0];
                    frame[positions[0].X][positions[0].Y] = value;
                    frame[positions[value].X][positions[value].Y] = 0;
                    positions[0] = positions[value];
                    positions[value] = positionZero;
                }
                else throw new ArgumentException("Невозможно передвинуть фишку");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
