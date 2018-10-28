using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime;
            int number = 100;
            int i, j;

            for (i = 2; i <= number; i++)
            {
                isPrime = true;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
