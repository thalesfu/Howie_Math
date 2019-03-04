using System.Collections.Generic;

namespace Howie_Math_Study.questions
{
    public interface IQuestionsBuilder
    {
        string Build();

        string[] Build(int count);
    }
}