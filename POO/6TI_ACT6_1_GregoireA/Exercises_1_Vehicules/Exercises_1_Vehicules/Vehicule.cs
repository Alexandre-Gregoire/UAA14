using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_1_Vehicules
{
    internal class Vehicule
    {
		protected string _modele;
        protected string _marque;
        protected string _couleur;
        protected decimal _prix;

		public decimal Prix
		{
			get { return _prix; }
			set { _prix = value; }
		}


		public string Couleur
        {
			get { return _couleur; }
			
		}

		public string Marque
        {
			get { return _marque; }
			
		}

		public string Modele
		{
			get { return _modele; }
			set { _modele = value; }
		}
		public Vehicule(string marque, string couleur, string modele, decimal prix)
		{
			_prix = prix;
			_modele = modele;
			_couleur = couleur;
			_marque = marque;
		}
		public virtual string affiche()
		{
			return " | Modele : " + _modele + " | Marque : " + _marque + " | Couleur : " + _couleur + " | Prix : " + _prix.ToString();
		}
	}
}
