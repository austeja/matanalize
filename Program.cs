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
                
            var t = new Taylor();
            t.GetTaylor();
        }
    }
}
