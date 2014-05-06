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
            long i = 1;
            long max = num;
            long answer = 1;
            if(isPrime(num))
                Console.WriteLine(num);
            else
            {
                while(i <= max)
                {
                    i++;
                    if (isPrime(i))
                    {
                        max = num / i;
                        if (num % i == 0)
                        {
                            answer = i;
                        }
                    }
                    Console.WriteLine(max);
                }
            }
            Console.WriteLine("Answer: " + answer);
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
