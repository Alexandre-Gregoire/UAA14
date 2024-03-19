using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_2_bis_GregoireA
{
    internal class Bouteille
    {
		private Liquide _type;
		private int _quantite;

		public int Quantite
		{
			get { return _quantite; }
			set { _quantite = value; }
		}

		public Liquide Type
		{
			get { return _type; }
			set { _type = value; }
		}
		public Bouteille(Liquide type, int quantite)
		{
			_type = type;
			_quantite = quantite;
		}

	}
}
