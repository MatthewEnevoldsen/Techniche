using System;
using Techniche.Widgets;

namespace Techniche
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new Widget[] {
                new Rectangle(new Position(10, 10), 30, 40),
                new Square(new Position(15, 30), 35),
                new Ellipse(new Position(100, 150), 300, 200),
                new Circle(new Position(1, 1), 300),
                new Textbox(new Position(5, 5), 200, 100, "sample text")

            };
            var system = new System();

            Console.WriteLine(system.BuildBill(input));
        }
    }
}
