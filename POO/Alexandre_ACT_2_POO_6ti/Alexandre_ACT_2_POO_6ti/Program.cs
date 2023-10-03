// See https://aka.ms/new-console-template for more information
using Alexandre_ACT_2_POO_6ti;




double rayon;
MethodesDuProjets mesOutils = new MethodesDuProjets();
bool restart = true;
while (restart)
{
    mesOutils.LireReel("Entrez le rayon de votre cercle : ", out rayon);
    Cercle cercle1 = new Cercle(rayon);
    Cercle cercle2 = new Cercle(rayon / 2);
    Console.WriteLine(cercle1.AfficheCaracteristiques() + "\n--------------------------------------------------------------\nvoici mtn le cerlcle avec un rayon divisé en 2 : \n" + cercle2.AfficheCaracteristiques());





}