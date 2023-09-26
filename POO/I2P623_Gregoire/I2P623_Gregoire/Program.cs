// See https://aka.ms/new-console-template for more information
using I2P623_Gregoire;

FeuDeSignalisation feux1 = new FeuDeSignalisation("1001",1);
FeuDeSignalisation feux2 = new FeuDeSignalisation("007", 1);

string reponse;
bool onOff = true;

Console.WriteLine("Etat des feux :\n------------");
reponse = feux1.AfficheEtat(feux1.Identifiant,feux1.Couleur);
Console.WriteLine(reponse);
reponse = feux2.AfficheEtat(feux2.Identifiant, feux2.Couleur);
Console.WriteLine(reponse);
Console.WriteLine("Changement d'état :\n------------");
for (int i = 0; i < 5; i++)
{
    feux1.Couleur = feux1.change(feux1.Couleur);
    reponse = feux1.AfficheEtat(feux1.Identifiant, feux1.Couleur);
    Console.WriteLine(reponse);
}
Console.WriteLine("faire passer le 007 à orange : ");
feux1.Couleur = 2;
reponse = feux1.AfficheEtat(feux1.Identifiant, feux1.Couleur);
Console.WriteLine(reponse);

Console.WriteLine("Feu clignotant : \n------------");
for (int i = 0; i < 7; i++)
{
    onOff = feux2.Clignote(onOff, feux2.Identifiant);
    feux1.Couleur = feux2.change(feux2.Couleur);


}


