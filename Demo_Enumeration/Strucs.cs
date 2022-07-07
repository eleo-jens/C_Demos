using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Enumeration
{
    public struct TrafficLight
    {
        // dans la structure on ne peut pas donner de valeur à nos variables
        public TrafficLightColor currentColor; 

        // ma méthode a acces au membre au dessus, pas besoin de le passer en parametre
        public void ChangeColor()
        {
            // raccourci pour switch et enumeration: si on veut afficher toutes les options, dans les parentheses: faire enter et fleche en bas pour sortir de la parenthese pour que les cases s'autoremplissent
            switch (this.currentColor)
            {
                case TrafficLightColor.Red:
                    this.currentColor = TrafficLightColor.Green; 
                    break;
                case TrafficLightColor.Green:
                    this.currentColor = TrafficLightColor.Orange;
                    break;
                case TrafficLightColor.Orange:
                    this.currentColor = TrafficLightColor.Red;
                    break;
                default:
                    this.currentColor = TrafficLightColor.Red;
                    break;
            }
        }

        // méthode raccourcie (opération mathématique est généralement plus légère pour l'opération)
        //public void ChangeColor()
        //{
        //    // modulo du nombre d'énumération pour faire le changement sans depasser le 3
                //0  : 1 % 3 = 1
                //1 : 2 % 3 = 2
                //2 : 3 % 3 = 0
        //    this.currentColor = (TrafficLightColor)((int)(this.currentColor + 1) % 3);
        //}
    }
}
