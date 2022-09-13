using static System.Console;
using static Spiel.SSP;

Starter();


namespace Spiel
{
    public static class SSP
    {
        static int Spieler = 0;
        static int Computer = 0;
        static bool Stopper = true;
        static string Wahl;
        static string Wuerfel;

        public static string Dice()
        {
            Random rnd = new Random();
            int Dice = rnd.Next(3);
            string[] Auswahl = { "Schere", "Stein", "Papier" };
            string CompDes = Auswahl[Dice];
            return CompDes;
        }
        public static void output(string status ="remis")
        {
            switch(status)
            {
                case "start":
                    WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("Schere, Stein, Papier?");
                    WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "win":
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLine(Wuerfel);
                    Console.ForegroundColor = ConsoleColor.Green;
                    WriteLine("Du hast gewonnen!");
                    WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "lose":
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLine(Wuerfel);
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("Du hast verloren!");
                    WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "remis":
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLine(Wuerfel);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("Unentschieden");
                    WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "-":
                    WriteLine("kek");
                    break;
            }
            if (status != "start")
            {
                WriteLine("");
                WriteLine($"Stand: Spieler {Spieler} - Computer {Computer}");
            }
        }
        public static void Starter()
        {
            
            while (Stopper == true)
            {
                output("start");

                Wahl = ReadLine();
                if (Wahl != "Stein" || Wahl!="Schere"||Wahl!="Papier")
                {
                    output("-");
                    Environment.Exit(0);
                }

                Wuerfel = Dice();

                if (Wahl == Wuerfel)
                {
                    Zero();
                }
                else if (Wahl == "Schere" && Wuerfel == "Papier" || Wahl == "Papier" && Wuerfel == "Stein" || Wahl == "Stein" && Wuerfel == "Schere")
                {
                    
                    StandSp();
                    
                }
                else 
                {
                   
                    StandCp();
                    
                }
                
                    Stopper = Zaehler();
                
            }
        }


        public static int StandSp()
        {
            Spieler += 1;
            output("win");         
          
            return Spieler;
        }

        public static int StandCp()
        {
            Computer += 1;
            output("lose");

            return Computer;
        }

        public static bool Zaehler()
        {
            if (Spieler == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("Spieler hat gewonnen");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            else if (Computer == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta; 
                WriteLine("Computer hat gewonnen");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void Zero()
        {
            output();
        }

    }
}

