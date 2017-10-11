using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_2
{
    
    interface IPrint
    {
       void Print();
    }
    
    abstract class Figure
    {
        public string Shape { get;set; }
        public abstract double Area();
        public override string ToString()
        {
            return this.Shape + " площадью " + this.Area().ToString();
        }
    }
    #region Прямоугольник
    class Rectangle : Figure,IPrint
    {
       protected double Width { get; set; }
       protected double Length { get; set; }
         public Rectangle(double Width,double Length)
        {
            this.Shape = "Прямоугольник";
            this.Width = Width;
            this.Length = Length;
        }
        public override double Area()
        {
            double result = this.Width * this.Length;
            return result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    #endregion
    #region Квадрат
    class Square : Rectangle, IPrint
    {
        public Square(double Length) :base(Length,Length)
        {
            this.Shape = "Квадрат";
            this.Length = Length;

        }
        public override double Area()
        {
            double result = Math.Pow(Length, 2);
            return result;
        }
        public override string ToString()
        {
            return this.Shape + " площадью " + this.Area().ToString();
        }
        public  void  Print()
        {
            Console.WriteLine(this.ToString());
        }

    }
    #endregion
    #region Круг
    class Circle : Figure, IPrint
    {   private double radius;
        public Circle(double radius)
        {
            this.Shape = "Круг";
            this.radius = radius;
        }
        public override double Area()
        {
            double result = Math.Pow(radius, 2) * 3.14;
            return result;
        }
        public override string ToString()
        {
            return this.Shape + " площадью " + this.Area().ToString();
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj1 = new Rectangle(5, 5);
            Square obj2 = new Square(5);
            Circle obj3 = new Circle(4);
            obj1.Print();
            obj2.Print();
            obj3.Print();
            Console.ReadKey();
            
        }
    }
}
