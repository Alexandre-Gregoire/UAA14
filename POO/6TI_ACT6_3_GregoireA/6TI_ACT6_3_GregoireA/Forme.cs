using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_3_GregoireA
{
    internal class Forme
    {
		private protected string _couleur;

		public string Couleur
		{
			get { return _couleur; }
			set { _couleur = value; }
		}
		public Forme(string couleur)
		{
			_couleur = couleur;
		}
		public virtual string affiche()
		{
			return "la couleur est de :" + _couleur;
		}
		public virtual int CalculeSurface()
		{
			return 0;
		}
		public virtual int CalculePerimetre()
		{
			return 0;
		}

	}
}
