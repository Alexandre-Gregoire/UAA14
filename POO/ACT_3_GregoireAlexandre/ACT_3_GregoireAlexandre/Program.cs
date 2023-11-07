// See https://aka.ms/new-console-template for more information
using ACT_3_GregoireAlexandre;

string restart = "o";
Elephant Zazou = new Elephant("Zazou",82);
Elephant Titi = new Elephant("Titi", 100);

while (restart == "o")
{
    Console.WriteLine("Bienvenue dans cet échange d'éléphants");
    Console.WriteLine("Tapez : ");
    Console.WriteLine("1 : pour afficher les informations de Zazou");
    Console.WriteLine("2 : pour Titi");
    Console.WriteLine("3 : pour les échanger");
    Console.WriteLine("4 : pour voir le transfert d'un message de Zazou à Titi");
    Console.WriteLine("5 : pour réviser la notion de tableaux et l'appliquer à des objets");
    string reponse = Console.ReadLine();
    switch (reponse)
    {
        case "1":
            Console.WriteLine(Zazou.AfficheQuiJeSuis());
            break;
        case "2":
            Console.WriteLine(Titi.AfficheQuiJeSuis());
            break;
        case "3":
            Elephant tempo = Zazou;
            Zazou = Titi;
            Titi = tempo;

            break;
        case "4":
            Zazou.EnvoieMessage("Coucou Titi !", Titi);
            break;
        case "5":
            Elephant[] tabElephant = new Elephant[7];
            tabElephant[0] = Zazou;
            tabElephant[1] = Titi;
            tabElephant[2] = new Elephant("Victor", 3000000000);
            tabElephant[3] = new Elephant("Aymeric", 80);
            tabElephant[4] = new Elephant("sefedin", 58);
            tabElephant[5] = new Elephant("Nathan", 40);
            tabElephant[6] = new Elephant("Yasin", 65);
            Elephant maxElephant = tabElephant[0];
            for (int i = 0; i < tabElephant.Length; i++)
            {
                if (tabElephant[i].TailleOreilles > maxElephant.TailleOreilles)
                {
                    maxElephant = tabElephant[i];
                }

            }
            Console.WriteLine(maxElephant.Nom + " a les bien grosse oreilles d'une taille de : " + maxElephant.TailleOreilles);
            break;
    }
    Console.WriteLine("Voulez vous restart ? o = oui / autre = non");
    restart = Console.ReadLine();
}


