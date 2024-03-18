using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "matrix.txt"; // Đường dẫn file chứa ma trận

            // Đọc ma trận từ file
            int[,] matrix = ReadMatrixFromFile(filePath);

            // Tính tổng các phần tử của ma trận
            int sum = CalculateMatrixSum(matrix);

            // Ghi tổng vào cuối file
            AppendSumToFile(filePath, sum);

            Console.WriteLine("Tổng các phần tử của ma trận đã được ghi vào cuối file.");
            Console.ReadLine();
        }

        static int[,] ReadMatrixFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int rows = int.Parse(reader.ReadLine()); // Số hàng
                int cols = int.Parse(reader.ReadLine()); // Số cột
                int[,] matrix = new int[rows, cols]; // Khởi tạo ma trận

                for (int i = 0; i < rows; i++)
                {
                    string[] values = reader.ReadLine().Split(' ');
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = int.Parse(values[j]);
                    }
                }

                return matrix;
            }
        }

        static int CalculateMatrixSum(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        static void AppendSumToFile(string filePath, int sum)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"Tổng các phần tử của ma trận: {sum}");
            }
        }
    }
}
