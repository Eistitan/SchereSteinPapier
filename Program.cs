using static System.Console;
using static Spiel.SSP;

Starter();


namespace Spiel
{
    public static class SSP
    {
        public static int Spieler = 0;
        public static int Computer = 0;
        //static string[] Auswahl = { "Schere", "Stein", "Papier" };

        public static string Dice()
        {
            Random rnd = new Random();
            int Dice = rnd.Next(3);
            string[] Auswahl = { "Schere", "Stein", "Papier" };
            string CompDes = Auswahl[Dice];
            return CompDes;
        }

        public static int StandSp()
        {
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine(Dice());
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("Du hast gewonnen!");
            WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Spieler += 1;                                        //Ununterbrochener Zähler?
            WriteLine($"Stand: Spieler {StandSp()} - Computer {StandCp()}");
            return Spieler;
        }
        public static int StandCp()
        {
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine(Dice());
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Du hast verloren!");
            WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Computer += 1;
            WriteLine($"Stand: Spieler {StandSp()} - Computer {StandCp()}");
            return StandCp();
        }
        public static bool Zaehler()
        {
            if (StandSp() == 5)
            {
                WriteLine("Spieler hat gewonnen");
                return false;
            }
            else if (StandCp() == 5)
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
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine(Dice());
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Unentschieden");
            WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine($"Stand: Spieler {StandSp()} - Computer {StandCp()}");
        }
        public static void Starter()
        {
            while (Zaehler() == true)
            {
                WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                WriteLine("Schere, Stein, Papier?");
                WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                string Wahl = ReadLine();


                if (Wahl == Dice())
                {
                    //Console.ForegroundColor = ConsoleColor.White;
                    //WriteLine(Auswahl[Dice]);
                    //Console.ForegroundColor = ConsoleColor.Yellow;
                    //WriteLine("Unentschieden");
                    //WriteLine(" ");
                    //Console.ForegroundColor = ConsoleColor.White;
                    //StandSp = StandSp + 0;
                    //StandCp = StandCp + 0;
                    //WriteLine($"Stand: Spieler {StandSp} - Computer {StandCp}");
                    Zero();
                    Zaehler();
                }
                else if (Wahl == "Schere" && Dice() == "Papier")
                {
                    //Console.ForegroundColor = ConsoleColor.White;
                    //WriteLine(Auswahl[Dice]);
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //WriteLine("Du hast gewonnen!");
                    //WriteLine(" ");
                    //Console.ForegroundColor = ConsoleColor.White;
                    //StandSp = StandSp + 1;
                    //StandCp = StandCp + 0;
                    //WriteLine($"Stand: Spieler {StandSp} - Computer {StandCp}");
                    StandSp();
                    Zaehler();
                }
                else if (Wahl == "Schere" && Dice() == "Stein")
                {
                    //Console.ForegroundColor = ConsoleColor.White;
                    //WriteLine(Auswahl[Dice]);
                    //Console.ForegroundColor = ConsoleColor.Red;
                    //WriteLine("Du hast verloren!");
                    //WriteLine(" ");
                    //Console.ForegroundColor = ConsoleColor.White;
                    //StandSp = StandSp + 0;
                    //StandCp = StandCp + 1;
                    //WriteLine($"Stand: Spieler {StandSp} - Computer {StandCp}");
                    StandCp();
                    Zaehler();

                }
                else if (Wahl == "Papier" && Dice() == "Stein")
                {
                    //Console.ForegroundColor = ConsoleColor.White;
                    //WriteLine(Dice());
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //WriteLine("Du hast gewonnen!");
                    //WriteLine(" ");
                    //Console.ForegroundColor = ConsoleColor.White;
                    //StandSp = StandSp + 1;
                    //StandCp = StandCp + 0;
                    //WriteLine($"Stand: Spieler {StandSp} - Computer {StandCp}");
                    StandSp();
                    Zaehler();

                }
                else if (Wahl == "Papier" && Dice() == "Schere")
                {
                    //Console.ForegroundColor = ConsoleColor.White;
                    //WriteLine(Auswahl[Dice]);
                    //Console.ForegroundColor = ConsoleColor.Red;
                    //WriteLine("Du hast verloren!");
                    //WriteLine(" ");
                    //Console.ForegroundColor = ConsoleColor.White;
                    //StandSp = StandSp + 0;
                    //StandCp = StandCp + 1;
                    //WriteLine($"Stand: Spieler {StandSp} - Computer {StandCp}");
                    StandCp();
                    Zaehler();

                }
                else if (Wahl == "Stein" && Dice() == "Schere")
                {
                    //Console.ForegroundColor = ConsoleColor.White;
                    //WriteLine(Auswahl[Dice]);
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //WriteLine("Du hast gewonnen!");
                    //WriteLine(" ");
                    //Console.ForegroundColor = ConsoleColor.White;
                    //StandSp = StandSp + 1;
                    //StandCp = StandCp + 0;
                    //WriteLine($"Stand: Spieler {StandSp} - Computer {StandCp}");
                    StandSp();
                    Zaehler();

                }
                else if (Wahl == "Stein" && Dice() == "Papier")
                {
                    //Console.ForegroundColor = ConsoleColor.White;
                    //WriteLine(Auswahl[Dice]);
                    //Console.ForegroundColor = ConsoleColor.Red;
                    //WriteLine("Du hast verloren!");
                    //WriteLine(" ");
                    //Console.ForegroundColor = ConsoleColor.White;
                    //StandSp = StandSp + 0;
                    //StandCp = StandCp + 1;
                    //WriteLine($"Stand: Spieler {StandSp} - Computer {StandCp}");
                    StandCp();
                    Zaehler();

                }
                else
                {
                    WriteLine("kek");
                }
            }




        }
    }
}

