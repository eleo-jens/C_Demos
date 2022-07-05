using System;

namespace Demo_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Bienvenu sur la borne automatique de l'{Euromillion.GAME_NAME}");

            Euromillion combinaison;
            Console.WriteLine("Veuillez encoder vos chiffres.");
            Console.WriteLine("Premier chiffre: ");
            combinaison.code1 = int.Parse(Console.ReadLine()); // Vaut mieux faire un tryparse 
            Console.WriteLine("Deuxième chiffre: ");
            combinaison.code2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Troisième chiffre: ");
            combinaison.code3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quatrième chiffre: ");
            combinaison.code4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cinquième chiffre: ");
            combinaison.code5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez encoder vos étoiles.");
            Console.WriteLine("Première étoile: ");
            combinaison.star1 = short.Parse(Console.ReadLine());
            Console.WriteLine("Deuxième étoile: ");
            combinaison.star2 = short.Parse(Console.ReadLine());

            Console.WriteLine($"Votre combinaison est : {combinaison.code1} - {combinaison.code2} - {combinaison.code3} - {combinaison.code4} - {combinaison.code5} *{combinaison.star1} *{combinaison.star2}");

            // ici pour utiliser une structure avec les valeurs par défaut (à la va vite) utiliser un new
            // création d'une instance: préparer une zone mémoire pour pouvoir stocker les valeurs par défaut
            // si on ne crée par d'instance il faut obligatoirement initialiser toutes les variables constituant la structure
            // new = opérateur
            Euromillion combinaison_gagnante = new Euromillion();

            Console.WriteLine($"Votre combinaison est : {combinaison_gagnante.code1} - {combinaison_gagnante.code2} - {combinaison_gagnante.code3} - {combinaison_gagnante.code4} - {combinaison_gagnante.code5} *{combinaison_gagnante.star1} *{combinaison_gagnante.star2}");

        }
    }
}
