using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            // Nhập số nguyên dương n
            do
            {
                Console.Write("Nhap so nguyen duong n: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            Console.WriteLine($"{n} so Fibonacci dau tien:");

            // In ra dãy Fibonacci
            for(int i = 0; i < n; i++)
            {
                Console.Write(fib(i) + " ");
            }

            Console.ReadLine();
        }
        static int fib(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else if(n == 1)
            {
                return 1;
            }
            else
            {
                return fib(n - 1) + fib(n-2);
            }

        }
    }
}

