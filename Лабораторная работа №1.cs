using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static double getData()
        {
            while (true)
            {
                double res;
                string str = Console.ReadLine();
                bool ConvertResult = double.TryParse(str, out res);
                if (ConvertResult)
                {
                    Console.WriteLine("Вы ввели число " + res.ToString("F5"));
                    return res;
                }
                else
                {
                    Console.Write("Вы ввели не число,повторите попытку: ");
                }
            }

        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите коэффициент А: ");
            a = getData();
            while (a == 0)
            {
                Console.WriteLine("A не может быть равен нулю");
                 a = getData();

            }

            Console.WriteLine("Введите коэффициент B: ");
            b = getData();
            Console.WriteLine("Введите коэффициент С: ");
            c = getData();
            double D = (b * b - 4 * a * c);
            Console.WriteLine("Дискрименант равен= " + "{1} *{1}-4*{2}*{0}={3}", a, b, c, D);
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("x1= " + x1);
                Console.WriteLine("x2= " + x2);
            }
            else if (D == 0)
            {
                double x1 = b / 2 * a;
                Console.WriteLine("x= " + x1);
            }
            else Console.WriteLine("У уравнения нет корней");
            Console.ReadKey();
        }
    }
}

