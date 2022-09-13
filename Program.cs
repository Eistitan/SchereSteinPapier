using static System.Console;
using static Spiel.SSP;

Starter();


namespace Spiel
{
    public static class SSP
    {
        public static int Spieler = 0;
        public static int Computer = 0;
        
        public static string Dice()
        {
            Random rnd = new Random();
            int Dice = rnd.Next(3);
            string[] Auswahl = { "Schere", "Stein", "Papier" };
            string CompDes = Auswahl[Dice];
            return CompDes;
        }

        public static void Starter()
        {
            bool Stopper = true;
            while (Stopper == true)
            {
                WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                WriteLine("Schere, Stein, Papier?");
                WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                string Wahl = ReadLine();

                string Wuerfel = Dice();

                if (Wahl == Wuerfel)
                {
                    
                    Zero();
                    Zaehler();
                    Stopper = Zaehler();
                }
                else if (Wahl == "Schere" && Wuerfel == "Papier")
                {
                    
                    StandSp();
                    Zaehler();
                    Stopper = Zaehler();
                }
                else if (Wahl == "Schere" && Wuerfel == "Stein")
                {
                   
                    StandCp();
                    Zaehler();
                    Stopper = Zaehler();

                }
                else if (Wahl == "Papier" && Wuerfel == "Stein")
                {
                    
                    StandSp();
                    Zaehler();
                    Stopper = Zaehler();

                }
                else if (Wahl == "Papier" && Wuerfel == "Schere")
                {
                   
                    StandCp();
                    Zaehler();
                    Stopper = Zaehler();

                }
                else if (Wahl == "Stein" && Wuerfel == "Schere")
                {
                    
                    StandSp();
                    Zaehler();
                    Stopper = Zaehler();
                }
                else if (Wahl == "Stein" && Wuerfel == "Papier")
                {
                    
                    StandCp();
                    Zaehler();
                    Stopper = Zaehler();
                }
                else
                {
                    WriteLine("kek");
                }
            }
        }


        public static int StandSp()
        {
            string Wuerfel = Dice();
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine(Wuerfel);
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("Du hast gewonnen!");
            WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Spieler += 1;   
            
            //WriteLine($"Stand: Spieler {StandSp()} - Computer {StandCp()}");    //Problem
            //WriteLine("Stand: Spieler " + StandSp() + "- Computer " + StandCp());
            return Spieler;
        }

        public static int StandCp()
        {
            string Wuerfel = Dice();
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine(Wuerfel);
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Du hast verloren!");
            WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Computer += 1;
            //WriteLine("Stand: Spieler "+StandSp() + "- Computer " +StandCp()); //Problem
            return Computer;
        }

        public static bool Zaehler()
        {
            if (Spieler == 5)
            {
                WriteLine("Spieler hat gewonnen");
                return false;
            }
            else if (Computer == 5)
            {
                WriteLine("Computer hat gewonnen");
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void Zero()
        {
            string Wuerfel = Dice();
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine(Wuerfel);
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Unentschieden");
            WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            //WriteLine($"Stand: Spieler {StandSp()} - Computer {StandCp()}");
        }

    }
}

