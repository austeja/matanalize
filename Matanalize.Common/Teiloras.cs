using System;
using MathNet.Numerics;
using MathNet.Numerics.Differentiation;
using MathNet.Symbolics;

namespace Matanalize.Common
    {
    public class Taylor
    {
        public static SymbolicExpression GetTaylor(int k, SymbolicExpression symbol, SymbolicExpression a, SymbolicExpression x)
        {
            int factorial = 1;
            SymbolicExpression accumulator = SymbolicExpression.Zero;
            SymbolicExpression derivative = x;
            for (int i = 0; i < k; i++)
            {
                var subs = derivative.Substitute(symbol, a);
                derivative = derivative.Differentiate(symbol);
                accumulator = accumulator.Add(subs / factorial * (symbol.Subtract(a)).Pow(i));
                factorial *= (i + 1);
            }

            return accumulator.Expand();
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