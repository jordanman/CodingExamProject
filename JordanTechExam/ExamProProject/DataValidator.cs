using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProProject
{
    public static class DataValidator
    {
        public static bool IsMatchAngleBrackets(string str)
        {
            if (str.Length <= 0)
                return true;

            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                char current = str.ElementAt(i);
                if (current == '<')
                {
                    stack.Push(current);
                }

                if (current == '>')
                {
                    if (stack.Count() <= 0)
                        return false;

                    char last = stack.Peek();
                    if (current == '>' && last == '<')
                        stack.Pop();
                    else
                        return false;
                }
            }

            return stack.Count() <= 0;
        }
    }
}
