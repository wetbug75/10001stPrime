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
            int i = 1;
            ArrayList primelist = new ArrayList();
            while(primelist.Count < 10001)
            {
                i++;
                if (isPrime(i))
                {
                    primelist.Add(i);
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        static bool isPrime(long n)
        {
            for (long i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
                //Console.WriteLine("test: " + i);
            }
            return true;
        }
    }
}
