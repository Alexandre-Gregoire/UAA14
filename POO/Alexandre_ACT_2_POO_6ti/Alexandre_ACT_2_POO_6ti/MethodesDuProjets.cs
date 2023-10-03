using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexandre_ACT_2_POO_6ti
{
    internal class MethodesDuProjets
    {
        public void LireReel(string question, out double n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!double.TryParse(nUser, out n))
            {
                Console.WriteLine("Attention ! vous devez taper un nombre réel !");
                nUser = Console.ReadLine();
            }
        }

    }
}
