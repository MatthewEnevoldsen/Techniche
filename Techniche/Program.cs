using System;
using Techniche.Widgets;

namespace Techniche
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new Widget[] {
                new Rectangle(10, 10, 30, 40),
                new Square(15, 30, 35),
                new Ellipse(100, 150, 300, 200),
                new Circle(1, 1, 300),
                new Textbox(5, 5, 200, 100, "sample text")

            };
            var system = new System();

            Console.WriteLine(system.BuildBill(input));
        }
    }
}
