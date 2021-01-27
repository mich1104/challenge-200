using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_200
{
    public class Challenge_202
    {
        private List<int> _primes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        /// <summary>
        /// Returns a string expressing how the <paramref name="number"/> can be made by multiplying powers of its prime factors
        /// </summary>
        /// <param name="number">The number to express</param>
        /// <returns>The number expressed as prime factors</returns>
        public string ExpressFactors(int number)
        {
            Dictionary<int, int> factorsUsed = new();

            int numberRemaining = number;
            var isAllPrimes = false;
            do
            {
                // starting at the low end, if the number divided by the prime is a integer, the prime is a factor and is added to the counter.
                for (int i = 0; i < _primes.Count; i++)
                {
                    var prime = _primes[i];
                    if (numberRemaining % prime == 0)
                    {
                        numberRemaining = numberRemaining / prime;

                        // adding prime to the counter
                        AddToFactorsUsed(prime, ref factorsUsed);

                        // if the remaining number is a prime, we have found all factors
                        if (IsPrime(numberRemaining))
                        {
                            // we don't want to count the number one for the output
                            if (numberRemaining != 1) AddToFactorsUsed(numberRemaining, ref factorsUsed);
                            isAllPrimes = true; // all factors found, break the loop to format the string

                            break;
                        }
                    }
                }
            }
            while (!isAllPrimes);

            // string formatting
            List<string> factorStrings = new();

            foreach (var pair in factorsUsed)
            {
                if (pair.Value == 1) factorStrings.Add(pair.Key.ToString());
                if (pair.Value > 1)
                {
                    factorStrings.Add($"{pair.Key}^{pair.Value}");
                    continue;
                }
            }

            return string.Join(" x ", factorStrings);
        }

        private void AddToFactorsUsed(int prime, ref Dictionary<int, int> factorsUsed)
        {
            if (!factorsUsed.ContainsKey(prime))
            {
                factorsUsed.Add(prime, 1);
            }
            else
            {
                factorsUsed[prime]++;
            }
        }

        private bool IsPrime(int number)
        {
            // Should probably at least use the challenge 203 implementation, but to keep things separate
            return _primes.Contains(number) || number == 1; // 1 is not included in the prime numbers list above
        }
    }
}
