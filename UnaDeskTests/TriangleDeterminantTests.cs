using System.Diagnostics;
using UnaDesk;

namespace UnaDeskTests
{
    public class TriangleDeterminantTests
    {

        [Test]
        [TestCase(5, 2.887d, 2.5d, TriangleType.ObtuseAngle)]
        [TestCase(17, 18, 13, TriangleType.SharpAngled)]
        [TestCase(16, 14, 11, TriangleType.SharpAngled)]
        [TestCase(63.7917971685828, 19, 64.6297699358994, TriangleType.SharpAngled)]
        [TestCase(7, 3, 8, TriangleType.ObtuseAngle)]
        [TestCase(4, 3, 5, TriangleType.Rectangular)]
        [TestCase(1, 0.838670567945424, 0.544639035015027, TriangleType.Rectangular)]
        [TestCase(2.37172010730026, 16.6691143372134, 17, TriangleType.ObtuseAngle)]
        public void DefineTypeTest(double a, double b, double c, TriangleType expectedType)
        {
            var determinant = new TriangleDeterminant();

            Stopwatch sw = Stopwatch.StartNew();
            var r = determinant.DefineType(a,b,c);
            sw.Stop();
            var result = sw.Elapsed.TotalMilliseconds;
            Console.WriteLine(result);
            Assert.That(r, Is.EqualTo(expectedType));
        }
    }
}