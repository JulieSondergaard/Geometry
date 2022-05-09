using System;
using System.Collections.Generic;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(6);
            Rectangle rectangle = new Rectangle(14, 5);
            Parallelogram parallelogram = new Parallelogram(3, 5, 20);
            Trapez trapez = new Trapez(10, 9, 8, 9);
            Triangle triangle = new Triangle(10, 9, 9);

            List<Shape> shapes = new List<Shape>() { square, rectangle, parallelogram, trapez, triangle };

          
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.CalculatePerimeter());
                Console.WriteLine($"{shape.CalculateArea()}");

            }

            
            
            Console.WriteLine($"\nSquare perimeter: {square.A} * 4 = {square.CalculatePerimeter()}");
            Console.WriteLine($"Rectangle perimeter: ({rectangle.A} * 2) + ({rectangle.B} * 2) = {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"Parallelogram perimeter: ({parallelogram.A} * 2) + ({parallelogram.B} * 2) = {parallelogram.CalculatePerimeter()}");
            Console.WriteLine($"Trapez perimeter: {trapez.A} + {trapez.B} + {trapez.C} + {trapez.D} = {trapez.CalculatePerimeter()}");
            Console.WriteLine($"Triangle perimeter:  {triangle.A} + {triangle.B} + {triangle.C} = {triangle.CalculatePerimeter()}");
     

            Console.WriteLine($"Square areal: {square.A} * {square.A} = {square.CalculateArea()}");
            Console.WriteLine($"Rectangle areal: {rectangle.A} * {rectangle.B} = {rectangle.CalculateArea()}");
            Console.WriteLine($"Parallelogram areal: {parallelogram.A} * {parallelogram.B} * Sin({parallelogram.Angle}) = {parallelogram.CalculateArea()}");
            Console.WriteLine($"Trapez areal: 0,5 * ({trapez.A} + {trapez.C}) * h = {trapez.CalculateArea()}");
            Console.WriteLine($"Triangle areal: 0,5 * {triangle.A} * {triangle.B} = {triangle.CalculateArea()}");



        }
    }
}
