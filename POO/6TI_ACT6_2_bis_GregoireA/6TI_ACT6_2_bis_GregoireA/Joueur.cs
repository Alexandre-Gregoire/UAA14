using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_2_bis_GregoireA
{
    internal class Joueur
    {
		private int _argent;
		private string _pseudo;

		public string Pseudo
		{
			get { return _pseudo; }
			set { _pseudo = value; }
		}

		public int Argent
        {
			get { return _argent; }
			set { _argent = value; }
		}
		
		public Joueur(int argent,string pseudo)
		{
			_argent = argent;
			_pseudo = pseudo;
		}
	}
}
