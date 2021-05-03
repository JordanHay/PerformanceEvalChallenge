using System;
using System.Diagnostics;
using System.Text;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            stopwatch.Start();

            string stringOne = "Im sorry Dave.";
            string stringTwo = "Im afraid I cant do that.";

            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine($"{stringOne} {stringTwo}");
            }


            stopwatch.Stop();
            Console.WriteLine($"Time taken : { stopwatch.ElapsedMilliseconds } ms");


            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 500; i++)
            {
                stringBuilder.Append("I'm sorry Dave");
            }

            string sbOutput = stringBuilder.ToString();

            stopwatch.Stop();
            Console.WriteLine($"Time taken : { stopwatch.ElapsedMilliseconds } ms");


            Console.ReadLine();

        }

        

   
    }


}
