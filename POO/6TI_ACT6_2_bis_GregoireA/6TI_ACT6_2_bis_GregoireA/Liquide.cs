using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_2_bis_GregoireA
{
    internal class Liquide
    {
		private double _pourcentageAlcool;
		private string _nom;

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

		public double PourcentageAlcool
        {
			get { return _pourcentageAlcool; }
			set { _pourcentageAlcool = value; }
		}

		public Liquide(double pourcentageAlcool,string nom)
		{
			_pourcentageAlcool = pourcentageAlcool;
			_nom = nom;
		}
	}
}
