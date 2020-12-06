using System;
using MathNet.Numerics;
using MathNet.Numerics.Differentiation;

namespace Matanalize.Common
    {
    public static class Lagrange
    {
        public static void GetError(Double fromInterval, Double toInterval, int n)
        {
            var derivative = new NumericalDerivative((n+2), 0);
            var M = derivative.EvaluateDerivative(Constants.Function, Math.Abs(fromInterval), n+1);

            var R = (M * Math.Pow(Math.Abs(fromInterval) - 0, n + 1)) / SpecialFunctions.Factorial(n + 1);
            
            Console.WriteLine("Kai x priklauso intervalui [{0}, {1}], tai R{2}={3}", fromInterval, toInterval, n, R);
        }
    }
}