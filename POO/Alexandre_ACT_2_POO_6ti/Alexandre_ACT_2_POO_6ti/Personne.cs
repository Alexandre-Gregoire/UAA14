﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexandre_ACT_2_POO_6ti
{
    internal class Personne
    {
		private double _argent;
		private string _nom;

		public string Nom
		{
			get { return _nom; }
		}

		public double Argent
		{
			get { return _argent; }
			set { _argent = value; }
		}

		public Personne(string nom,double argent ) { 
			_argent = argent;
			_nom = nom;
		}
		public string AffichagePorteMonnaie()
		{
			return _nom + " a " + _argent + "€ dans son porte monnaie";
		}
		public bool TransfererArgent(double argent)
		{
			if (_argent < argent)
			{
				return false;
			}
			else
			{
				_argent -= argent;
				return true;
			}
		}
		public void AjouterArgent(double argent)
		{
			_argent += argent;
		}

	}
}
