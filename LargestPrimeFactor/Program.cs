using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LargestPrimeFactor
{
    class Program
    {
       

        static void Main(string[] args)
        {
            long num = 600851475143;
            for (long i = num; i > 1; i--)
            {
                if (isPrime(i))
                {
                    if(num % i == 0)
                    {
                        Console.WriteLine(i);
                        Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("end");
            Console.ReadLine();
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
