namespace exercises1_Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("generation de vos Victor");
            Victor victor1 = new Victor("victooooooooor", "humain pas gentil", 12, true, true,"male",true,false);
            Victor victor2 = new Victor("victaur", "humain vrm pas gentil", 14, true, true, "male", true, false);
            Victor victor3 = new Victor("vyctor", "humain pas", 11, true, true, "male", true, false);

            Console.WriteLine(victor1.AffichageVictor());
            Console.WriteLine(victor2.AffichageVictor());
            Console.WriteLine(victor3.AffichageVictor());
        }
    }
}