using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryAction
{
    public class BeetsWork
    {
        public static int BitsMove(int first, int second, int start, int finish)
        {
            if (start < 0 || finish < 0 || start > 31 || finish > 31)
                throw new ArgumentException("Start and finish position must be from 0 to 31");

            if (start > finish)
                throw new ArgumentException("Start position must be less than finish");

            int moveLength = finish - start;
            if (Countbits(second) > moveLength)
                second >>= Countbits(second) - moveLength;
            second <<= start;
            return first | second;
        }

        private static int Countbits(int a)
        {
            return Convert.ToString(a, 2).Length;
        }
    }
}
