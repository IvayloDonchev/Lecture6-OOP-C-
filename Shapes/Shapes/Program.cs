using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shapes
{
    public abstract class Shape
    {
        public int x, y; // координати на центъра на фигурата
        public abstract double Area { get; }
        public Shape(int x=0, int y=0) { this.x = x; this.y = y; }
    }

    public class Rectangle : Shape
    {
        private int a, b; // дължини на страните
        public Rectangle(int a, int b) : base(1,2)
        {
            this.a = a;
            this.b = b;
            if (a <= 0 || a > 1920)
                throw new ArgumentOutOfRangeException("a");
            if (b <= 0 || b > 1080)
                throw new ArgumentOutOfRangeException("b");
        }

        public override double Area => a*b;

        public override string ToString()
        {
            return $"Rectangle with sides {a} and {b}";
        }
    }

    public class Circle : Shape
    {
        private int radius;
        public Circle(int r)
        {
            this.radius = r;
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("radius");
        }
        public override double Area => Math.PI * radius * radius;
        public override string ToString()
        {
            return $"Circle with radius {radius}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 10);
            Circle circ = new Circle(3);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(rect);
            shapes.Add(circ);
            shapes.Add(new Circle(10));
            foreach(var shape in shapes)
            {
                Console.WriteLine(shape);
                Console.WriteLine($"Area = {shape.Area}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
