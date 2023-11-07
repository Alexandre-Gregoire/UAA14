using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ACT_3_GregoireAlexandre
{
    internal class Elephant
    {
		private string _nom;
		private uint _TailleOreilles;

		public uint TailleOreilles
        {
			get { return _TailleOreilles; }
			set { _TailleOreilles = value; }
		}

		public string Nom
        {
			get { return _nom; }
		}
		public Elephant(string nom, uint tailleOreilles)
		{
			_nom = nom;
			_TailleOreilles= tailleOreilles;
		}
		public string AfficheQuiJeSuis()
		{
			return "la taille des oreilles de " + Nom + " est de : " + TailleOreilles;
		}
        public void EcouteMessage(string message, Elephant quiDit)
        {
            Console.WriteLine(_nom + " a entendu un message \n" + quiDit._nom + " a dit : " + message);
        }
        public void EnvoieMessage(string message, Elephant quiRecoit)
        {
            quiRecoit.EcouteMessage(message, this);
        }


    }
}
