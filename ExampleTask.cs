using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftCodilityExcercise
{
   public static class ExampleTask
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int N = A.Length;
            HashSet<int> set = new HashSet<int>();
            foreach (int a in A)
            {
                if (a > 0)
                {
                    set.Add(a);
                }
            }
            for (int i = 1; i <= N + 1; i++)
            {
                if (!set.Contains(i))
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
