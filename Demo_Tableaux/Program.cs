using System;

namespace Demo_Tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            // tableau à 1 dimension
            string[] jour_semaine = { "Lu", "Ma", "Me", "Je", "Ve", "Sa", "Di" };
            //Les indices du tableau = 0     1      2     3     4     5     6      

            // Indiquez que nous sommes lundi
            Console.WriteLine($"Aujourd'hui nou sommes {jour_semaine[0]}");

            //tableau à 2 dimensions/ 2 axes 
            string[,] jour_semaine_multilangue =
            {
                { "Lu", "Ma", "Me", "Je", "Ve", "Sa", "Di" },
            // 0:   0     1     2    3     4      5     6
                { "Ma", "Di", "Wo", "Di", "Vr", "Za", "Zo" },
            // 1:   0     1     2    3     4      5     6
                { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su" }
            // 2:   0     1     2    3     4      5     6
            };

            //Nous sommes mardi en anglais
            Console.WriteLine($"Tommorow will be {jour_semaine_multilangue[2,1]}");

            //tableau à 3 dimensions/ 3 axes avec le format, la langue et les jours
            string[,,] jour_semaine_multiformat =
            {
                {
                    { "Lu", "Ma", "Me", "Je", "Ve", "Sa", "Di" },
                // 0:   0     1     2    3     4      5     6
                    { "Ma", "Di", "Wo", "Di", "Vr", "Za", "Zo" },
                // 1:   0     1     2    3     4      5     6
                    { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su" }
                // 2:   0     1     2    3     4      5     6
                },
                {
                    { "Lun", "Mar", "Mer", "Jeu", "Vee", "Sam", "Dim" },
                // 0:   0      1     2       3      4      5      6
                    { "Maan", "Din", "Woe", "Din", "Vri", "Zat", "Zon" },
                // 1:   0      1     2       3      4      5      6
                    { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" }
                // 2:   0      1     2       3      4      5      6
                },
                {
                    { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" },
                // 0:   0         1         2           3         4      5     6
                    { "Maandag", "Dindsadg", "Woensdag", "Dinsdag", "Vridag", "Zaturdag", "Zonday" },
                // 1:   0     1     2    3     4      5     6
                    { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" }
                // 2:   0     1     2    3     4      5     6
                },
            };

            // Afficher vendredi
            Console.WriteLine($"J'aime le {jour_semaine_multiformat[2,0,4]}");
        }
    }
}
