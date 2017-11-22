
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба3
{
    abstract class Figure : IComparable
    {
        public string Shape { get; set; }
        public abstract double Area();
        public override string ToString()
        {
            return this.Shape + " площадью " + this.Area().ToString();
        }

        public int CompareTo(object obj)
        {

            Figure p = (Figure)obj;
            if (this.Area() < p.Area()) return -1;
            else if (this.Area() == p.Area()) return 0;
            else return 1;
        }


    }
    #region Прямоугольник
    class Rectangle : Figure, IPrint
    {
        protected double Width { get; set; }
        protected double Length { get; set; }
        public Rectangle(double Width, double Length)
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
        public Square(double Length)
            : base(Length, Length)
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
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }
    #endregion
    #region Круг
    class Circle : Figure, IPrint
    {
        private double radius;
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
}
