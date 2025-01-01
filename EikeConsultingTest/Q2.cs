using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EikeConsultingTest
{
    public class ParenthesesValidator
    {
        public bool IsValid(string input)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> brackets = new Dictionary<char, char>
            {
                {'}', '{'},
                {']', '['},
                {')', '('}
            };

            foreach (char c in input)
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    stack.Push(c);
                }
                else if (brackets.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != brackets[c])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
