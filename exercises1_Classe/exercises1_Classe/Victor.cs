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
        private int _age;
        private bool _enOrdreDeVaccin;
        private bool _puce;
        private string _genre;
        private bool _sterilise;
        private bool _dresse;


        public Victor(string nom, string race, int age, bool enOrdreDeVaccin, bool puce, string genre, bool sterilise, bool dresse)
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
            string chaine = "Nom : " + _nom + "// Race : " + _race + "Age : "+ _age +" // Vaccin : "+ _enOrdreDeVaccin +" // Puce : "+ _puce +" // Genre : "+ _genre +" // Sterilisé : "+ _sterilise +" // dresse : " + _dresse;
            return chaine;
        }
        public void Promener() {
            Console.WriteLine("Votre victor a été promener");
        }
        public void Vacciner()
        {
            Console.WriteLine("Votre victor a été vacciner");
        }
        public void Dresser()
        {
            Console.WriteLine("Votre victor a été dresser");
        }
    }
}
