using System;

namespace Condition_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinez le type de votre Triangle.\n Entrez la longueur du côté 1: ");
            double cote1;
            double.TryParse(Console.ReadLine(), out cote1);

            Console.WriteLine("Determinez le type de votre Triangle.\n Entrez la longueur du côté 2: ");
            double cote2;
            double.TryParse(Console.ReadLine(), out cote2);

            Console.WriteLine("Determinez le type de votre Triangle.\n Entrez la longueur du côté 3: ");
            double cote3;
            double.TryParse(Console.ReadLine(), out cote3);
        }
    }
}
