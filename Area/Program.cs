using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Area
    {
        public float area,area1,area2, breadth, height, side, radius;
        public virtual void display()
        {
            Console.Write("The area of the ");
            area = (side * side);
            area1 = (breadth * height);
            area2 = (3.14f * radius * radius);
        }
    }
    class Square : Area
    {
        public override void display()
        {
            base.display();
            Console.WriteLine("Square is: " + base.area);
        }
    }
    class Rectangle : Area
    {
        public override void display()
        {
            base.display();
            Console.WriteLine("Rectangle is: " + base.area1);
        }
    }
    class Circle : Area
    {
        public override void display()
        {
            base.display();
            Console.WriteLine("Circle is: " + base.area2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square();
            Rectangle r = new Rectangle();
            Circle c = new Circle();
            Console.WriteLine("Enter the side of the square :");
            s.side = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth and height of the rectangle :");
            r.breadth= int.Parse(Console.ReadLine());
            r.height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the radius of the circle :");
            c.radius = int.Parse(Console.ReadLine());
            s.display();
            r.display();
            c.display();
            Console.ReadLine();
        }
    }
}
