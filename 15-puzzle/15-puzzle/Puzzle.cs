using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_puzzle
{
    class Puzzle
    {
        public readonly List<List<long>> frame;
        long sizeOfFrame;
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
                    sizeOfFrame = Convert.ToInt64(Math.Sqrt(numberedSquare.Count()));
                    frame = new List<List<long>>();
                    for (int i = 0; i < sizeOfFrame; i++)
                    {
                        frame.Add(new List<long>());
                        for (int j = 0; j < sizeOfFrame; j++)
                        {
                            frame[i].Add(numberedSquare[i * sizeOfFrame + j]);
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
                return frame[x][y];
            }
        }
    }
}
