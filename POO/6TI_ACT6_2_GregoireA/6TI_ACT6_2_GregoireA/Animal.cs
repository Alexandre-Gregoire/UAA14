using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_2_GregoireA
{
    internal class Animal
    {
		private protected string _nom;
		private protected string _dateDeNaissance;
		private protected string _numeroDePuce;
		private protected int _taille;
		private protected bool _concour;

		public bool Concour
		{
			get { return _concour; }
		}

		public int Taille
		{
			get { return _taille; }
			set { _taille = value; }
		}


		public string NumeroDePuce
		{
			get { return _numeroDePuce; }
			set { _numeroDePuce = value; }
		}


		public string DateDeNaissance
		{
			get { return _dateDeNaissance; }
		}

		public string Nom
		{
			get { return _nom; }
		}

		public Animal(bool concour, int taille, string numeroDePuce, string dateDeNaissance, string nom)
		{
			_concour = concour;
			_taille = taille;
			_numeroDePuce = numeroDePuce;
			_dateDeNaissance = dateDeNaissance;
			_nom = nom;
		}
		public string dormir()
		{
			return "il dort";
		}
        public string manger()
        {
            return "il mange";
        }
        public virtual string affiche()
		{
            return " | Concours : " + _concour.ToString() + " | Taille : " + _taille.ToString() + "cm | Numéro de Puce : " + _numeroDePuce + " | Date de Naissance : " + _dateDeNaissance + " | Nom : " + _nom;
        }
	}
}
