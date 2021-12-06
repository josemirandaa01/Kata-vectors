using System;

namespace VectorLibrary
{
    public class Vectores
    {
        public double x;
        public double y;

        public static (double,double) Vector(int x, int y)
        {
            Vectores vector = new Vectores();
            vector.x = x;
            vector.y = y;

            return (vector.x, vector.y);
        }

        public static double Magnitude(double x1,double x2,double y1,double y2)
        {
            double answer = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
            return answer;
        }

        public static double DotProduct(double x1, double x2, double y1, double y2)
        {
            double answer = (x1 * y1) + (x2 * y2);
            return answer;
        
        }

        public static double AngleBetween(double x1, double x2, double y1, double y2)
        {
            double mod1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1,2));
            double mod2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2,2));

            double answer = ((x1 * x2) + (y1 * y2)) / (mod1 * mod2);

            return Math.Acos(answer) * 180 / Math.PI;
        }
    }


}
