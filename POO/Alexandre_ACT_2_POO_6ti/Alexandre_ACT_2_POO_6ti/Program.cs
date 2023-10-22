// See https://aka.ms/new-console-template for more information
using Alexandre_ACT_2_POO_6ti;

string reponse2;
double argentTempo;
string nom;
double argent;
double rayon;
double reel;
double imaginaire;
bool boucleArgent = true;
string reponse = "";
string choix;
MethodesDuProjets mesOutils = new MethodesDuProjets();
string restart = "o";
while (restart == "o")
{
    Console.WriteLine("Que voulez vous faire ?\n1 = calcule l'aire d'un cercle\n2 = calcule d'un nombre complexe\n3 = création de sandwich aléatoire\n4 = simulation de banque");
    choix = Console.ReadLine();
    if (choix == "1")
    {
        mesOutils.LireReel("Entrez le rayon de votre cercle : ", out rayon);
        Cercle cercle1 = new Cercle(rayon);
        Cercle cercle2 = new Cercle(rayon / 2);
        Console.WriteLine(cercle1.AfficheCaracteristiques() + "\n--------------------------------------------------------------\nvoici mtn le cerlcle avec un rayon divisé en 2 : \n" + cercle2.AfficheCaracteristiques());

    }
    else if (choix == "2")
    {
        mesOutils.LireReel("Que vaut la partie réel du complexe de départ ?\n", out reel);
        mesOutils.LireReel("Que vaut la partie imaginaire du complexe de départ ?\n", out imaginaire);

        NombreComplexe nombreComplexe1 = new NombreComplexe(reel, imaginaire);

        Console.WriteLine("Le premier compexe : " + nombreComplexe1.AfficheComplexe() + "a pour module : " + nombreComplexe1.CalculeModule());
        Console.WriteLine("Encodez un second nombre complexe\n");
        mesOutils.LireReel("Que vaut la partie réel du second complexe\n", out reel);
        mesOutils.LireReel("Que vaut la partie imaginaire du second complexe\n", out imaginaire);
        NombreComplexe nombreComplexe2 = new NombreComplexe(reel, imaginaire);
        Console.WriteLine("le second complexe est : " + nombreComplexe2.AfficheComplexe());
        nombreComplexe1.Ajoute(nombreComplexe2);
        Console.WriteLine("le premier complexe devient : " + nombreComplexe1.AfficheComplexe() + "après ajout du second");
    }
    else if (choix == "3")
    {
        Console.WriteLine("Bienvenue dans notre concepteur de sandwich!\nTaper sur enter pour générer un sandwich, appuyes sur une autre touche pour quittez");
        SandwichMaker sandwichMaker = new SandwichMaker();
        reponse = Console.ReadLine();
        while (reponse == "")
        {
            Console.Write(sandwichMaker.ComposeSandwich());
            reponse = Console.ReadLine();
        }
    }
    else if (choix == "4")
    {
        boucleArgent = true;
        Console.WriteLine("Bienvenue dans notre gestionnaire de porte monnaie !");
        Console.WriteLine("Premiere personne, quel est votre nom ? ");
        nom = Console.ReadLine();
        mesOutils.LireReel("Tapez une somme d'argent en euro\n", out argent);
        Personne personne1 = new Personne(nom, argent);
        Console.WriteLine("Deuxieme personne, quel est votre nom ? ");
        nom = Console.ReadLine();
        mesOutils.LireReel("Tapez une somme d'argent en euro\n", out argent);
        Personne personne2 = new Personne(nom, argent);
        Console.WriteLine("Troisieme personne, quel est votre nom ? ");
        nom = Console.ReadLine();
        mesOutils.LireReel("Tapez une somme d'argent en euro\n", out argent);
        Personne personne3 = new Personne(nom, argent);
        while (boucleArgent)
        {
            Console.WriteLine("que voulez vous faire ?\n1 = Ajoutez de l'argent\n2 = transférez de l'argent\n3 = affichez l'argent de tout le monde\n4 = arretez la simulation");
            reponse = Console.ReadLine();
            switch (reponse)
            {
                case "1":
                    Console.WriteLine("A qui voulez vous ajoutez de l'argent ?\n1 = " + personne1.Nom + "\n2 = " + personne2.Nom + "\n3 = " + personne3.Nom);
                    reponse = Console.ReadLine();
                    mesOutils.LireReel("combien voulez vous ajoutez ?", out argentTempo);
                    switch (reponse)
                    {
                        case "1":

                            personne1.AjouterArgent(argentTempo);
                            break;
                        case "2":
                            personne2.AjouterArgent(argentTempo);
                            break;
                        case "3":
                            personne3.AjouterArgent(argentTempo);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine(personne1.Nom + " sera la personne depuis qui l'argent sera retiré");
                    ;
                    Console.WriteLine("A qui voulez vous transférez de l'argent ?\n1 = " + personne1.Nom + "\n2 = " + personne2.Nom + "\n3 = " + personne3.Nom);
                    reponse = Console.ReadLine();
                    mesOutils.LireReel("combien voulez vous transférez ?\n", out argentTempo);
                    if (personne1.TransfererArgent(argentTempo))
                    {
                        switch (reponse)
                        {
                            case "1":
                                personne1.AjouterArgent(argentTempo);
                                break;
                            case "2":
                                personne2.AjouterArgent(argentTempo);
                                break;
                            case "3":
                                personne3.AjouterArgent(argentTempo);
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine(personne1.Nom + " n'a pas assez d'argent");
                    }
                    break;
                case "3":
                    Console.WriteLine(personne1.AffichagePorteMonnaie());
                    Console.WriteLine(personne2.AffichagePorteMonnaie());
                    Console.WriteLine(personne3.AffichagePorteMonnaie());
                    break;
                case "4":
                    boucleArgent = false;
                    break;
            }
        }

        Console.WriteLine("Voulez vous restart ? o = oui / autre = non");
        restart = Console.ReadLine();

    }

    
    




}