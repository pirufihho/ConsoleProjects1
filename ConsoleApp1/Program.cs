using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(1041);

            solution("Codility");

            solution2(54321);

            // Step 1: Array Declaration 
            string[] stringarr;

            // Step 2:Array Initialization 
            stringarr = new string[6] { "cliente1","cliente2","cliente3","cliente1","cliente2","cliente2"};

            var mf = 1;
            var m = 0;
            var item = "";

            for (var i = 0; i < stringarr.Length; i++)
            {
                for (var j = i; j < stringarr.Length; j++)
                {
                    if (stringarr[i] == stringarr[j])
                        m++;
                    if (mf < m)
                    {
                        mf = m;
                        item = stringarr[i];
                    }
                }
                m = 0;
            }
            Console.WriteLine(item + " ( " + mf + " times ) ");

            Console.ReadKey();

        }

        public static int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string bits = Convert.ToString(N, 2);
            //Console.WriteLine($"Bit String: {bits}");
            int longest = 0;
            int curCount = 0;
            int curOnes = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '1')
                {
                    curOnes++;
                }

                if (bits[i] == '0')
                {
                    curCount++;
                }
                else curCount = 0;
                if (curCount > longest) longest = curCount;
            }

            if (curOnes < 2)
            {
                return 0;
            }

            return longest;
        }

        public static string solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            List<char> repeatedCharacters = new List<char>();
            var groupsOfChars = S.ToUpper().GroupBy(oChar => oChar);
            groupsOfChars.ToList().ForEach(item =>
            {
                if (item.Count() > 1) repeatedCharacters.Add(item.Key);
            }
            );

            if (repeatedCharacters.Count < 2)
            {
                return "NO";
            }

            // initializing max  
            // alphabet to 'a' 
            char max = 'A';

            // find largest alphabet 
            for (int i = 0; i < repeatedCharacters.Count; i++)
                if (repeatedCharacters[i] > max)
                    max = repeatedCharacters[i];

            // returning largest element 
            return max.ToString();

        }

        public static void solution2(int N)
        {
            int enable_print = N % 10;
            while (N > 0)
            {
                if (enable_print == 0 && N % 10 != 0)
                {
                    enable_print = 1;
                //}
                //else if (enable_print == 1)
                //{
                    Console.Write(N % 10);
                }
                N = N / 10;
            }
        }
    }
}
