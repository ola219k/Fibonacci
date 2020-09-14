using System;

namespace Fibonacci
{
    
    class Program
    {
        static int getInt()
        {
            int num;
            while (true)
            {
                Console.Write("Enter the number of elements: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    break;
                }
                Console.WriteLine("Please enter an integer value!");
            }
            return num;
        }
        static int fibo(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            int i;

            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
        static void Main(string[] args)
        {
            int i, num;
            num = getInt();
            for (i = 0; i < num ; i++)
            {
                Console.Write(fibo(i) + " ");
            }
        }
    }
}
