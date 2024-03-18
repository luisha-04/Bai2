using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiThua
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
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            Console.WriteLine($"Giai thua cua {n}! = " + giaithua(n));
            Console.ReadLine();
        }
        static long giaithua(int n)
        {
            if (n == 0 || n==1)
            {
                return 1;
            }
            else
            {
                return giaithua(n - 1) * n;
            }
        }
    }
}
