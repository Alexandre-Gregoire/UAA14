using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_1_Vehicules
{
	internal class Velo : Vehicule
	{
		private string _type;
		private bool _estElectrique;

		public bool EstElectrique
		{
			get { return _estElectrique; }
			set { _estElectrique = value; }
		}

		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public Velo(string type, bool electrique, string marque, string couleur, string modele, decimal prix) : base(marque, couleur, modele, prix)
		{
			_type = type;
			_estElectrique = electrique;
		}
        public override string affiche()
        {
            return " | Type : " + Type + " | Electrique : " + EstElectrique + " | Modele : " + Modele + " | Marque : " + Marque + " | Couleur : " + Couleur + " | Prix : " + Prix.ToString();
        }

    }
}
