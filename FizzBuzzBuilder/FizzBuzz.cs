using System;
using System.Collections.Generic;

namespace FizzBuzzBuilder
{
    public struct FizzBuzzRule
    {
        public FizzBuzzRule(int multiple, string outputWord)
        {
            Multiple = multiple;
            OutputWord = outputWord;
        }

        public int Multiple { get; }
        public string OutputWord { get; }

    }

    public class FizzBuzz
    {
        public int UpperBound { get; set; } = 100;

        public int LowerBound { get; set; } = 1;

        public List<FizzBuzzRule> FizzBuzzRules { get; set; } = new List<FizzBuzzRule> { new FizzBuzzRule(3, "Fizz"), new FizzBuzzRule(5, "Buzz") };

        public FizzBuzz()
        {

        }

        public string[] PrintFizzBuzz()
        {
            List<String> allOutput = new List<String>();

            for (int i = LowerBound; i <= UpperBound; i++)
            {
                string currentLine = "";
                for (int j = 0; j < FizzBuzzRules.Count; j++)
                {
                    try
                    {
                        if (i % FizzBuzzRules[j].Multiple == 0)
                        {
                            currentLine += FizzBuzzRules[j].OutputWord;
                        }
                    }
                    catch (DivideByZeroException ex)
                    {
                        return new string[1] { ex.Message };
                    }

                }
                if (String.IsNullOrEmpty(currentLine))
                {
                    currentLine = i.ToString();
                }
                allOutput.Add(currentLine);
            }
            return allOutput.ToArray();
        }

        public string ValueAt(int index)
        {
            string value = "";
            for (int i = 0; i < FizzBuzzRules.Count; i++)
            {
                if (index % FizzBuzzRules[i].Multiple == 0)
                {
                    value += FizzBuzzRules[i].OutputWord;
                }
            }
            if (String.IsNullOrEmpty(value))
            {
                value = index.ToString();
            }
            return value;
        }
    }
}
