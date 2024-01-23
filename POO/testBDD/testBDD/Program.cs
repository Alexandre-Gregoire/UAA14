using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
namespace testBDD
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] donnees = new string[5];
            DataSet immoUsers;
            MethodesDuModele MonModel = new MethodesDuModele();
            Console.WriteLine("Liste des utilisateurs");
            Console.WriteLine("----------------------");

            
            if (MonModel.ChercheUtilisateurs(out immoUsers))
            {
                string listeUser = MonModel.AfficheDataUsers(immoUsers);
                Console.WriteLine(listeUser);
            }
            else
            {
                Console.WriteLine("Pb lors de la lecture des données");
            }
        }
        
    }
}