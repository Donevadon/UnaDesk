using System.Collections;

namespace UnaDesk
{
    public class TriangleDeterminant
    {
        public TriangleType DefineType(double a, double b, double c)
        {
            var arr = new double[3] { Math.Pow(a, 2), Math.Pow(b, 2), Math.Pow(c, 2) };
            double sum = 0, max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var item = arr[i];
                if(max < item)
                {
                    sum += max;
                    max = item;
                }
                else
                    sum += item;
            }
            var r = max - sum;

            if (r > 0) return TriangleType.ObtuseAngle;
            if (r < 0) return TriangleType.SharpAngled;
            else return TriangleType.Rectangular;
        }
    }
}