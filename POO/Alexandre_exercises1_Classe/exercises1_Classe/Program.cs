using System.Diagnostics;

namespace exercises1_Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Victor[] mesVictors = new Victor[10];
            Console.ForegroundColor = ConsoleColor.White;
            string reponse = "";
            Console.WriteLine("Géneration de vos Victor........");
            Thread.Sleep(1000);
            for (uint i = 0; i < 10; i++)
            {
                Victor victor = new Victor("victor " + i, "humain", 2 + i, false, false, "male", false, false);
                mesVictors[i] = victor;
                Console.WriteLine(mesVictors[i].AffichageVictor());
                Console.WriteLine("---------------------------");
            }
            actionsVictor(ref mesVictors, "vacciner","vaccinage", 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            actionsVictor(ref mesVictors, "steriliser", "sterilisation", 2);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            actionsVictor(ref mesVictors, "dresser", "dressage", 3);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            actionsVictor(ref mesVictors, "pucer", "placement de la puce", 4);



            for (uint i = 0; i < 10; i++)
            {
                Console.WriteLine(mesVictors[i].AffichageVictor());
                Console.WriteLine("---------------------------");
            }

        }
        static void actionsVictor(ref Victor[] mesVictors,string actions,string actions2,int numeroAction)
        {
            ConsoleKeyInfo cki;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Voulez vous "+ actions + " ce Victor ? o = oui / autre = non");
                Console.WriteLine(mesVictors[i].AffichageVictor());
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.O)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(actions2 + " de votre victor en cours");
                    for (int y = 0; y < 10; y++)
                    {
                        Console.Write(".");
                        Thread.Sleep(10);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    if (numeroAction == 1)
                    {
                        
                        mesVictors[i].Vaccin = true;
                    }
                    else if (numeroAction == 2)
                    {
                        mesVictors[i].Sterilisation = true;
                    }
                    else if(numeroAction == 3)
                    {
                        mesVictors[i].Dresser = true;
                    }
                    else
                    {
                        mesVictors[i].Puce = true;
                    }
                    Console.WriteLine("---------------------------");
                    Console.WriteLine();
                    
                }
                else
                {
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ce victor ne sera pas " + actions);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("---------------------------");


                }
            }
        }
    }
}