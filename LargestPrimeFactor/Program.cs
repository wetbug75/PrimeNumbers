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
            long i = 1;
            ArrayList primelist = new ArrayList();
            while(i < 600851475143)
            {
                i++;
                if (isPrime(i))
                {
                    primelist.Add(i);
                    //Console.WriteLine(i);
                }
            }
            Console.WriteLine("done");
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
