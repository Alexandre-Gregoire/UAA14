using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_2_bis_GregoireA
{
    internal class Bar
    {
		private int _capacite;
		private int[] _stock;
		private Bouteille[] _typeStock;

		public Bouteille[] TypeStock
		{
			get { return _typeStock; }
			set { _typeStock = value; }
		}

		public int[] Stock
		{
			get { return _stock; }
			set { _stock = value; }
		}

		public int Capacite
		{
			get { return _capacite; }
			set { _capacite = value; }
		}

	}
}
