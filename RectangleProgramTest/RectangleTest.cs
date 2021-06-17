using System;
using NUnit.Framework;
namespace RectangleProgramTest
{
    public class RectangleTest
    {
        RectangleProgram.Rectangle rectangle = new RectangleProgram.Rectangle();
        //Assert Default Values
        [Test]
        public void DefaultLengthValue()
        {
            int length = rectangle.GetLength();
            Assert.That(length, Is.EqualTo(1));
        }

        [Test]
        public void DefaultWidthValue()
        {

            int width = rectangle.GetWidth();
            Assert.That(width, Is.EqualTo(1));
        }
        [Test]
        public void SetLength()
        {
            int lengtht = 1;
            int setLength = rectangle.SetLength(7);
            Assert.That(lengtht, Is.Not.EqualTo(setLength));

        }
        [Test]
        public void SetWidth()
        {
            int width = 1;
            int setWidth = rectangle.SetWidth(9);
            Assert.That(width, Is.Not.EqualTo(setWidth));

        }
        [Test]
        public void DefaultPerimeterValue()
        {

            int Perimeter = rectangle.GetPerimeter();
            Assert.That(Perimeter, Is.EqualTo(4));
        }
        [Test]
        public void DefaultAreaValue()
        {

            int area = rectangle.GetArea();
            Assert.That(area, Is.EqualTo(1));
        }

        //Test For Zero Values
        [Test]
        public void DefaultLengthValueIsNotZero()
        {
            int length = rectangle.GetLength();
            Assert.That(length, Is.Not.EqualTo(0));
        }

        [Test]
        public void DefaultWidthValueIsNotZero()
        {

            int width = rectangle.GetWidth();
            Assert.That(width, Is.Not.EqualTo(0));
        }
        [Test]
        public void SetLengthIsNotZero()
        {
            int lengtht = 1;
            int setLength = rectangle.SetLength(7);
            Assert.That(lengtht, Is.Not.EqualTo(0));

        }
        [Test]
        public void SetWidthIsNotZero()
        {
            int width = 1;
            int setWidth = rectangle.SetWidth(9);
            Assert.That(width, Is.Not.EqualTo(0));

        }
        [Test]
        public void DefaultPerimeterValueIsNotZero()
        {

            int Perimeter = rectangle.GetPerimeter();
            Assert.That(Perimeter, Is.Not.EqualTo(0));
        }
        [Test]
        public void DefaultAreaValueIsNotZero()
        {

            int area = rectangle.GetArea();
            Assert.That(area, Is.Not.EqualTo(0));
        }
        //Test For Null Values
        [Test]
        public void DefaultLengthValueIsNotNull()
        {
            int length = rectangle.GetLength();
            Assert.That(length, Is.Not.EqualTo(null));
        }

        [Test]
        public void DefaultWidthValueIsNotNull()
        {

            int width = rectangle.GetWidth();
            Assert.That(width, Is.Not.EqualTo(null));
        }
        [Test]
        public void SetLengthIsNotNull()
        {
            int lengtht = 1;
            int setLength = rectangle.SetLength(7);
            Assert.That(lengtht, Is.Not.EqualTo(null));

        }
        [Test]
        public void SetWidthIsNotNull()
        {
            int width = 1;
            int setWidth = rectangle.SetWidth(9);
            Assert.That(width, Is.Not.EqualTo(null));

        }
        [Test]
        public void DefaultPerimeterValueIsNotNull()
        {

            int Perimeter = rectangle.GetPerimeter();
            Assert.That(Perimeter, Is.Not.EqualTo(null));
        }
        [Test]
        public void DefaultAreaValueIsNotNull()
        {

            int area = rectangle.GetArea();
            Assert.That(area, Is.Not.EqualTo(null));
        }


    }
}
