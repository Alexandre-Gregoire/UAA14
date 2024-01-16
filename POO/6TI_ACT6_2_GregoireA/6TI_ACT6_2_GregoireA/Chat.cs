using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TI_ACT6_2_GregoireA
{
    internal class Chat : Animal
    {
        public Chat(bool concour, int taille, string numeroDePuce, string dateDeNaissance, string nom) : base(concour, taille, numeroDePuce, dateDeNaissance, nom)
        {
        }
        public string Miauler()
        {
            return "Miaou ! Miaou !";
        }
        public string Ronronner()
        {
            return "Ron-Ron";
        }
    }
}
