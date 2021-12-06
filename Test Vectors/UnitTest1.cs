using NUnit.Framework;
using VectorLibrary;

namespace Test_Vectors
{
    public class Tests
    {

        [Test]
        public void Vector_Test()
        {
           int valueX = 1;
           int valueY = 5;
           (double, double) expected = (1,5);
           (double, double) answer = VectorLibrary.Vectores.Vector(valueX,valueY);

            Assert.AreEqual(expected,answer);
        }

        [Test]
        public void Magnitude_Test()
        {
            double x1 = 1, x2 = 5, y1 = 1, y2 = 3;
            double expected = 4.4721359549995796;
            double answer = VectorLibrary.Vectores.Magnitude(x1,x2,y1,y2);

            Assert.AreEqual(expected, answer);
        }

        [Test]
        public void DotProduct_Test()
        {
            double x1 = 1, x2 = 3, y1 = -5, y2 = 2;
            double expected = 1;
            double answer = VectorLibrary.Vectores.DotProduct(x1, x2, y1, y2);

            Assert.AreEqual(expected, answer);
        }

    }
}