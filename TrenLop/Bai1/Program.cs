using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao n: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 100);
            //int[] arr = new int[n];
            //for(int i = 0; i<arr.Length; i++)
            //{
            //    Console.WriteLine($"Nhap phan tu thu {i+1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //double sum = 0;
            //foreach(int i in arr)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}

            List<int> li = new List<int>();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
                int x = int.Parse(Console.ReadLine());
                li.Add(x);
                if (x % 2 == 0)
                {
                    sum += x;
                }

            }
            Console.WriteLine("Tong cac phan tu chan = " + sum);
            li.Sort();
            Console.WriteLine("Mang duoc sap xep tang dan: ");
            for (int i=0; i<n;i++)
            {
                Console.Write($"{li[i]} ");
            }
            
            Console.ReadLine();
        }
    }
}

