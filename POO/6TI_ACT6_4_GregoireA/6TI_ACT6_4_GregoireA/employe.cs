using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_4_GregoireA
{
    internal class employe
    {
		private string _prenom;
		private string _nom;
		private string _matricule;
		private string _dateNaissance;
		private double _salaire;

		public double Salaire
		{
			get { return _salaire; }
			set { _salaire = value; }
		}


		public string DateNaissance
		{
			get { return _dateNaissance; }
			
		}

		public string Matricule
		{
			get { return _matricule; }
			
		}

		public string Nom
		{
			get { return _nom; }
			
		}


		public string Prenom
		{
			get { return _prenom; }
			
		}
		
		public virtual string affiche()
		{
			return "";
		}
		public virtual string salaire()
		{
			return "";
		}

	}
}
