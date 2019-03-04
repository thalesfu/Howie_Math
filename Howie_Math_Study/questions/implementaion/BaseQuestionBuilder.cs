using System;
using System.Collections.Generic;
using System.Linq;
using Ctrip.Duckbill.Collections.Extensions;
using Howie_Math_Study.utility;

namespace Howie_Math_Study.questions.implementaion
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
            var questionsGroup = new List<List<string>>();

            while (questionsGroup.Select(group => group.Count).Sum() < count)
            {
                var question = this.Build();

                if (questionsGroup.IsNullOrEmpty())
                {
                    var newGroup = new List<string>();
                    newGroup.Add(question);
                    questionsGroup.Add(newGroup);
                }
                else
                {
                    var groupCount = questionsGroup.Count;

                    for (int i = 0; i < groupCount; i++)
                    {
                        if (!questionsGroup[i].Contains(question))
                        {
                            questionsGroup[i].Add(question);

                            if (i < questionsGroup.Count - 1)
                            {
                                questionsGroup = questionsGroup.Take(i + 1).ToList();
                            }

                            break;
                        }
                        else
                        {
                            if (i == questionsGroup.Count - 1)
                            {
                                var newGroup = new List<string>();
                                newGroup.Add(question);
                                questionsGroup.Add(newGroup);
                            }
                        }
                    }
                }
            }


            return questionsGroup.SelectMany(group => group).ToArray();
        }

        public virtual string Build()
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