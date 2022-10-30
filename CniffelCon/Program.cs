using CniffelCon.Interfaces;

namespace CniffelCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Spielfeld spielfeld = new Spielfeld();

            Menü menü = new Menü();
            
            menü.Hauptmenü();

            //game.Init();
           

            // Console.WriteLine("Spielernamen: " + player[0].Name);
            // Console.WriteLine(player[0].Einer.wert);
            // Console.WriteLine(player[0].Zweier.wert);
            // Console.WriteLine("Gesamt Oben:           " + player[0].GesamtOben);
            // Console.WriteLine("Gesamt Oben mit Bonus: " + player[0].ObenBonus);
            // Console.WriteLine("Gesamt Unten:          " + player[0].GesamtUnten);
            // Console.WriteLine("Gesamt:                " + player[0].Gesamt);

            //spielfeld.Ausgabe(player);
            //game.Spielschein(player);
            //player

            
            /*
            IWürfel[] würfel = new IWürfel[5];
            IPlayers[] players = new IPlayers[4];
            int[] leftPosition = new int[5] { 0, 12, 24, 36, 48 };

            players[0] = new Players();

            
            würfel[0] = new Würfel();
            würfel[1] = new Würfel();
            würfel[2] = new Würfel();
            würfel[3] = new Würfel();
            würfel[4] = new Würfel();

            for (int i = 0; i < 5; i++) 
                würfel[i].Wurf(würfel[i].Würfeln(),leftPosition[i],0);

            Console.WriteLine("Welche Würfel möchten Sie halten?");
            Console.Write("Bitte Würfelnummern eingeben: ");

            string eingabe = Console.ReadLine();
            
            Console.WriteLine(eingabe);

            //int gespeicherteWürfel = Int32.Parse(eingabe.Split(' ', ',', '.'));

            string[] strWürfel = eingabe.Split(' ', ',', '.');

            int[] gespeicherteWürfel = new int[5];
            
            for(int i = 0; i < gespeicherteWürfel.Length; i++)
            {
                gespeicherteWürfel[i] = Int32.Parse(strWürfel[i]);
            }

*/

            Console.ReadKey();
        }
    }
}