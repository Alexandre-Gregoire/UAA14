using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ACT_7_COURSE_DE_LEVRIERS_GregoireA
{
    class Chien
    {
        Random Alea = new Random();
        private int _numChien;
		private bool _gagne;
		private Image _imageChien;
		private int[] _positionCourante;

		public int[] PositionCourante
        {
			get { return _positionCourante; }
			set { _positionCourante = value; }
		}

		public Image ImageChien
        {
			get { return _imageChien; }
			set { _imageChien = value; }
		}

		public bool Gagne
		{
			get { return _gagne; }
			set { _gagne = value; }
		}

		public int NumChien
		{
			get { return _numChien; }
			set { _numChien = value; }
		}

		public void Court()
		{
			PositionCourante[0] += Alea.Next(1, 10);
		}

	}
}
