using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2P623_Gregoire
{
    internal class FeuDeSignalisation
    {
		private int _couleur = 1;
		private string _identifiant;


		public int Couleur
        {
			get { return _couleur; }
			set { _couleur = value; }
		}

		public string Identifiant
        {
			get { return _identifiant; }
			set { _identifiant = value; }
		}

        public FeuDeSignalisation(string identifiant, int couleur)
        {
			_couleur = couleur;
            _identifiant = identifiant;
        }

        public int change(int couleur) { 
			if (couleur == 3)
			{
                couleur = 1;
            }
			else
			{
                couleur++;
			}
			
			
			return couleur;
		}
		public bool Clignote(bool onOff, string identifiant)
		{
			if (onOff)
			{
				Console.WriteLine("le feu numero : " + identifiant + "est allumé");
				onOff = false;
			}
			else
			{
                Console.WriteLine("le feu numero : " + identifiant + "est éteint");
				onOff = true;
            }
			return onOff;
        }

		public string AfficheEtat(string identifiant, int couleur)
		{
			string reponse;
			if (couleur == 1)
			{
                reponse = "le feux numero : " + identifiant + " est : rouge";
            }
			else if (couleur == 2)
			{
                reponse = "le feux numero : " + identifiant + " est : orange";
            }
			else
			{
                reponse = "le feux numero : " + identifiant + " est : vert";
            }
			

			return reponse;
		}

    }
}



/*
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */