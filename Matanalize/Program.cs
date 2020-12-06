using System;
using Matanalize.Common;

namespace Matanalize
    {
    class Program
        {
        public static Func<double, double> function = x => Math.Pow(Math.E, x) * Math.Sin(x);

        static void Main(string[] args)
            {
            Taylor.GetTaylor();

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
