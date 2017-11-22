using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Лаба3
{

    interface IPrint
    {
        void Print();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 5);
            Square square = new Square(5);
            Circle circle = new Circle(1);
            // rect.Print();
            // square.Print();
            // circle.Print();
            ArrayList GFa = new ArrayList();//создание необобщенной коллекции.
            GFa.Add(rect);
            GFa.Add(square);
            GFa.Add(circle);
            Console.WriteLine("\nПеред сортировкой необобщённой коллекции");
            foreach (object i in GFa) Console.WriteLine(i);
            GFa.Sort();
            Console.WriteLine("\nПосле сортировки");
            foreach (object i in GFa)
                Console.WriteLine(i);
            {
                string type = rect.GetType().Name;
                Console.WriteLine("Определение типа данных метода прямоугольник");
                if (type == "Int32")
                {
                    Console.WriteLine("Целое число:" + rect.ToString());
                }
                else if (type == "String")
                {
                    Console.WriteLine("Строка:" + rect.ToString());
                }
                else Console.WriteLine("Другой тип");
            }
            List<Figure> GFl = new List<Figure>();//создание обобщенной коллекции.
            GFl.Add(rect);
            GFl.Add(square);
            GFl.Add(circle);
            Console.WriteLine("\nПеред сортировкой обобщённой коллекции");
            foreach (var i in GFl) Console.WriteLine(i);
            GFl.Sort();
            Console.WriteLine("\nПосле сортировки");
            foreach (var i in GFl) Console.WriteLine(i);
            Console.WriteLine("Разреженная матрица");
            Matrix<Figure> cub = new Matrix<Figure>(3, 3, 3, null);
            cub[0, 0, 0] = rect;
            cub[1, 1, 1] = square;
            cub[2, 2, 2] = circle;
            Console.WriteLine(cub.ToString());
            Console.WriteLine("Стэк");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rect);
            stack.Push(square);
            stack.Push(circle);
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
    }
}
