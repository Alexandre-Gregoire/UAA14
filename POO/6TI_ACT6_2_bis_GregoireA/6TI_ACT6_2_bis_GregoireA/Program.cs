namespace _6TI_ACT6_2_bis_GregoireA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            Joueur player = new Joueur(50, "lodiren");
            Recette[] recettes = new Recette[25];
            Console.WriteLine("Hello et bienvenue dans ce bar Vous posseder : "+ player.Argent.ToString() +"$\nque desirez vous faire ? : \n\n1.Créer un cocktail\n2.Voir la liste des recettes\n3.Voir les stocks de diferent ingredients\n4.Aller chercher une bouteille dans la cave\n5.\n");

            reponse = Console.ReadLine();
            switch (reponse)
            {
                case "1":

                    Console.WriteLine("quel cocktail voulez vous faire ?");
                    for (int i = 0; i < recettes.Length; i++)
                    {
                        if (recettes[i] != null)
                        {
                            Console.WriteLine(i.ToString() + ". " + recettes[i].Nom);
                        }
                        else
                        {
                            Console.WriteLine((i+1).ToString() + ". aucune recette atribuée");
                        }
                        
                    }

                    break;
                default:
                    break;
            }




        }
    }
}