using System;

namespace MicrosoftCodilityExcercise
{
    public class Program
    {
       public static void Main(string[] args)
        {
            int[] A = new int[] { 1, 3, 6, 4, 1, 2 };

            //var ExpResult = ExampleTask.solution(A);

            var task1 = Task1.solution("nlaebolko");
            //task1 = Task1.solution("saudloon");
            //task1 = Task1.solution("loonbalxballpoon");
            //task1 = Task1.solution("BAONXXOLL"); 

            //var task = Task3.solution(10,21);
            //task = Task3.solution(13,11);
            //task = Task3.solution(2,1 );
            //task = Task3.solution(1,8);


            //var task = Task2.solution("baaaaa");
            //task = Task2.solution("baaabbaabbba");
            //task = Task2.solution("baabab");

            var task = UniqueCharSubstring.distinctSubString("world");
             task = UniqueCharSubstring.distinctSubString("dddd");
             task = UniqueCharSubstring.distinctSubString("cycle");
             task = UniqueCharSubstring.distinctSubString("abba");
            Console.WriteLine("Hello World!");
        }
    }
}
