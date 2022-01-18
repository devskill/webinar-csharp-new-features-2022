using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Math
    {
        public IList<int> GetFactors(int number)
        {
            var factors = new List<int>();

            for(int i = 2; i <= number; i++)
            {
                if(isPrime(i) && number % i == 0)
                    factors.Add(i);
            }

            bool isPrime(int n)
            {
                for(int i = 2; i <= System.Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }

                void Print(int n)
                {
                    Console.WriteLine(n);
                }

                return true;
            }

            return factors;
        }
    }
}
