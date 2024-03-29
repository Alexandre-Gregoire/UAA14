using System.Security.AccessControl;
using System.Xml.Linq;

namespace _6TI_ACT6_2_bis_GregoireA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Liquide> liquidesList = new List<Liquide>();
            List<int> quantiteList = new List<int>();

            string reponse;
            string reponseUtilisateur;
            int toInt = 0;
            int ModifQuelRecette = 0;
            Joueur player = new Joueur(50, "lodiren");
            Recette[] recettes = new Recette[25];
            Liquide[] liquides = new Liquide[50];
            liquides = CreerLiquide(liquides);
            Console.WriteLine("Hello et bienvenue dans ce bar Vous posseder : " + player.Argent.ToString() + "$\nque desirez vous faire ? : \n\n1.Créer un cocktail\n2.Voir la liste des recettes\n3.Voir les stocks de diferent ingredients\n4.Aller chercher une bouteille dans la cave\n5.\n");

            reponse = Console.ReadLine();
            switch (reponse)
            {
                case "1":

                    Console.WriteLine("quel cocktail voulez vous faire ?");
                    AfficherTabRecette(recettes);
                    break;
                case "5":
                    AfficherTabRecette(recettes);
                    Console.WriteLine("quelle recette voulez vous modifier ?");
                    reponseUtilisateur = Console.ReadLine();
                    if (int.TryParse(reponseUtilisateur,out toInt))
                    {
                        if (toInt > 25 || toInt < 1)
                        {
                            Console.WriteLine("Entrez une valeur valide");
                        }
                        else
                        {
                            Console.WriteLine("modifications de la recette n°" + toInt.ToString());
                            ModifQuelRecette = toInt;
                            AfficherTabLiquide(liquides);
                            Console.WriteLine("Entrez chaque numero de liquide puis la quantitée en cl et appuyer sur enter (EXIT pour arreter)");
                            while (reponseUtilisateur != "EXIT")
                            {
                                reponseUtilisateur = Console.ReadLine();
                                if (int.TryParse(reponseUtilisateur, out toInt))
                                {
                                    if (toInt > 50 || toInt < 1)
                                    {
                                        Console.WriteLine("Entrez une valeur valide");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ajout de " + liquides[toInt].Nom + " Entrez maintenant la quantitée");
                                        liquidesList.Add(liquides[toInt]);

                                        reponseUtilisateur = Console.ReadLine();
                                        if (int.TryParse(reponseUtilisateur, out toInt))
                                        {
                                            if (toInt > 50 || toInt < 1)
                                            {
                                                Console.WriteLine("Entrez une valeur valide");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ajout de " + toInt + "cl. Entrez maintenant Exit ou recommencer");
                                                quantiteList.Add(toInt);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Entrez une valeur valide");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Entrez une valeur valide");
                                }
                                
                            }
                            if (true)
                            {

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrez une valeur valide");
                    }


                    break;
                default:
                    break;
            }




        }




        static void AfficherTabRecette(Recette[] recettes)
        {
            for (int i = 0; i < recettes.Length; i++)
            {
                if (recettes[i] != null)
                {
                    Console.WriteLine((i+1).ToString() + ". " + recettes[i].Nom);
                }
                else
                {
                    Console.WriteLine((i + 1).ToString() + ". aucune recette atribuée");
                }

            }
        }
        static void AfficherTabLiquide(Liquide[] liquides)
        {
            for (int i = 0; i < liquides.Length; i++)
            {
                    Console.WriteLine((i + 1).ToString() + ". " + liquides[i].Nom + "  % : " + liquides[i].PourcentageAlcool.ToString());
            }
        }

        static Liquide[] CreerLiquide(Liquide[] liquides)
        {
            liquides[0] = new Liquide(40, "Vodka Absolut");
            liquides[1] = new Liquide(12, "Rhum Havana Club");
            liquides[2] = new Liquide(0, "Sprite");
            liquides[3] = new Liquide(5, "Bière Heineken");
            liquides[4] = new Liquide(18, "Tequila Patrón");
            liquides[5] = new Liquide(20, "Gin Bombay Sapphire");
            liquides[6] = new Liquide(0, "Fanta Orange");
            liquides[7] = new Liquide(30, "Cognac Hennessy");
            liquides[8] = new Liquide(8, "Vin Château Lafite Rothschild");
            liquides[9] = new Liquide(0, "Coca-Cola");
            liquides[10] = new Liquide(10, "Whisky Glenfiddich");
            liquides[11] = new Liquide(0, "Pepsi");
            liquides[12] = new Liquide(33, "Vodka Belvedere");
            liquides[13] = new Liquide(15, "Rhum Captain Morgan");
            liquides[14] = new Liquide(0, "7 Up");
            liquides[15] = new Liquide(22, "Tequila Don Julio");
            liquides[16] = new Liquide(6, "Vin Château Margaux");
            liquides[17] = new Liquide(0, "Schweppes");
            liquides[18] = new Liquide(14, "Gin Hendrick's");
            liquides[19] = new Liquide(0, "Mirinda");
            liquides[20] = new Liquide(28, "Cognac Rémy Martin");
            liquides[21] = new Liquide(3, "Bière Budweiser");
            liquides[22] = new Liquide(0, "Tonic Water Schweppes");
            liquides[23] = new Liquide(0, "Fanta Lemon");
            liquides[24] = new Liquide(20, "Whisky Jack Daniel's");
            liquides[25] = new Liquide(0, "Sprite Zero");
            liquides[26] = new Liquide(5, "Vin Beaujolais");
            liquides[27] = new Liquide(0, "Coca-Cola Zero");
            liquides[28] = new Liquide(37, "Vodka Grey Goose");
            liquides[29] = new Liquide(0, "Fanta Mango");
            liquides[30] = new Liquide(0, "Sprite Cranberry");
            liquides[31] = new Liquide(30, "Rhum Bacardi");
            liquides[32] = new Liquide(0, "Schweppes Agrumes");
            liquides[33] = new Liquide(10, "Tequila Jose Cuervo");
            liquides[34] = new Liquide(0, "Schweppes Tonic");
            liquides[35] = new Liquide(0, "Sprite Tropical");
            liquides[36] = new Liquide(17, "Gin Tanqueray");
            liquides[37] = new Liquide(0, "Schweppes Mojito");
            liquides[38] = new Liquide(40, "Cognac Courvoisier");
            liquides[39] = new Liquide(0, "Fanta Exotic");
            liquides[40] = new Liquide(12, "Vodka Stolichnaya");
            liquides[41] = new Liquide(0, "Fanta Grape");
            liquides[42] = new Liquide(9, "Whisky Jameson");
            liquides[43] = new Liquide(0, "Schweppes Ginger Ale");
            liquides[44] = new Liquide(32, "Rhum Malibu");
            liquides[45] = new Liquide(0, "Fanta Apple");
            liquides[46] = new Liquide(13, "Gin Beefeater");
            liquides[47] = new Liquide(0, "Schweppes Indian Tonic");
            liquides[48] = new Liquide(35, "Cognac Martell");
            liquides[49] = new Liquide(0, "Sprite Cherry");
            
            return liquides;
        }
    }
}