using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ACT_7_COURSE_DE_LEVRIERS_GregoireA
{
    class Parieur
    {
		private string _nom;
		private Pari _monPari;
		private int _cash;
		private TextBlock _textBlockEtatPari;

		
		public TextBlock TextBlockEtatPari
		{
			get { return _textBlockEtatPari; }
			set { _textBlockEtatPari = value; }
		}

		public int Cash
		{
			get { return _cash; }
			set { _cash = value; }
		}

		public Pari MonPari
		{
			get { return _monPari; }
			set { _monPari = value; }
		}

		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

	}
}
