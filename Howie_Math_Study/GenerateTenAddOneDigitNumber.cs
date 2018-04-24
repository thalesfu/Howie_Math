using System;
using System.Linq;

namespace Howie_Math_Study
{
    public class GenerateTenAddOneDigitNumber
    {
        private readonly Random rd;

        public GenerateTenAddOneDigitNumber()
        {
            var iSeed = 10;
            var ro = new Random(10);
            var tick = DateTime.Now.Ticks;
            this.rd = new Random((int) (tick & 0xffffffffL) | (int) (tick >> 32));
        }


        private int[] GroupA = {10};
        private int[] GroupB = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        public string[] GenerateGroups(int count)
        {
            return (new string[count]).Select(i => this.GenerateOne()).ToArray();
        }

        public string GenerateOne()
        {
            int realA;
            int realB;

            var a = GroupA[this.rd.Next(0, GroupA.Length)];
            var b = GroupB[this.rd.Next(0, GroupB.Length)];

            var reverse = this.rd.Next(0, 2) > 0;

            if (reverse)
            {
                realA = b;
                realB = a;
            }
            else
            {
                realA = a;
                realB = b;
            }


            return string.Format("{0} + {1} = ", realA, realB);
        }
    }
}