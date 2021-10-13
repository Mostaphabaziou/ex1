using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        void prime_num(long num)
        {
            bool isPrime = true;
            for (int i = 0; i <= num; i++)
            {
                for (int j = 2; j <= num; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime:" + i);
                }
                isPrime = true;
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.prime_num(999999999999999L);
            Console.ReadLine();
        }
    }
}