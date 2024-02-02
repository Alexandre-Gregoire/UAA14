namespace _6TI_ACT6_3_GregoireA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forme carre = new Carre("rouge",10);
            Forme rectangle = new Rectangle("rouge", 10, 15);
            Console.WriteLine("carre : " + carre.affiche());
            Console.WriteLine("rectangle : " + rectangle.affiche());

        }
    }
}