using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EikeConsultingTest
{

    public class ArrayManipulation
    {
        public List<int> RemoveDuplicatesWithHashSet(List<int> input)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int num in input)
            {
                if (seen.Add(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }
    }
}
