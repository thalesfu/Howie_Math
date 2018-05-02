using System;
using System.Linq;
using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions
{
    public abstract class BaseQuestionBuilder : IQuestionsBuilder
    {
        protected readonly IRandom rd;

        protected BaseQuestionBuilder(IRandom rd)
        {
            this.rd = rd;
        }

        public string[] Build(int count)
        {
            return (new string[count]).Select(i => this.Build()).ToArray();
        }

        public string Build()
        {
            int a;
            int b;

            do
            {
                a = this.GenerateA();
                b = this.GenerateB();
            } while (!this.IsValid(a, b));

            return this.Format(a, b);
        }

        protected abstract string Format(int a, int b);

        protected virtual bool IsValid(int a, int b)
        {
            return true;
        }

        protected abstract int GenerateB();

        protected abstract int GenerateA();
    }
}