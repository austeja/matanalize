using System;
using Matanalize.Common;
using MathNet.Symbolics;

namespace Matanalize
    {
    class Program
        {
        static void Main(string[] args)
            {
                var x = SymbolicExpression.Variable("x");
                Console.WriteLine(Taylor.GetTaylor(6, 
                    x, 
                    0, 
                    SymbolicExpression.E.Pow(x).Multiply(x.Sin())
                ));

            //---------
            // 2. Užrašykite liekamąjį narį.
            // Rn = M * (x-a)^(n+1) / (n+1)!
            // M = f(n+1)(x)

            // 3. Įvertinkite liekamąjį narį. 
            Lagrange.GetError(-0.5, 0.5, 5);
            Lagrange.GetError(-0.1, 0.1, 5);
            Lagrange.GetError(-0.001, 0.001, 5);
            }
        }
    }
