using System;
using System.IO;
using NUnit.Framework;
using Techniche.Widgets;

namespace TechniceTests
{
    public class Tests
    {
        Techniche.System _system = new Techniche.System();
        Widget[] _badWidgets = { new Square(-1233, -123, -123) };
        private Widget[] _givenInput = {
            new Rectangle(10, 10, 30, 40),
            new Square(15, 30, 35),
            new Ellipse(100, 150, 300, 200),
            new Circle(1, 1, 300),
            new Textbox(5, 5, 200, 100, "sample text")

        };
        private string _givenExpected = @"----------------------------------------------------------------
Bill of Materials
----------------------------------------------------------------
Rectangle (10,10) width=30 height=40
Square (15,30) size=35
Ellipse (100,150) diameterH = 300 diameterV = 200
Circle (1,1) size=300
Textbox (5,5) width=200 height=100 text=""sample text""
----------------------------------------------------------------";
        
        [Test]
        public void GivenExample()
        {
            Assert.AreEqual(_givenExpected, _system.BuildBill(_givenInput));
        }

        [Test]
        public void GivenExampleLineByLine()
        {
            var expected = _givenExpected.Split(Environment.NewLine);
            var actual = _system.BuildBill(_givenInput).Split(Environment.NewLine);
            Assert.AreEqual(expected.Length, actual.Length);
            for (var i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i]);
        }

        [Test]
        public void ErrorFileProduced()
        {
            var initialCount = Directory.GetFiles(".\\", "*.txt").Length;
            _system.BuildBill(_badWidgets);
            var afterCount = Directory.GetFiles(".\\", "*.txt").Length;
            Assert.AreEqual(initialCount + 1, afterCount);
        }
        [Test]
        public void ErrorMessage()
        {
            Assert.AreEqual("+++++Abort+++++", _system.BuildBill(_badWidgets));
        }

        [Test]
        public void SquareValidationWidthPositive()
        {
            var s = new Square(1, 1, 0);
            Assert.IsFalse(s.Validate());
        }
        [Test]
        public void TextboxValidationHeightPositive()
        {
            var s = new Textbox(1, 1, 1, 0);
            Assert.IsFalse(s.Validate());
        }
        [Test]
        public void TextboxValidationWidthPositive()
        {
            var s = new Textbox(1, 1, 0, 1);
        }
    }
}