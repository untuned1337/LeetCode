using System.Collections.Generic;

namespace Easy.AddDigits
{
    public static class NumberAnalyzer
    {
        public static int RecursivelyAddDigitsUntilOneDigitNumber(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            var digits = GetDigits(number);
            if (digits.Count > 1)
            {
                var sumOfDigits = AddDigits(digits);
                return RecursivelyAddDigitsUntilOneDigitNumber(sumOfDigits);
            }

            return digits[0];
        }

        public static List<int> GetDigits(int number)
        {
            var digits = new List<int>();
            while (number > 0)
            {
                var nextDigit = number % 10;
                number /= 10;
                digits.Add(nextDigit);
            }

            return digits;
        }

        public static int AddDigits(List<int> numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
