using System;

namespace Demo_Variables_Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exo int.Parse(...)

            Console.WriteLine("Donnez moi un nombre: ");
            string input_n1 = Console.ReadLine();
            // int num1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Donnez moi un autre nombre: ");
            string input_n2 = Console.ReadLine();
            Console.Clear();

            int num1 = int.Parse(input_n1);
            int num2 = int.Parse(input_n2);
            int somme = num1 + num2;
            Console.WriteLine($"Avec Parse: {num1} + {num2} = {somme}");
            //Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            #endregion

            #region Exo int.TryParse(...)

            Console.WriteLine("Donnez moi un nombre: ");
            string input = Console.ReadLine(); 
            Console.Clear();

            int nb1;
            bool check = int.TryParse(input, out nb1);
            // int.TryParse(input_n1, out nb1) on récupere le boolean que si on en a besoin, autrement ca ne sert à rien de stocker le résultat
            Console.WriteLine($"Verification de la conversion de {nb1}: {check}");
            
            Console.WriteLine("Donnez moi un autre nombre: ");
            input = Console.ReadLine(); //on réutilise la variable string du début car on en a plus besoin car c'est dans nb1: économie des variables
            Console.Clear();

            int nb2;
            check = int.TryParse(input, out nb2); //on réutilise la variable check car on plus besoin de sa précédente valeur
            Console.WriteLine($"Verification de la conversion de {nb2}: {check}");
            Console.WriteLine($"Avec TryParse: {nb1} + {nb2} = {nb1 + nb2}");
            #endregion

        }
    }
}
