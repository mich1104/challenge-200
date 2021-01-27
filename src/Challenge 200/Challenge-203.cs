using System.Collections.Generic;

namespace Challenge_200
{
    public class Challenge_203
    {
        private readonly List<int> _primes;
        public Challenge_203()
        {
            _primes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            _primes.Sort();
        }

        public string IsPrime(int number)
        {
            // using the built in binary search documented here: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.binarysearch?view=net-5.0
            var index = _primes.BinarySearch(number);

            return index >= 0 ? "yes" : "no";
        }
    }
}
