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

        public abstract string Build();

        public string[] Build(int count)
        {
            return (new string[count]).Select(i => this.Build()).ToArray();
        }
    }
}