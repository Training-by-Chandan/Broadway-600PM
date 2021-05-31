using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway600PM
{

    public abstract class ShapeAbs 
    {
        public abstract void Area();
        public abstract void Perimeter();
        public abstract void GetInput();
        protected int i = 20;
        public void Display()
        {
            Console.WriteLine("I am from abstract classs");
        }
    }

    public class RectangleAbs : ShapeAbs
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public override void Area()
        {
            var area = Length * Breadth;
            Console.WriteLine("Area of Rectangle is " + area);
        }

        public override void GetInput()
        {
            Console.WriteLine("Enter the Length");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth");
            Breadth = Convert.ToDouble(Console.ReadLine());
        }

        public override void Perimeter()
        {
            var perimeter = 2 * (Length + Breadth);
            Console.WriteLine("Perimeter of Rectangle is " + perimeter);
        }
    }


    public class SquareAbs : ShapeAbs
    {
        public double Length { get; set; }


        public override void Area()
        {
            var area = Math.Pow(Length, 2);
            Console.WriteLine("Area of Square is " + area);
        }

        public override void GetInput()
        {
            Console.WriteLine("Enter the Length");
            Length = Convert.ToDouble(Console.ReadLine());

        }

        public override void Perimeter()
        {
            var perimeter = 4 * Length;
            Console.WriteLine("Perimeter of Square is " + perimeter);
        }
    }
}
