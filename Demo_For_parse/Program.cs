using System;

namespace Demo_For_parse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boucle for

            #region Arithmétique

            //for (int i = 0; i <= 10; i+=2)
            //{
            //    Console.ForegroundColor = (ConsoleColor)i;
            //    Console.WriteLine(i);
            //}
            //i n'existe que dans le contexte de la boucle For: Console.WriteLine(i);

            #endregion

            #region Non Arithmétique

            //Console.WriteLine("Veuillez indiquer un numéro: ");
            //bool isOk = true;
            ////tant que ce n'est pas un numéro alors je redemande un input, si ce n'est pas un numéro, je rentre dans ma boucle et je peux prévenir l'utilisateur: j'ai deux conditions il faut que ca ne soit pas un numéro et que l'user ait dit "oui" donc le isOk est true.
            //for (string input = Console.ReadLine(); !int.TryParse(input, out _) && isOk; input = Console.ReadLine())
            //{
            //    Console.WriteLine("Sais-tu ce qu'est un numéro? (Oui/Non)");
            //    isOk = Console.ReadLine() == "Oui";
            //}
            //Console.WriteLine("Vous avez entré un nombre correct");

            #endregion
            #endregion

            #region while
            #region Arithmétique

            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.WriteLine(x);// x reste modifié car la valeur existe en dehors de la boucle: seule différence avec le for

            #endregion

            #region Non-arithémtique

            Console.WriteLine("Veuillez rentrer un nombre: ");
            string input = Console.ReadLine();
            int i;

            // tant que l'utilisateur n'a pas rentré de nombre correct, il reste  dans la boucle
            while (!int.TryParse(input, out i))
            {
                Console.WriteLine("Veuillez rentrer un nombre correct: ");
                input = Console.ReadLine();
            }

            #endregion
            #endregion


        }
    }
}
