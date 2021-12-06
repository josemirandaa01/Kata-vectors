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
    }


}
