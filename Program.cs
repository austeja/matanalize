using System;

namespace Matanalize
    {
    class Program
        {
        static void Main(string[] args)
            {
                Lagrange lagrange = new Lagrange();
                
                // 2. Užrašykite liekamąjį narį 
                lagrange.iterate(-1, 1);
                
                // 3. Įvertinkite liekamąjį narį. 
                lagrange.iterate(-0.5, 0.5);
                lagrange.iterate(-0.1, 0.1);
                lagrange.iterate(-0.001, 0.001);
            }
        }
    }

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
