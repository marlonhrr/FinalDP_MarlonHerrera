using System;

namespace QuadraticEquations.Core.Services
{
    public class QuadraticEquations : IQuadraticEquations
    {
        public double QuadraticEquationsX1(double a, double b, double c)
        {
            return (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / (2 * a));
        }

        public double QuadraticEquationsX2(double a, double b, double c)
        {
            return (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / (2 * a));
        }
    }
}