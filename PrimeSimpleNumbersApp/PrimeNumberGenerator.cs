using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSimpleNumbersApp
{
    public class PrimeNumberGenerator : IEnumerable<int>
    {
        private readonly int start;
        private readonly  int end;

        public PrimeNumberGenerator(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = start; i <= end; i++)
            {
                if (isPrime(i))
                {
                    yield return i;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private bool isPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
