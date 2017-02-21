using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_puzzle
{
    class Position
    {
        public readonly long X;
        public readonly long Y;
        public Position(long x, long y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
