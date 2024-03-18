using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a, Nhap vao mot chuoi: ");
            string input = Console.ReadLine();
            Console.WriteLine("a, Cac ky tu trong chuoi vua nhap: ");
            foreach (char kytu in input)
            {
                Console.WriteLine($"{kytu}");
            }
            //////////////////////////
            Console.WriteLine("b, Nhap vao mot chuoi gom cac ky tu va khoang trang: ");
            string inputwithspace = Console.ReadLine();
            Console.WriteLine("Cac tu trong chuoi bo qua khoang trang: ");
            string[] words = inputwithspace.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (string word in words)//duyet tung string trong string[]
            {
                Console.WriteLine(word);
                foreach (char c in word)
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
            }           
            Console.WriteLine("So lan xuat hien ky tu trong chuoi: ");
            foreach(KeyValuePair<char, int> kvp in charCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
             
            Console.ReadLine();
        }
    }
}
