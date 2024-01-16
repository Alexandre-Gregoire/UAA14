using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_2_GregoireA
{
    internal class Lapin : Animal
    {
		private protected int _tailleOreilles;

		public int TailleOreilles
        {
			get { return _tailleOreilles; }
			set { _tailleOreilles = value; }
		}
        public Lapin(int tailleOreilles,bool concour, int taille, string numeroDePuce, string dateDeNaissance, string nom) : base(concour, taille, numeroDePuce, dateDeNaissance, nom)
        {
            _tailleOreilles = tailleOreilles;
        }
        public string Sauter()
        {
            return "Boing ! Boing !";
        }
        public override string affiche()
        {
            return " | Concours : " + _concour.ToString() + " | Taille : " + _taille.ToString() + "cm | Numéro de Puce : " + _numeroDePuce + " | Date de Naissance : " + _dateDeNaissance + " | Nom : " + _nom + " | Taille des Oreilles : " + _tailleOreilles;
        }
    }
}
