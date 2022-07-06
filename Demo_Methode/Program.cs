using System;
using System.Collections.Generic;

namespace Demo_Methode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo 1
            ConsoleAvancee ca;
            Coordonnee c1;
            c1.x = 1;
            c1.y = 1;

            ca.RainbowWriteLine($"Ma première coordonnée est située en: {c1.ShowXY()}");

            // on obtient les valeurs par défaut
            Coordonnee c2 = new Coordonnee();

            ca.RainbowWriteLine($"Ma première coordonnée est située en: {c2.ShowXY()}");


            //Demo 2: surcharges
            Geometry g;
            g.QuelleForme();

            //Demo 3: out in params
            Presence wad = new Presence();
            wad.SetClass("Alessandra", "Menen", "Sara", "Nastya", "Maya", "Kassia", "Camille", "Anissa", "Eléonore");
            wad.StudentHere("Sara");
            wad.StudentHere("Paula");
            wad.StudentHere("Eléonore");
            wad.StudentHere("Kassia");
            wad.StudentHere("Maya");
            int nbStudent;

            if (wad.CheckCanBeginLesson(out nbStudent))
            {
                Console.WriteLine($"On peut commencer le cours elles sont: {nbStudent} en classe");
            }
            else
            {
                Console.WriteLine($"On ne peut pas commencer le cours elles sont: {nbStudent} en classe");
            }
        }
    }

    public struct Coordonnee
    {
        /// <summary>
        /// Récupère les coordonées sous format texte
        /// </summary>
        public int x, y;

        // on créer une méthode dans notre structure Coordonnee qui permettra d'afficher les membres de l'instance this (ex: c1 ou c2)
        public string ShowXY()
        {
            return $"X: {this.x} - Y: {this.y}";
        }
    }

    /// <summary>
    /// Ensemble de fonction supplémentaire pour la console
    /// </summary>
    public struct ConsoleAvancee
    {
        /// <summary>
        /// Permet d'afficher mon texte en couleur multicolor poru chaque caractère
        /// </summary>
        /// <param name="text">Texte qui sera affiché</param>
        // ici on crée une structure qui ne contient rien d'autre qu'une fonction
        public void RainbowWrite(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                //permet de changer la couleur de mon programme;
                Console.ForegroundColor = (ConsoleColor)((i % 6) + 9);
                Console.Write(c);
            }
            Console.ResetColor();
        }

        // j'utilise une fonction de ma structure dans le code d'une autre fonction qui se trouve aussi dans ma structure
        public void RainbowWriteLine(string text)
        {
            this.RainbowWrite(text);
            Console.WriteLine();
        }
    }

    //Surcharge de méthodes (plusieurs écritures/ comportements)
    public struct Geometry
    {
        // plusieurs fois des méthodes portant le meme nom mais ayant des parametres différents, pour pouvoir définir des comportements différents
        public void QuelleForme()
        {
            Console.WriteLine("Aucune spécification c'est une forme quelconque");
        }
        public void QuelleForme(int distance)
        {
            Console.WriteLine($"Une distance enregistrée: {distance} cm \nCest une droite.");
        }
        public void QuelleForme(int distance1, int distance2, int distance3)
        {
            Console.WriteLine($"Trois distances enregistrées: \n{distance1} cm \n{distance2} cm \n{distance3} cm \nC'est un triangle.");
        }
        public void QuelleForme(int distance1, int distance2, int distance3, int distance4)
        {
            Console.WriteLine($"Trois distances enregistrées: \n{distance1} cm \n{distance2} cm \n{distance3} cm \n{distance4} cm \nC'est un quadrilatère.");
        }
    }

    public struct Presence
    {
        List<string> students;
        List<bool> areHere;

        //donner les noms de mes éléves à ma liste d'étudiants
        public void SetClass (params string[] names)
        {
            students = new List<string>();
            areHere = new List<bool>();
            foreach (string name in names)
            {
                students.Add(name);
                areHere.Add(false);
            }
        }

        // on ne peut pas modifier la valeur du nom; la valeur passe mais est protégée
        public void StudentHere(in string name)
        {
            if (!students.Contains(name)) return; //return vide: si n'a pas de valeur à retourner = raccourci pour aller à la fin de l'accolade de la fonction // on peut retourner rien dans un void 
            int index = students.IndexOf(name);
            areHere[index] = true;
        }

        // je veux savoir combien d'étudiants sont présent ce que je renvois en out
        // je retourne aussi si je peux commencer le cours (cad si j'ai au minimum la moitié de mes étudiants)
        public bool CheckCanBeginLesson(out int nbStudentHere)
        {
            // le out est obligé d'être initialisé, ici on a mis la valeur 0
            nbStudentHere = 0;
            foreach (bool isHere in areHere)
            {
                if (isHere) nbStudentHere++;
            }
            return nbStudentHere * 2 >= students.Count;
        }
    }
}
