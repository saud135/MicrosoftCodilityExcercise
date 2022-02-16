using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftCodilityExcercise
{
    public class FixPotholes
    {
        // should split the string and and them in a way to calculate maximum number less than budget

        public static int solution(string S, int B)
        {
            int holes = 0;
            //int count = 0;
            //for (int i = 0; i < S.Length; i++)
            //{
            //    if (S[i] == '.')
            //        count = 0;
            //    else if (S[i] == 'x' && holes +count+ 1 <= B)
            //    {
            //        count++;

            //        if(i == S.Length - 1 || S[i + 1] == '.')
            //            holes += count + 1;
            //    }
           
                   
            //}

        
            var xArr = S.Split('.');
         
            List<int> potholes = new();

            foreach (var x in xArr)
            {
                if (x.Contains('x'))
                    potholes.Add(x.Count());
            }

            potholes.Sort();
            potholes.Reverse();
            int cost = 0;
            foreach (var p in potholes)
            {
                for (int i = p; i >= 0; i--)
                {
                    if (cost + i + 1 <= B)
                    {
                        holes += i;
                        cost += i + 1; 
                        i = 0;
                    }
                }


            }

            return holes;
        }
    }
}
