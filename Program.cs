using System;
using MathNet.Numerics;
using MathNet.Numerics.Differentiation;

namespace Matanalize 
{
    class Program
    {
        public static Func<double, double> function = x => Math.Pow(Math.E, x) * Math.Sin(x);
        
        static void Main(string[] args)
        {
            var t = new Taylor();
            t.GetTaylor();
            
            //---------
            // 2. Užrašykite liekamąjį narį.
            // Rn = M * (x-a)^(n+1) / (n+1)!
            // M = f(n+1)(x)

            Lagrange lagrange = new Lagrange();
            
            // 3. Įvertinkite liekamąjį narį. 
            lagrange.getError(-0.5, 0.5, 5);
            lagrange.getError(-0.1, 0.1, 5);
            lagrange.getError(-0.001, 0.001, 5);
        }
    }
}
