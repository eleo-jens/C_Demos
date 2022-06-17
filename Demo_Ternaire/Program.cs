using System;

namespace Demo_Ternaire
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5; 
            // Opérateur ternaire: 
            string result = (i == 5) ? "OK" : "NOT OK"; // ne peut pas prendre d'instruction, ce n'est donc pas le raccourci d'un if, ce sont juste des valeurs: on attribue des valeurs selon une certaine condition
            Console.WriteLine((DateTime.Now.Second < 10) ? $"0{DateTime.Now.Second}" : DateTime.Now.Seconde);

            // La traduction en if de l'opérateur terniaire: un if très basic
            if (i == 5) result = "OK";
            else result = "NOT OK";

            if (i == 5) // j'effectue un ensemble d'instruction
            {
                result = "OK";
                Console.WriteLine(result);
            }
            else
            {
                result = "NOT OK";
                throw new Exception();
            }

            string the_best_prof = "Samuel";
            the_best_prof = the_best_prof ?? "Aude"; // contient une valeur non null donc reste la meme

            //par contre si: 
            the_best_prof = null;
            the_best_prof = the_best_prof ?? "Aude"; // la valeur étant nulle on lui donne la valeur "Aude": si la variable est null c'est un moyen de donner une valeur par défaut si on veut absolument qu'elle ait une valeur
        }
    }
}
