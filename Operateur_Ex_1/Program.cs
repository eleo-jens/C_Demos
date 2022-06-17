using System;

namespace Operateur_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;

            int division = a / b;
            Console.WriteLine(division);
            int modulo = a % b;
            Console.WriteLine(modulo);
            double precis = (double)a / b;
            Console.WriteLine(precis);

        }
    }
}
