using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSach
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Nhap cac so nguyen cach nhau boi dau cach:");
            string[] inputs = Console.ReadLine().Split(' ');//mang nhap vao

            List<int> numbers = new List<int>();//tao danh sach trong

            foreach (string input in inputs)//chon nhung so hop le
            {
                if (int.TryParse(input, out int number))
                    numbers.Add(number);
            }
            //xu ly tren cac mang rong!
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            List<int> primeNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    evenNumbers.Add(number);//so chan thi cho vao even
                else
                    oddNumbers.Add(number);//so le thi cho vao odd
                if (IsPrime(number))
                    primeNumbers.Add(number);//so nguyen to thi cho vao prime
            }

            Console.WriteLine("\nCac so chan:");
            foreach (int number in evenNumbers)
                Console.Write(number + " ");

            Console.WriteLine("\n\nCac so le:");
            foreach (int number in oddNumbers)
                Console.Write(number + " ");

            Console.WriteLine("\n\nCac so nguyen to:");
            foreach (int number in primeNumbers)
                Console.Write(number + " ");

            Console.ReadLine();
        }
        static bool IsPrime(int n)
        {
            if (n <= 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

    }
}
