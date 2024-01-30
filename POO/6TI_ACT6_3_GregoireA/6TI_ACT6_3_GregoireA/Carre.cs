using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_3_GregoireA
{
    internal class Carre : Forme
    {
        private int _cote;

        public int Cote
        {
            get { return _cote; }
            
        }

        public Carre(string couleur,int cote) : base(couleur) 
        { 
            _cote = cote;
        }
        public override string affiche()
        {
            return "la couleur est de :" + _couleur + " | La surface est de : " + CalculeSurface().ToString() + " | Le perimetre est de : " + CalculePerimetre().ToString();
        }
        public override int CalculeSurface()
        {
            return Cote*Cote;
        }
        public override int CalculePerimetre()
        {
            return Cote*4;
        }
    }
}
