using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dau = 0;
            float cuoi = 0;
            Nhap(ref dau, ref cuoi);
            float tien = TinhTien(dau, cuoi);
            Console.WriteLine("So tien dien = "+tien);
            Console.Read();
        }
        static void Nhap(ref float dau,ref float cuoi)
        {
            try
            {
                do
                {
                    Console.Write("Nhap vao so dien dau: ");
                    dau = float.Parse(Console.ReadLine());
                } while (dau < 0);
                do
                {
                    Console.Write("Nhap vao so dien cuoi: ");
                    cuoi = float.Parse(Console.ReadLine());
                } while (cuoi < 0 || cuoi < dau);
            }
            catch (FormatException e)
            {
                Console.WriteLine("So dien duoc nhap vao khong dung dinh dang!");
                Console.WriteLine("Error: " + e.ToString());
            }

        }
        static float TinhTien(float dau, float cuoi)
        {           
            float so = cuoi-dau;
            float tien = 1;
            if (so <= 100)
            {
                tien = 2000 * so;
            }
            else if (so <= 150)
            {
                tien = 100 * 2000 + (so - 100) * 2500;
            }
            else if(so<=200)
            {
                tien = 100 * 2000 + 50 * 2500 + (so-150)*2800;
            }
            else
            {
                tien = 100 * 2000 + 50 * 2500 + 50 * 2800 + (so-200)*3500;
            }
            return tien;
        }
    }
}
