using System;
using MathNet.Numerics;
using MathNet.Numerics.Differentiation;

namespace Matanalize.Common
    {
    public class Taylor
    {
        public static string GetTaylor()
        {
            var polynomial_firstDerivative  = GetNthTaylorFormulaCoefficient(1);
            var polynomial_secondDerivative = GetNthTaylorFormulaCoefficient(2);
            var polynomial_thirdDerivative  = GetNthTaylorFormulaCoefficient(3);
            var polynomial_fourthDerivative = GetNthTaylorFormulaCoefficient(4);
            var polynomial_fifthDerivative  = GetNthTaylorFormulaCoefficient(5);

            var first = polynomial_firstDerivative != 0 ? (polynomial_firstDerivative == 1 ? "x" : $"({polynomial_firstDerivative})x") : "";
            var sec = polynomial_secondDerivative != 0 ? (polynomial_secondDerivative == 1 ? " + x^2" : $" + ({polynomial_secondDerivative})x^2") : "";
            var third = polynomial_thirdDerivative != 0 ? (polynomial_thirdDerivative == 1 ? " + x^3" : $" + ({polynomial_thirdDerivative})x^3") : "";
            var fourth = polynomial_fourthDerivative != 0 ? (polynomial_fourthDerivative == 1 ? " + x^4" : $" + ({polynomial_fourthDerivative})x^4") : "";
            var fifth = polynomial_fifthDerivative != 0 ? (polynomial_fifthDerivative == 1 ? " + x^5" : $" + ({polynomial_fifthDerivative})x^5") : "";
            
            Console.WriteLine(first + sec + third + fourth + fifth);

            return first + sec + third + fourth + fifth;
        }

        public static double GetNthOrderDerivativeValueAt0(int n)
            {
            var derivative = new NumericalDerivative(6, 0);
            return derivative.EvaluateDerivative(Constants.Function, 0, n);
            }

        public static double GetNthTaylorFormulaCoefficient(int n)
            {
            var derivativeValue = GetNthOrderDerivativeValueAt0(n);
            return Math.Round(derivativeValue / SpecialFunctions.Factorial(n), 2, MidpointRounding.ToEven);
            }
    }
}