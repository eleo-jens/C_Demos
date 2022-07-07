using System;

namespace Demo_Enumeration
{
    class Program
    {

        static void Main(string[] args)
        {
            TrafficLight feu1 = new TrafficLight();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(feu1.currentColor);
                feu1.ChangeColor();
                switch (feu1.currentColor)
                {
                    case TrafficLightColor.Red:
                        Console.WriteLine("Reste à l'arret");
                        break;
                    case TrafficLightColor.Green:
                        Console.WriteLine("Avance");
                        break;
                    case TrafficLightColor.Orange:
                        Console.WriteLine("Freine");
                        break;
                    default:
                        break;
                }

            }
            // classe Enum est une classe qui permet de manipuler nos énumérations et il faut donc indiquer qu'elle énumération on veut manipuler avec typeof ou <> (la généricité)
            string[] trafficLightColorNames = Enum.GetNames<TrafficLightColor>();
            //string[] trafficLightColorNames = Enum.GetNames(typeof(TrafficLightColor));

            TrafficLightColor[] enumColors = Enum.GetValues<TrafficLightColor>();

            int nbColor = trafficLightColorNames.Length;
            Console.WriteLine($"\nUn feu peut avoir {nbColor} couleurs: ");
            foreach (string colorName in trafficLightColorNames){
                Console.WriteLine(colorName);
            }

            #region Parse
            //Console.WriteLine("\nLe feu est de quelle couleur ?");
            //string input = Console.ReadLine();
            ////Enum.Parse donne un type objet donc il faut le caster dans le type spécifique de l'enum
            ////TrafficLightColor colorUser = (TrafficLightColor)Enum.Parse(typeof(TrafficLightColor), input);
            //TrafficLightColor colorUser = Enum.Parse<TrafficLightColor>(input);

            //if (feu1.currentColor == colorUser) Console.WriteLine("Pas d'accident, le feu est correct");
            //else Console.WriteLine("Attention danger sur la route");
            #endregion

            #region TryParse
            Console.WriteLine("De quelle couleur est le feu ?");
            TrafficLightColor colorUser;
            string input = Console.ReadLine();
            while (!Enum.TryParse<TrafficLightColor>(input, out colorUser))
            {
                Console.WriteLine("De quelle couleur est le feu ?");
                input = Console.ReadLine();
            }
            if (feu1.currentColor == colorUser) Console.WriteLine("Pas d'accident, le feu est correct");
            else Console.WriteLine("Attention danger sur la route");
            #endregion
        }
    }
}
