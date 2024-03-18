using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhBai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cd, cr;
            do
            {
                Console.Write("Nhap vao chieu dai cua hcn: ");
            }while(!float.TryParse(Console.ReadLine(), out cd) || cd <=0 );
            do
            {
                Console.Write("Nhap vao chieu rong cua hcn: ");
            }while(!float.TryParse(Console.ReadLine(), out cr) || cr <=0 );
            float dt = cd * cr;
            float cv = 2 * (cd + cr);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Dien tich cua hinh chu nhat = " + dt);
            Console.WriteLine("Chu vi cua hinh chu nhat = " + cv);
            Console.ReadLine();
        }
    }
}
