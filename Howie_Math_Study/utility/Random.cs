using System;

namespace Howie_Math_Study.utility
{
    internal class Random : IRandom
    {
        private readonly System.Random rd;

        public Random()
        {
            var tick = DateTime.Now.Ticks;
            this.rd = new System.Random((int) (tick & 0xffffffffL) | (int) (tick >> 32));
        }

        public int Next(int minValue, int maxValue)
        {
            return this.rd.Next(minValue, maxValue);
        }
    }
}