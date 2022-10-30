using System.Runtime.CompilerServices;
using CniffelCon.Interfaces;

namespace CniffelCon
{
    public class Players
    {
        public enum Zustand
        {
            Leer,
            Ausgefüllt,
            Gesperrt
        }
    
        public struct Feld
        {
            public Zustand zustand { get; set; }
            public uint wert { get; set; }
        }
        
        public string Name { get; set; }
        
        // Oberer Bereich
        public Feld Einer;
        public Feld Zweier;
        public Feld Dreier;
        public Feld Vierer;
        public Feld Fünfer;
        public Feld Sechser;

        // Unterer Bereich
        public Feld DreierPasch;
        public Feld ViererPasch;
        public Feld FullHouse;
        public Feld KleineStrasse;
        public Feld GrosseStrasse;
        public Feld Cniffel;
        public Feld Chance;

        // Speichere die Ergebnisse
        private uint _gesamtOben;
        public uint GesamtOben
        {
            get
            {
                return _gesamtOben;
            }
            private set
            {
                _gesamtOben = value;
            }
        }

        private uint _obenBonus;
        public uint ObenBonus
        {
            get
            {
                return _obenBonus;
            }
            private set
            {
                _obenBonus = value;
            }
        }
        
        private uint _obenMitBonus;
        public uint ObenMitBonus
        {
            get
            {
                return _obenMitBonus;
            }
            private set
            {
                _obenMitBonus = value;
            }
        }

        private uint _gesamtUnten;
        public uint GesamtUnten
        {
            get
            {
                return _gesamtUnten;
            }
            private set
            {
                _gesamtUnten = value;
            }
        }

        private uint _gesamt;
        public uint Gesamt
        {
            get
            {
                return _gesamt;
            }
            private set
            {
                _gesamt = value;
            }
        }
        
        
        // Berechnungen der Gesamtergebnisse
        public void Berechne()
        {
            // Berechne oberen Bereich
            GesamtOben = Einer.wert + Zweier.wert + Dreier.wert 
                         + Vierer.wert + Fünfer.wert + Sechser.wert;
            
            // Oberer Bereich Bonus
            if (GesamtOben >= 63)
                ObenBonus = 35;
            
            // Oberer Bereich mit Bonus
            ObenMitBonus = GesamtOben + ObenBonus;
            
            // unterer Bereich
            GesamtUnten = DreierPasch.wert + ViererPasch.wert + FullHouse.wert
                          + Chance.wert + Cniffel.wert + KleineStrasse.wert + GrosseStrasse.wert;
            
            // Gesamtergebnis
            Gesamt = ObenMitBonus + GesamtUnten;
        }

        // Konstruktor
        public Players(string name)
        {
            Name = name;
        }
    }
}
