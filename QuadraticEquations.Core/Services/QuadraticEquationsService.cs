using System;

namespace QuadraticEquations.Core.Services
{
    public class QuadraticEquationsService : IQuadraticEquationsService
    {
        public double QuadraticEquationsX1(float a, float b, float c)
        {
            return (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }

        public double QuadraticEquationsX2(float a, float b, float c)
        {
            return (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }
    }
}