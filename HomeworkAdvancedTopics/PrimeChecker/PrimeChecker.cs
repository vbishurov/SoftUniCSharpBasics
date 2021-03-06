﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
        private static bool IsPrime(long n)
        {
            if (n==0||n==1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
