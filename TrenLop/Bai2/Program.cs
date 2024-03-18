using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a=0;
            float b=0;
            float c=0;
            nhap(ref a,ref b,ref c);
            giai(a, b, c);
            Console.Read();
        }
        static void nhap(ref float a,ref float b, ref float c) {
            do
            {
                Console.Write("Nhap vao he so a # 0: ");
            }while(!float.TryParse(Console.ReadLine(), out a) || a==0);
            do
            {
                Console.Write("Nhap vao he so b: ");
            } while (!float.TryParse(Console.ReadLine(), out b));
            do
            {
                Console.Write("Nhap vao he so c: ");
            } while (!float.TryParse(Console.ReadLine(), out c));
        }
        static void giai(float a, float b, float c)
        {
            float delta = b * b - 4 * a * c;
            if(delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem! ");
            }
            else if(delta == 0)
            {
                float x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep: " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta))/(2*a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: ");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
    }
}
