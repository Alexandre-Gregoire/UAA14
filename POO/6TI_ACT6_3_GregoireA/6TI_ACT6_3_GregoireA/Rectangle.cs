using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_3_GregoireA
{
    internal class Rectangle : Forme
    {
        private int _largeur;
        private int _longueur;

        public int Longueur
        {
            get { return _longueur; }
        }

        public int Largeur
        {
            get { return _largeur; }

        }

        public Rectangle(string couleur, int largeur,int longuer) : base(couleur)
        {
            _largeur = largeur;
            _longueur = longuer;
        }
        public override string affiche()
        {
            return "la couleur est de :" + _couleur + " | La surface est de : " + CalculeSurface().ToString() + " | Le perimetre est de : " + CalculePerimetre().ToString();
        }
        public override int CalculeSurface()
        {
            return Longueur * Largeur;
        }
        public override int CalculePerimetre()
        {
            return (Largeur * 2 )+ (Longueur * 2);
        }
    }
}
