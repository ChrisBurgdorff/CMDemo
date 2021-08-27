using System;
using FizzBuzzBuilder;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzBuilder.FizzBuzz fb = new FizzBuzzBuilder.FizzBuzz();

            fb.UpperBound = 100;
            fb.LowerBound = 1;

            fb.FizzBuzzRules = new List<FizzBuzzRule>();

            fb.FizzBuzzRules.Add(new FizzBuzzRule(3, "Fizz"));
            fb.FizzBuzzRules.Add(new FizzBuzzRule(5, "Buzz"));


            string[] fbResults = fb.PrintFizzBuzz();
            
            for (int j = 0; j < fbResults.Length; j++)
            {
                Console.WriteLine(fbResults[j]);
            }

            Console.WriteLine(fbResults.Length.ToString());
        }
    }
}
