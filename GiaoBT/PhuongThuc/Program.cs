using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so luong phan tu cua mang: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            int[] arr = new int[n];
            Random random = new Random();
            Console.WriteLine("Nhap cac phan tu cua mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("Mang ban dau la: ");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            HashSet<int> set = new HashSet<int>();//tap hop khong trung lap cac phan tu
            Console.WriteLine("Mang cac so nguyen to: ");
            for(int i = 0; i < arr.Length; i++)
            {
                if (Ngto(arr[i]) && !set.Contains(arr[i]))
                {
                    Console.Write(arr[i] + " ");
                    set.Add(arr[i]);
                }
            }
            Console.ReadLine();

        }
        static bool Ngto(int n)
        {
            if (n <= 2)
            {
                return false;
            }           
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n%i == 0)
                {
                    return false;
                }               
            }
            return true;
        }
    }          
}
