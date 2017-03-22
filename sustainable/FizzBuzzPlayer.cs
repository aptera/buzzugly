using System;

namespace sustainable
{
    class FizzBuzzPlayer
    {
        public string Play(int v)
        {
            if (v % 15 == 0)
                return "fizzbuzz";

            if (v % 3 == 0)
                return "fizz";

            if (v % 5 == 0)
                return "buzz";

            return v.ToString();
        }
    }
}