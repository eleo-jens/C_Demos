using System;

namespace Demo_decrementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            Console.WriteLine($"Que font : {(--i * i++)}"); // le -- est prioritaire donc i valant 5, devient 4: 4*4 est éxécuté; le i++ se fait à la toute fin; après 4 * 4 et le i++ s'éxécute i redevient 5: 
            Console.WriteLine(i);
        }
    }
}
