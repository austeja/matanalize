using System;

namespace Matanalize
{
    class Lagrange
    {
        public void iterate(Double fromInterval, Double toInterval)
        {
            Double o = 1;
            for(Double i = fromInterval; i <= toInterval; i+=toInterval)
            {
                Console.WriteLine("n={0}, {1}", o , calculateRemainder(i));
                o++;
            }
            Console.WriteLine();
        }
    
        public Double calculateRemainder(Double x)
        {
            Double e = Math.E;
            Double y = Math.Pow(e, x) * Math.Sin(x);

            return y;
        }
    }
}