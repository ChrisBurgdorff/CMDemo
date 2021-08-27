using System;
using Xunit;
using FizzBuzzBuilder;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        //Test that all output words print at multiples of both
        [Theory]
        [InlineData(3, 5, 15)]
        [InlineData(4, 5, 80)]
        [InlineData(3, 5, 15000000)]
        [InlineData(37, 14, 518)]
        public void FizzBuzzBasic(int firstMultiple, int secondMultiple, int product)
        {
            FizzBuzzBuilder.FizzBuzz fb = new FizzBuzzBuilder.FizzBuzz();
            fb.FizzBuzzRules = new List<FizzBuzzRule>();
            fb.FizzBuzzRules.Add(new FizzBuzzRule(firstMultiple, "Fizz"));
            fb.FizzBuzzRules.Add(new FizzBuzzRule(secondMultiple, "Buzz"));

            string expected = "FizzBuzz";

            string actual = fb.ValueAt(product);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,100,100)]
        [InlineData(1000, 100, 0)]
        [InlineData(10000000, 20000000, 10000001)]
        public void FizzBuzzOutputCount(int lowerBound, int upperBound, int count)
        {
            FizzBuzzBuilder.FizzBuzz fb = new FizzBuzzBuilder.FizzBuzz();

            fb.LowerBound = lowerBound;
            fb.UpperBound = upperBound;

            int expected = count;

            int actual = fb.PrintFizzBuzz().Length;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzBuzzDivideByZero()
        {
            //This works because in the case of a divide by zero error the class returns the exception's message
            //as its output. So this test ensures that no one changes the error handling

            FizzBuzzBuilder.FizzBuzz fb = new FizzBuzzBuilder.FizzBuzz();

            fb.LowerBound = 1;
            fb.UpperBound = 100;

            fb.FizzBuzzRules = new List<FizzBuzzRule>();

            fb.FizzBuzzRules.Add(new FizzBuzzRule(0, "Fizz"));

            int expected = 1;

            int actual = fb.PrintFizzBuzz().Length;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(int.MaxValue, "2147483647")]
        [InlineData(int.MaxValue - 1, "Even")]
        public void FizzBuzzMaxInt(int valueToCheck, string result)
        {
            FizzBuzzBuilder.FizzBuzz fb = new FizzBuzzBuilder.FizzBuzz();

            fb.LowerBound = 1;
            fb.UpperBound = int.MaxValue;

            fb.FizzBuzzRules = new List<FizzBuzzRule>();

            fb.FizzBuzzRules.Add(new FizzBuzzRule(2, "Even"));

            string expected = result;

            string actual = fb.ValueAt(valueToCheck);

            Assert.Equal(expected, actual);
        }
    }
}
