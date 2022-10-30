namespace CniffelCon;

public class Spielfeld
{

    public void Ausgabe(Players[] players)
    {
        // Ausgabe der Werte (Drucken des gesamten Spielscheins
        Console.Write("Name:                         ");
        foreach (Players player in players)
        {
            Console.Write(player.Name + "\t");
        }

        Console.Write("\n");

        Console.Write("Einer:                        ");
        foreach (Players player in players)
        {
            Console.Write(player.Einer.wert);
            if (player.Einer.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Zweier:                       ");
        foreach (Players player in players)
        {
            Console.Write(player.Zweier.wert);
            if (player.Zweier.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Dreier:                       ");
        foreach (Players player in players)
        {
            Console.Write(player.Dreier.wert);
            if (player.Dreier.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Vierer:                       ");
        foreach (Players player in players)
        {
            Console.Write(player.Vierer.wert);
            if (player.Vierer.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Fünfer:                       ");
        foreach (Players player in players)
        {
            Console.Write(player.Fünfer.wert);
            if (player.Fünfer.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Sechser:                      ");
        foreach (Players player in players)
        {
            Console.Write(player.Sechser.wert);
            if (player.Sechser.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.WriteLine("-----------------------------");

        Console.Write("Gesamt Oben:                  ");
        foreach (Players player in players)
        {
            Console.Write(player.GesamtOben);
            if (player.GesamtOben <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Bonus bei 63 oder mehr (+35): ");
        foreach (Players player in players)
        {
            Console.Write(player.ObenBonus);
            if (player.ObenBonus <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Gesamt Oben mit Bonus:        ");
        foreach (Players player in players)
        {
            Console.Write(player.ObenMitBonus);
            if (player.ObenMitBonus <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.WriteLine("-----------------------------");

        Console.Write("Dreier Pasch:                 ");
        foreach (Players player in players)
        {
            Console.Write(player.DreierPasch.wert);
            if (player.DreierPasch.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Vierer Pasch:                 ");
        foreach (Players player in players)
        {
            Console.Write(player.ViererPasch.wert);
            if (player.ViererPasch.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Full House:                   ");
        foreach (Players player in players)
        {
            Console.Write(player.FullHouse.wert);
            if (player.FullHouse.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Kleine Strasse:               ");
        foreach (Players player in players)
        {
            Console.Write(player.KleineStrasse.wert);
            if (player.KleineStrasse.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Große Strasse:                ");
        foreach (Players player in players)
        {
            Console.Write(player.GrosseStrasse.wert);
            if (player.GrosseStrasse.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Cniffel:                      ");
        foreach (Players player in players)
        {
            Console.Write(player.Cniffel.wert);
            if (player.Cniffel.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Chance:                       ");
        foreach (Players player in players)
        {
            Console.Write(player.Chance.wert);
            if (player.Chance.wert <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.WriteLine("-----------------------------");

        Console.Write("Gesamt Oben:                  ");
        foreach (Players player in players)
        {
            Console.Write(player.ObenMitBonus);
            if (player.ObenMitBonus <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Gesamt Unten:                 ");
        foreach (Players player in players)
        {
            Console.Write(player.GesamtUnten);
            if (player.GesamtUnten <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

        Console.Write("\n");

        Console.Write("Gesamt:                       ");
        foreach (Players player in players)
        {
            Console.Write(player.Gesamt);
            if (player.Gesamt <= 9)
                Console.Write("\t \t");
            else Console.Write("\t");
        }

    }
}