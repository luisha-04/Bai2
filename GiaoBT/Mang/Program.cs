using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap vao so phan tu cua mang: ");
            }while(!int.TryParse(Console.ReadLine(), out n) || n<=0);
            Console.WriteLine("Nhap vao gia tri cac phan tu cua mang");
            int[] arr = new int[n];
            for(int i= 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] result = Array.FindAll(arr,x=> x > 0);
            Console.WriteLine("So lon nhat trong mang la: "+arr.Max());
            Console.WriteLine("So nho nhat trong mang la: " + arr.Min());
            Console.WriteLine("Tong cac phan  tu trong mang la: " + arr.Sum());
            Console.WriteLine("Cac phan tu trong mang > 0 la: " + string.Join(", ", result));
            Console.ReadLine();
        }
    }
}
