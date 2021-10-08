using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson0210
{
    class Program
    {
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание1");
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            Rashenie myclass = new Rashenie(a, b, c);

            Console.WriteLine("Задание2");
            int[] massiv = new int[20];
            Random element = new Random();
            for (int i=0;i<massiv.Length;i++)
            {
                massiv[i] = element.Next();
            }
            int o1= Convert.ToInt32(Console.ReadLine());
            int o2 = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<massiv.Length;i++)
            {
                if (massiv[i] == o1)
                { massiv[i] = o2; }
                else if (massiv[i]==o2)
                { massiv[i] = o1; }
            }

            Console.WriteLine("Задание3");
            Console.WriteLine("Сколько чисел будете сортировать?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i=0; i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(array);
            Console.WriteLine("После сортировки:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();

            Console.WriteLine("Задание4");
            int col = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[col];
            int summ = 0;
            int proref = 1;
            int srznach;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
                summ += mas[i];
                proref *= mas[i];
                col += 1;
            }
            srznach = summ / col;
            Console.WriteLine("{0},{1},{2}", summ, proref, srznach);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Задание5");
                string input = Console.ReadLine().ToLower();
                if (input == "exit" || input == "закрыть")
                {
                    return;
                }
                int number = Convert.ToInt32(input);
                if (number >= 0 && number <= 9)
                {
                    Console.WriteLine(digits[number].Replace(number.ToString(),"#"));
                }
                else
                { 
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("mistake");
                    System.Threading.Thread.Sleep(3000);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.ReadKey();
            }
        }
        static string[] digits = new string[] {
@" 0000
00  00
00  00
00  00
 0000",
@"1111
  11
  11
  11
111111",

@" 2222
22  22
   22
  22
222222",

@" 3333
33  33
   333
33  33
 3333",

@" 44  44
44  44
444444
    44
    44",

@" 555555
55
55555
    55
55555",

@" 6666
66
66666
66  66
 6666",

@" 777777
   77
  77
 77
77",

@" 8888
88  88
 8888
88  88
 8888",

@" 9999
99  99
 99999
    99
 9999"
                };
    }
    class Rashenie
    {
        private double a;
        private double b;
        private double c;
        private double D;
        private double x1;
        private double x2;
        public Rashenie(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void podchet()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1= {0}\n x2= {1}", x1, x2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
                Console.ReadKey();
            }

        }

    }
}
