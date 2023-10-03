using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexandre_ACT_2_POO_6ti
{
    internal class Cercle
    {
		private double _rayon;

        public double rayon
        {
			get { return _rayon; }
			set { _rayon = value; }
		}
		public Cercle(double rayon)
		{
			_rayon = rayon;
		}
		public double CalculeAire()
		{
			return Math.Round(Math.PI * _rayon * _rayon,2);
		}
        public double CalculePerimetre()
        {
            return Math.Round(Math.PI * (_rayon * 2),2);
        }
        public string AfficheCaracteristiques()
        {
            return "Le cercle de rayon : " + _rayon + " a une aire de : " + CalculeAire() + " et un perimetre de : " + CalculePerimetre();
        }
    }
}
