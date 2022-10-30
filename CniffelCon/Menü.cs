namespace CniffelCon;

public class Menü
{
    public void Hauptmenü()
    {
        Console.Clear();
        Console.WriteLine("**************************************");
        Console.WriteLine("*                                    *");
        Console.WriteLine("*   Willkommen beim neuestem Spiel   *");
        Console.WriteLine("*   aus dem Hause Mary-Games         *");
        Console.WriteLine("*           Cniffel v0.1             *");
        Console.WriteLine("*                                    *");
        Console.WriteLine("*    1) Spielen                      *");
        Console.WriteLine("*    2) Anleitung *                  *");
        Console.WriteLine("*    3) Highscore *                  *");
        Console.WriteLine("*    4) Beenden                      *");
        Console.WriteLine("*                                    *");
        Console.WriteLine("*    * noch nicht implementiert      *");
        Console.WriteLine("*                                    *");
        Console.WriteLine("**************************************");
        Console.WriteLine("Ihre Auswahl: ");

        
        // Eingabe einlesen, dann prüfen ob Eingabe eine Zahl ist und ob sie zwischen 1 und 4 liegt.
        string? strEingabe = Console.ReadLine();
        
        
        int intEingabe = _überprüfeEingabe(strEingabe,1,4);
        

        switch (intEingabe)
        {
            case 1:
                Spielmenü();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                EndeGame();
                break;
            default:
                FehlerMenü();
                break;
        }
    }
    

    private void Spielmenü()
    {
        Console.Clear();
        Console.Write("Bitte Anzahl an SpielerInnen eingeben (1-5): ");
        string? strEingabe = Console.ReadLine();
        int anzahlSpieler = _überprüfeEingabe(strEingabe,1,5);
        
        List<string> PlayerNames = new List<string>(anzahlSpieler);

        for (int i = 0; i < anzahlSpieler; i++)
        {
            Console.Write("Name " + (int)(i+1) + " eingeben: ");
            PlayerNames.Insert(i,Console.ReadLine());
        }

        foreach (string name in PlayerNames)
        {
            Console.WriteLine(name);
        }
        
    }

    private void EndeGame()
    {
        Console.Clear();
        Console.WriteLine("******************************************");
        Console.WriteLine("*                                        *");
        Console.WriteLine("*  Vielen Dank fürs spielen.             *");
        Console.WriteLine("*  Wir wünschen noch einen schönen Tag.  *");
        Console.WriteLine("*                                        *");
        Console.WriteLine("*  Beenden mit Enter                     *");
        Console.WriteLine("*                                        *");
        Console.WriteLine("******************************************");
        Console.ReadKey();
        Environment.Exit(0);
    }
    private void FehlerMenü()
    {
        Console.WriteLine("Bitte eine Zahl zwischen 1 und 4 eingeben. Danke.");
        Console.WriteLine("Weiter mit Enter");
        Console.ReadKey();
        Hauptmenü();
    }
    private int _überprüfeEingabe(string strEingabe, int min, int max)
    {
        int intEingabe = 0;
        if (!int.TryParse(strEingabe, out int result1))
        {
            FehlerMenü();
        }
        else
        {
            intEingabe = int.Parse(strEingabe);
            if (intEingabe < min || intEingabe > max)
            {
                FehlerMenü();
            }
        }

        return intEingabe;


    }
}