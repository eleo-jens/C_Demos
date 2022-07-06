using System;

namespace Demo_Recursivite
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogging parcours1;
            parcours1.Courir(10);
            
        }
    }

    public struct Jogging
    {
        public void Courir(int distance)
        {
            distance = distance - 1;
            Console.WriteLine($"Il me reste {distance} m à courir");
            if (distance == 0) return; // permet de mettre fin à cette fonction récursive sinon ca crée un boucle infinie
            this.Courir(distance);
        }
    }

}
