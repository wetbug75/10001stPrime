using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primelist = new ArrayList();
            for (long i = num - 1; i > 1; i--)
            {
                if (isPrime(i))
                    primelist.Add(i);
            }
        }

        static bool isPrime(long n)
        {
            for (long i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
                Console.WriteLine("test: " + i);
            }
            return true;
        }
    }
}
