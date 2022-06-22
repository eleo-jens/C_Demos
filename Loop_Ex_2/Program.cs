using System;

namespace Loop_Ex_2
{
    //Calculer le factoriel d'un nombre entre au clavier
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int nb;
            string message = "Veuillez entrer un nombre: ";
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                message = "Entrez un nombre correct...";
            } while (!int.TryParse(input, out nb));
 
            int n1 = 1;
            int n2 = 1;
            string suite = "";
            for (int i = nb; i > 0; i--)
            {
                int n = n1 * i;
                n1 = i;
                n2 = n;
                suite = suite + $"{n}";
                
            }
            Console.WriteLine(suite);
            //Console.WriteLine($"Le factoriel de {nb} est {factoriel}");
        }
    }
}
