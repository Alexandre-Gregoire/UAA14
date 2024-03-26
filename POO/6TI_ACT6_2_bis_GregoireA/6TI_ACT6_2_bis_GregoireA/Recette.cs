using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_2_bis_GregoireA
{
    internal class Recette
    {
		private string _nom;
		private int[] _quantite;
		private Liquide[] _type;

		public Liquide[] Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public int[] Quantite
		{
			get { return _quantite; }
			set { _quantite = value; }
		}

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

		public Recette(string nom, int[] quantite,Liquide[] type)
		{
			_nom = nom;
			_quantite = quantite;
			_type = type;
		}

	}
}
