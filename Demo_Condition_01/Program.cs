using System;

namespace Demo_Condition_01
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exemple bool_true
            bool ticket_is_valid = false;

            if (!ticket_is_valid) //c'est vrai donc on passe dans le if
            {
                Console.WriteLine("Vous pouvez passer!");
            }
            else
            {
                Console.WriteLine("Vous ne pouvez pas passer ! Allez racheter un nouveau ticket !");
            }

            #endregion

            Console.WriteLine("Veuillez présenter votre ticket");
            Console.WriteLine("Indiquez le nomvre de trajet restant ou appuis sur n'import quelle touche ...");
            int nbTravel;
            bool have_ticket = int.TryParse(Console.ReadLine(), out nbTravel);

            if (!have_ticket)
            {
                Console.WriteLine("Vous n'avez pas de ticket, allez acheter un ticket !");
            }
            else if (nbTravel > 0)
            {
                Console.WriteLine("Vous pouvez passer!");
                nbTravel--;
            }
            else if (nbTravel == 1)
            {
                Console.WriteLine("Vous pouvez passer! Attention c'est votre dernier trajet");
                nbTravel--;
                have_ticket = false;
            }
            else
            {
                Console.WriteLine("Vous ne pouvez pas passer! Achetez un nouveau ticket !");
            }

            Console.WriteLine("Merci d'avoir voyagez avec nous!");
        }
    }
}
