namespace _6TI_ACT6_2_GregoireA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] mesAnimaux = new Animal[5];

            mesAnimaux[0] = new Chat(true, 25, "12gt5e", "24/10/2022", "kitty");
            mesAnimaux[1] = new Chat(true, 36, "ge589r", "24/12/2022", "Le chat");
            mesAnimaux[2] = new Chien(true, 45, "12feze", "31/10/2022", "doggy");
            mesAnimaux[3] = new Lapin(87,false, 24, "258th", "14/05/2022", "lapinou");
            mesAnimaux[4] = new Lapin(3,false, 12, "azerty", "12/02/2022", "steak");

            for (int i = 0; i < mesAnimaux.Length; i++)
            {
                Console.WriteLine(mesAnimaux[i].manger());
                if (!(mesAnimaux[i] is Lapin))
                {
                    Console.WriteLine(mesAnimaux[i].affiche());

                }
                if (mesAnimaux[i] is Chat chat)
                {
                    Console.WriteLine(chat.Miauler());
                }
                if (mesAnimaux[i] is Chien chien)
                {
                    Console.WriteLine(chien.Aboyer());
                }
                if (mesAnimaux[i] is Lapin lapin)
                {
                    Console.WriteLine(lapin.Sauter());
                    Console.WriteLine(lapin.affiche());
                    
                }
                Console.WriteLine("------------------------");
            }
        }
    }
}