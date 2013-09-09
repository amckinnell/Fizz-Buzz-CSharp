﻿namespace FizzBuzzKata
{
    internal class FizzBuzz
    {
        public string Classify(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
                return "fizzbuzz";

            if (n % 5 == 0)
                return "buzz";

            if (n % 3 == 0)
                return "fizz";

            return n.ToString();
        }
    }
}
