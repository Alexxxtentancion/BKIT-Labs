using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб6
{
    class Program
    {
        delegate float Calculator(float p1, float p2);
        static float Add(float p1, float p2)
        {
            return p1 + p2;
        }
        static float Sub(float p1,float p2)
        {
            return p1 - p2;
        }
        static float Mul(float p1,float p2)
        {
            return p1 * p2;
        }
        static float Dev(float p1,float p2)
        {
            return p1 / p2;
        }
         static void CalculatorMethod(string str,float x,float y,Calculator CalculatorParam)
         {
            float res = CalculatorParam(x, y);
            Console.WriteLine(str + res.ToString());
         }
   

        static void Main(string[] args)
        {
            Console.WriteLine("x=9,y=3");
            float x = 9;
            float y = 3;
            Console.WriteLine("Умножение!");
            CalculatorMethod("Сложение ", x, y, Add);//передаётся метод.
            CalculatorMethod("Вычитание ", x, y, Sub);
            CalculatorMethod("Умножение ", x, y, Mul);
            CalculatorMethod("Деление ", x, y, Dev);
            //Calculator op1 = new Calculator(Mul);

            CalculatorMethod("Лямбда(умножение) ", x, y, (m, n) => n * m);
            CalculatorMethod("Лямбда(Деление) ", x, y, (m, n) => n / m);
            CalculatorMethod("Лямбда(Сложение) ", x, y, (m, n) => n + m);
            CalculatorMethod("Лямбда(Вычитание) ", x, y, (m, n) => n - m);
            Console.WriteLine("Обобщенный делегат");
           Action<float, float> a1 = (m, n) => {
           Console.WriteLine("{0} * {1} = {2}", m, n, m * n);
                            };
            Action<float, float> a2 = (m, n) => {
                Console.WriteLine("{0} / {1} = {2}", m, n, m / n);
            };
            Action<float, float> group = a1 + a2;
            group(x, y);




        }
    }
}
