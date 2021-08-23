using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void fibo(int n)
        {
            int k = 0, l = 1, j;
            Console.WriteLine("The fibonacci series is ");
            Console.Write(k + " " + l+" ");
            for (int i = 2; i < n; i++)
            {
                j = k + l;
                Console.Write(" "+j + " ");
                k = l;
                l = j;
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            Program p1 = new Program();
            p1.fibo(n);
        }
    }
}
