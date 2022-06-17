using System;
using System.Threading;

namespace Demo_Variables
{
    class Program
    {
        //Variable membre / champs: variable déclarée dans une class ou une structure
        double racineCarreDeDeux = 1.41;
        //float et double : valeur d'approximation a peut pres à la bonne valeur
        //decimal : un entier auquel je rajoute une virgule au bon emplacement: pour les calculs monétaires ex: je prends 127 et je mets une virgule apres 1

        static void Main(string[] args)
        {

            //toutes les variables de la méthode sont des variables locales
            int unEntier; //Declaration: création d'une zone mémoire dans le stack
            unEntier = 42; //Initialisation: affectation de la premiere valeur d'une variable
                           //si variable structuelle, définie dans la stack
                           //si variable référentielle, définie dans la heap
            bool isOK = true;  //Déclaration et initialisation en même temps (obligatoire pour les constantes)
            char caractere1, caractere2, caractere3; //Déclaration multiple: des variables d'un même type peuvent etre déclarées sur une seule ligne

            //MAUVAISE PRATIQUE: déclaration et initialisation multiple: compliquée à la lecture
            short petit1 = 1, petit2 = 2, petit3; 

            //une constante est une variable (membre ou locale) qui doit etre initialisée et donc la valeur ne change jamais ! 
            const string MEILLEUR_PROF = "Samuel"; //entier de petite taille -32768 à 32767;

            ushort ok = 456;

            //DateTime:
            //3 paramètres: années, mois, jour
            //6 paramètres: années, mois, jour, heure, minute, seconde
            DateTime naissance_du_meilleur_prof = new DateTime(1987,9,27,10,35,22); //27 septembre 1987 à 10h35 min et 22 secondes
            DateTime today = DateTime.Now; //Donne la date de l'instantT quand on crée la variable, la date de notre ordi 
            Console.WriteLine(today);
            // systeme pour faire plusieurs taches à la fois; ici on lui dit de patienter 5 secondes - on doit utiliser "using System.Threading;"
            Thread.Sleep(5000);
            Console.WriteLine(today);
            today = DateTime.Now; //récupère la date actuelle de votre machine et doit etre réaffectée continuellement pour avoir la date de l'instantT
            Console.WriteLine(today);

            /* différents format de nommage:
             UpperCamelCase ou Upper_Camel_Case: pour les objets complexe (class, struct, methode)
             lowerCamelCase ou lower_camel_case: pour les variables
             UPPER_CASE: pour les constantes

             caractères autorisés alphanumérique + _ sauf pour le premier caractère qui ne peut pas être un nombre
             _toto => OK
             unCaractere => OK
             1caractere => NON
             */

           //Type réferentiel: string ou object peuvent avoir un Null
           string message = null; // il faut l'initialiser d'office car on est dans la methode
           object o = null;

           //Type structurel : les 14 types structurels doivent avoir le terme Nullable<...> ou le ? pour accépter la valeur null 
           Nullable<int> i = null; //c'est un nullable de int : PAS un int
           int? i = null;
        }
    }
}
