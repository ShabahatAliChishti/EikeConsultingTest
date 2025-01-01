using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EikeConsultingTest
{
    public class StringManipulation
    {
        public string ReverseString(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result[i] = input[input.Length - 1 - i];
            }

            return new string(result);
        }
    }
}
