using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises1_Classe
{
    class Victor
    {
        // attributs privés par convention, leur nom commence par '_'
        private string _nom;
        private string _race;
        private uint _age;
        private bool _enOrdreDeVaccin;
        private bool _puce;
        private string _genre;
        private bool _sterilise;
        private bool _dresse;

        

        public uint Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public bool Vaccin
        {
            get { return _enOrdreDeVaccin; }
            set { _enOrdreDeVaccin = value; }
        }
        public bool Sterilisation
        {
            get { return _sterilise; }
            set { _sterilise = value; }
        }
        public bool Dresser
        {
            get { return _dresse; }
            set { _dresse = value; }
        }
        public bool Puce
        {
            get { return _puce; }
            set { _puce = value; }
        }


        public Victor(string nom, string race, uint age, bool enOrdreDeVaccin, bool puce, string genre, bool sterilise, bool dresse)
        {
            _nom = nom;
            _race = race;
            _age = age;
            _enOrdreDeVaccin = enOrdreDeVaccin;
            _puce = puce;
            _genre = genre;
            _sterilise = sterilise;
            _dresse = dresse;
        }

        public string AffichageVictor()
        {
            string chaine = "Nom : " + _nom + "// Race : " + _race + "// Age : "+ _age +" // Vaccin : "+ _enOrdreDeVaccin +" // Puce : "+ _puce +" // Genre : "+ _genre +" // Sterilisé : "+ _sterilise +" // dresse : " + _dresse;
            return chaine;
        }

    }
}
