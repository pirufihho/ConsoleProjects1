using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            solution(1041);

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
    }
}
