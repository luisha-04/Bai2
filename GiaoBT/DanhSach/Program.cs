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
            List<string> ThanhPho = new List<string>() ;
            ThanhPho.Add("Ha Noi");
            ThanhPho.Add("Ho Chi Minh");
            ThanhPho.Add("Hai Phong");
            ThanhPho.Add("Da Nang");
            ThanhPho.Add("Can Tho");
            //sap xep thanh pho theo thu tu A-Z
            ThanhPho.Sort();
            Console.WriteLine($"Danh sach {ThanhPho.Count} thanh pho: ");
            foreach (string tp in ThanhPho)
            {
                Console.WriteLine(tp);
            }
            ThanhPho.Remove("Ha Noi");//xoa thanh pho HN
            ThanhPho.Add("Thai Binh");
            ThanhPho.Add("Quang Ninh");
            ThanhPho.Add("Bac Ninh");
            ThanhPho.Add("Nam Dinh");
            Console.WriteLine($"Danh sach {ThanhPho.Count} thanh pho: ");
            foreach (string tp in ThanhPho)
            {
                Console.WriteLine($"{tp} ");
            }
            Console.ReadLine();
        }
    }
}
