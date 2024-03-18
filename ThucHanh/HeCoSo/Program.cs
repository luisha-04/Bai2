using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeCoSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("----------------------MENU-------------------");
                Console.WriteLine("1. Chuyen doi so nguyen tu he 10 sang he co so khac");
                Console.WriteLine("2. Chuyen doi so nguyen tu he co so khac sang he 10");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("---------------------------------------------");
                Console.Write("Nhap lua chon: ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2 && choice != 0));

            switch (choice)
            {
                case 1:
                    ConvertFromDecimal();
                    break;
                case 2:
                    ConvertToDecimal();
                    break;
                case 0:
                    Console.WriteLine("Thoat chuong trinh.");
                    break;
            }

            Console.ReadLine();
        }

        static void ConvertFromDecimal()
        {
            int decimalNumber, baseValue;

            // Nhập số nguyên từ hệ cơ số 10
            do
            {
                Console.Write("Nhap so nguyen (he co so 10): ");
            } while (!int.TryParse(Console.ReadLine(), out decimalNumber));

            // Nhập hệ cơ số đích
            do
            {
                Console.Write("Nhap he co so dich (2 - 36): ");
            } while (!int.TryParse(Console.ReadLine(), out baseValue) || baseValue < 2 || baseValue > 36);

            string result = ConvertBase(decimalNumber, baseValue);
            Console.WriteLine($"Ket qua: {result}");
        }

        static void ConvertToDecimal()
        {
            string inputNumber;
            int baseValue;

            // Nhập số nguyên từ hệ cơ số B
            do
            {
                Console.Write("Nhap so (he co so B): ");
                inputNumber = Console.ReadLine().ToUpper();
            } while (!IsValidNumber(inputNumber, out baseValue));

            int decimalValue = ConvertToDecimalValue(inputNumber, baseValue);
            Console.WriteLine($"Ket qua: {decimalValue}");
        }
        // chuyen he co so 10 sang he co so B
        static string ConvertBase(int decimalNumber, int baseValue)
        {
            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder result = new StringBuilder();

            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % baseValue;
                result.Insert(0, chars[remainder]);
                decimalNumber /= baseValue;
            }

            return result.Length == 0 ? "0" : result.ToString();
        }
        // chuyen he co so B sang he co so 10
        static int ConvertToDecimalValue(string inputNumber, int baseValue)
        {
            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int decimalValue = 0;
            int power = 0;

            for (int i = inputNumber.Length - 1; i >= 0; i--)
            {
                int digit = chars.IndexOf(inputNumber[i]);
                if (digit >= baseValue)
                    return -1; // Số nhập vào không hợp lệ

                decimalValue += digit * (int)Math.Pow(baseValue, power);
                power++;
            }

            return decimalValue;
        }

        static bool IsValidNumber(string inputNumber, out int baseValue)
        {
            baseValue = 0;
            int parsedValue;

            // Kiểm tra xem số nhập vào có chỉ chứa các ký tự hợp lệ hay không
            foreach (char c in inputNumber)
            {
                if (!char.IsDigit(c) && (c < 'A' || c > 'Z'))
                {
                    return false;
                }
            }

            // Xác định hệ cơ số dựa trên ký tự lớn nhất trong số nhập vào
            for (int i = inputNumber.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(inputNumber[i]))
                {
                    parsedValue = int.Parse(inputNumber[i].ToString());
                }
                else
                {
                    parsedValue = inputNumber[i] - 'A' + 10;
                }

                if (parsedValue > baseValue)
                {
                    baseValue = parsedValue + 1;
                }
            }

            return baseValue >= 2 && baseValue <= 36;
        
        }
    }
}
