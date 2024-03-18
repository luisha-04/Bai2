using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTruc
{
    struct HocSinh
    {
        public string HoTen;
        public int Tuoi;
        public bool GioiTinh;//true: nam, false: nu
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so luong hoc sinh: ");
            }while(!int.TryParse(Console.ReadLine(), out n)||n<0);
            HocSinh[] dshocsinh = new HocSinh[n];//tao mot mang gom n hoc sinh
            for(int i = 0; i < dshocsinh.Length; i++)
            {
                //nhap input dau vao
                Console.WriteLine($"Nhap thong tin cho hoc sinh thu {i+1}: ");
                Console.Write("Nhap ho ten hoc sinh: ");
                string hoTen = Console.ReadLine();
                Console.Write("Nhap tuoi hoc sinh: ");
                int tuoi = int.Parse(Console.ReadLine());
                Console.Write("Nhap gioi tinh hoc sinh (nam: true, nu: false): ");
                bool gioiTinh = bool.Parse(Console.ReadLine());

                //luu du lieu vao trong mang danh sach hoc sinh
                dshocsinh[i] = new HocSinh
                {
                    HoTen = hoTen,
                    Tuoi = tuoi,
                    GioiTinh = gioiTinh
                };
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Danh sach hoc sinh ");
            for(int i = 0; i < dshocsinh.Length; i++)
            {
                HocSinh hocSinh = dshocsinh[i];
                string gioiTinh = hocSinh.GioiTinh ? "Nam " : "Nu";
                Console.WriteLine($"Hoc sinh {i + 1}: {hocSinh.HoTen}, {hocSinh.Tuoi}, {gioiTinh}");
            }
            int tongtuoi = 0;
            foreach(HocSinh hocSinh in dshocsinh)//thay vi khai bao int thi dinh nghia struct
            {
                tongtuoi += hocSinh.Tuoi;
            }
            Console.WriteLine($"Tong so tuoi cua {n} hoc sinh= {tongtuoi}");
            Console.ReadLine();
        }
    }
}
