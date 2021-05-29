using Easy.AddDigits;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = NumberAnalyzer.RecursivelyAddDigitsUntilOneDigitNumber(68);
            Console.WriteLine(result);
        }
    }
}
