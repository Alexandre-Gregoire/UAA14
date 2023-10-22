using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Alexandre_ACT_2_POO_6ti
{
    internal class NombreComplexe
    {
		private double _reel;
		private double _imaginaire;

		public double Imaginaire
        {
			get { return _imaginaire; }
			set { _imaginaire = value; }
		}

		public double Reel
        {
			get { return _reel; }
			set { _reel = value; }
		}

        public NombreComplexe(double reelle, double imaginaire)
        {
            _reel = reelle;
            _imaginaire = imaginaire;
        }
        public void Ajoute(NombreComplexe nombreComplexe)
		{
            _reel += nombreComplexe.Reel;
            _imaginaire += nombreComplexe.Imaginaire;
            
        }
		public double CalculeModule()
		{
			return Math.Round(Math.Sqrt(Math.Pow(Imaginaire, 2) + Math.Pow(Reel, 2)),2);

        }
		public string AfficheComplexe()
		{
			return "(" + _reel + "," + _imaginaire + ")";
		}


	}
}
