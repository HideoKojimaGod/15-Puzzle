using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_puzzle
{
    class Puzzle
    {
        public readonly List<List<long>> Frame;
        public readonly long SizeOfFrame;
        private Dictionary<long, Position> positions;
        public Puzzle(params long[] numberedSquare)
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
                    positions = new Dictionary<long,Position>();
                    SizeOfFrame = Convert.ToInt64(Math.Sqrt(numberedSquare.Count()));
                    Frame = new List<List<long>>();
                    for (int i = 0; i < SizeOfFrame; i++)
                    {
                        Frame.Add(new List<long>());
                        for (int j = 0; j < SizeOfFrame; j++)
                        {
                            int value = Convert.ToInt32(numberedSquare[i * SizeOfFrame + j]);
                            Frame[i].Add(value);
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
        public long this[int x, int y]
        {
            get
            {
                return Frame[x][y];
            }
        }
        public Position GetLocation(int value)
        {       
           return positions[value];   
        }
    }
}
