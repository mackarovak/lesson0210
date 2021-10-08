using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkmeth0210
{
    class Program
    {
        public static int GetMax(int first, int second)
        {
            return first > second ? first : second;
        }
        public static void obmen(string[] args)
        {
            int a = 7, b = 5;
            Console.WriteLine("a -> {0}; b -> {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("a -> {0}; b -> {1}", a, b);
        }

        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание5.1");
            int m, n, nod;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            while (m != n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }

            nod = n;
            Console.WriteLine("НОД: " + nod);

            Console.ReadKey();
        }
        static int Fibonacci(int p1, int p2, int n)
        {
            return n == 0 ? p1 : Fibonacci(p2, p1 + p2, n - 1);
        }
        static int Fib(int n) { return Fibonacci(0, 1, n); }

        static ulong Factorial(uint n)
        {
            return n == 0 ? 1 : Factorial(n - 1) * n;
        }
        static void Factorial(string[] args)
        {
            Console.Write("n = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Факториал числа {n} равен {Factorial(n)}");
            Console.ReadLine();
        }
        static void factor(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            bool flag = fact(ref a);
            Console.WriteLine(Convert.ToString(flag) + " " + Convert.ToString(a));
        }
        static bool fact(ref int num)
        {
            int c = num;
            num = 1;
            for (int i = 1; i <= c; i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch { return false; }
            return true;
        }
    }
}
