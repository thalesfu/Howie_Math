using System;
using System.Linq;
using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public class EightPlusOneDigitQuestionBuilder : IEightPlusOneDigitQuestionBuilder
    {
        private readonly IRandom rd;

        private int[] GroupA = {8};
        private int[] GroupB = {2, 3, 4, 5, 6, 7, 8, 9};

        public EightPlusOneDigitQuestionBuilder(IRandom rd)
        {
            this.rd = rd;
        }

        public string Build()
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

        public string[] Build(int count)
        {
            return (new string[count]).Select(i => this.Build()).ToArray();
        }
    }
}