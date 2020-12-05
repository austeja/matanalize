using System;
using MathNet.Numerics;
using MathNet.Numerics.Differentiation;

namespace Matanalize
{
    class Taylor
    {
        Func<double, double> function = x => Math.Pow(Math.E, x) * Math.Sin(x);

        public String GetTaylor()
        {
            var derivative = new NumericalDerivative(6, 0);
            var firstDerivative = derivative.EvaluateDerivative(function, 0, 1);
            var secondDerivative = derivative.EvaluateDerivative(function, 0, 2);
            var thirdDerivative = derivative.EvaluateDerivative(function, 0, 3);
            var fourthDerivative = derivative.EvaluateDerivative(function, 0, 4);
            var fifthDerivative = derivative.EvaluateDerivative(function, 0, 5);

            var polynomial_firstDerivative = Math.Round(firstDerivative / SpecialFunctions.Factorial(1), 2, MidpointRounding.ToEven);
            var polynomial_secondDerivative = Math.Round(secondDerivative / SpecialFunctions.Factorial(2), 2, MidpointRounding.ToEven);
            var polynomial_thirdDerivative = Math.Round(thirdDerivative / SpecialFunctions.Factorial(3), 2, MidpointRounding.ToEven);
            var polynomial_fourthDerivative = Math.Round(fourthDerivative / SpecialFunctions.Factorial(4), 2, MidpointRounding.ToEven);
            var polynomial_fifthDerivative = Math.Round(fifthDerivative / SpecialFunctions.Factorial(5), 2, MidpointRounding.ToEven);

            var first = polynomial_firstDerivative != 0 ? (polynomial_firstDerivative == 1 ? "x" : $"({polynomial_firstDerivative})x") : "";
            var sec = polynomial_secondDerivative != 0 ? (polynomial_secondDerivative == 1 ? " + x^2" : $" + ({polynomial_secondDerivative})x^2") : "";
            var third = polynomial_thirdDerivative != 0 ? (polynomial_thirdDerivative == 1 ? " + x^3" : $" + ({polynomial_thirdDerivative})x^3") : "";
            var fourth = polynomial_fourthDerivative != 0 ? (polynomial_fourthDerivative == 1 ? " + x^4" : $" + ({polynomial_fourthDerivative})x^4") : "";
            var fifth = polynomial_fifthDerivative != 0 ? (polynomial_fifthDerivative == 1 ? " + x^5" : $" + ({polynomial_fifthDerivative})x^5") : "";
            
            Console.WriteLine(first + sec + third + fourth + fifth);

            return first + sec + third + fourth + fifth;
        }
    }
}