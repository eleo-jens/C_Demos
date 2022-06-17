using System;

namespace MySecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, veuillez m'indiquer votre nom: ");
            //Lit une ligne dans la console et stocke l'info dans la variable
            string name = Console.ReadLine();
            //efface ce qu'il y a dans la console pour qu'il n'y ait que le résultat final: efface la question et la réponse de l'écran
            Console.Clear();
            Console.WriteLine("Quel âge avez vous ? ");
            string age = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Bonjour {0}, vous avez {1} ans !", name, age); //string.Format
            Console.WriteLine("Bonjour " + name + ". Vous avez " + age + " ans !");// opérateur +
            Console.WriteLine($"Bonjour {name}, vous avez {age}"); //interpolation de chaine

            //Console.Write("J'ai ");
            //Console.Write(28);
            //Console.Write(" ans.\n");
            //Console.WriteLine("J'ai {0} ans.", 28);
            //Console.WriteLine("{0} fois {1} = {2} ou {3}", 5, 10, 50, "cinquante");
            int x = 8, y = 9;
            Console.WriteLine("La valeur de x: {0}", x);
            Console.WriteLine("La valeur de y: {0}", y);

            //Parse

            Console.WriteLine("Quelle est votre année de naissance ? ");
            string anneeNaissance = Console.ReadLine();
            Console.Clear();
            // anneeNaissance en string en information numerique pour pouvoir faire une opération dessus
            int annee = int.Parse(anneeNaissance);
            Console.WriteLine($"Bonjour {name}, vous avez {2022 - annee} ans!");

            //TryParse

            Console.WriteLine("Quelle est votre année de naissance ? ");
            string anneeNaissance2 = Console.ReadLine();
            Console.Clear();
            // anneeNaissance en string en information numerique pour pouvoir faire une opération dessus
            int annee2;
            bool isConverted = int.TryParse(anneeNaissance2, out annee2); // si 0: annee2 prendra la valeur par défaut, si 1: annee2 recupere la conversion
            Console.WriteLine($"Verification de conversion: {isConverted}");
            Console.WriteLine($"Bonjour {name}, vous avez {2022 - annee2} ans!");

        }
    }
}
