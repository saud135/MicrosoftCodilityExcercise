using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftCodilityExcercise
{
   public static class UniqueCharSubstring
    {
       public static int distinctSubString(string S)
        {
            int count = string.IsNullOrEmpty(S) ? 0 : 1;
            S = S.ToLower();
            HashSet<char> letters = new();
            for (int i = 0; i < S.Length; i++)
            {
                if (letters.Contains(S[i]))
                {
                    letters.Clear();
                    count++;
                }
                letters.Add(S[i]);
            }
            return count;
        }

    }
}
