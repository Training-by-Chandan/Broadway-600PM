using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway600PM
{
    public interface IArea
    {
        void Area();
    }

    public interface IPerimeter
    {
        void Perimeter();
    }
    public interface IShape : IArea, IPerimeter
    {
        void GetInput();
    }

    public class Rectangle : IShape
    {
       
        public double Length { get; set; }
        public double Breadth { get; set; }

        public void Area()
        {
            var area = Length * Breadth;
            Console.WriteLine("Area of Rectangle is " + area);
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the Length");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth");
            Breadth = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            var perimeter = 2*(Length + Breadth);
            Console.WriteLine("Perimeter of Rectangle is " + perimeter);
        }

        public void Test()
        {

        }
    }

    public class Square : IShape
    {
        public double Length { get; set; }
       

        public void Area()
        {
            var area = Math.Pow(Length,2);
            Console.WriteLine("Area of Square is " + area);
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the Length");
            Length = Convert.ToDouble(Console.ReadLine());
           
        }

        public void Perimeter()
        {
            var perimeter = 4 * Length ;
            Console.WriteLine("Perimeter of Square is " + perimeter);
        }
    }

    public class Circle : IShape // implment interface
    {
        public double Radius { get; set; }


        public void Area()
        {
            var area = Math.PI * Math.Pow(Radius,2);
            Console.WriteLine("Area of Circle is " + area);
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the Radius");
            Radius = Convert.ToDouble(Console.ReadLine());

        }

        public void Perimeter()
        {
            var perimeter = 2* Math.PI* Radius;
            Console.WriteLine("Circumference of circle is " + perimeter);
        }
    }
}
