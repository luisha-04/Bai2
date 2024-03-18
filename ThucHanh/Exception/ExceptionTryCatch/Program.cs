using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFolder = @"c:\source";
            string targetFolder = @"d:\target";
            string fileName = "example.txt";
            string sourceFile = Path.Combine(sourceFolder, fileName);
            string targetFile = Path.Combine(targetFolder, fileName);

            Console.WriteLine("Cách 1: Sử dụng lớp File");
            try
            {
                if (!Directory.Exists(targetFolder))
                    Directory.CreateDirectory(targetFolder);

                File.Copy(sourceFile, targetFile, true);
                Console.WriteLine("File đã được copy thành công!");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Lỗi khi copy file: {ex.Message}");
            }

            Console.WriteLine("\nCách 2: Sử dụng StreamReader và StreamWriter");
            try
            {
                using (StreamReader reader = new StreamReader(sourceFile))
                {
                    using (StreamWriter writer = new StreamWriter(targetFile))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        while ((line = reader.ReadLine()) != null)
                        {
                            writer.WriteLine(line);
                        }
                        writer.Close();//giai phong dung luong
                    }
                    
                }
                
                Console.WriteLine("File đã được copy thành công!");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Lỗi khi copy file: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
