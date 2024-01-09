namespace Exercises_1_Vehicules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicule type1 = new Vehicule("marque0","couleur0","modele0",300);
            Velo velo1 = new Velo("tro bo", true,"marque2","couleur2","modele2",400);
            Console.WriteLine(type1.affiche());
            Console.WriteLine(velo1.affiche());

        }
    }
}