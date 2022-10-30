namespace CniffelCon.Interfaces
{
    public interface IPlayers
    {
        enum Zustand;
        public struct Feld
        {
            private Zustand _zustand;
            private uint wert;
        };
        public Feld Einer { get; set; }
        public Feld Zweier { get; set; }
        public Feld Dreier { get; set; }
        public Feld Vierer { get; set; }
        public Feld Fünfer { get; set; }
        public Feld Sechser { get; set; }
        public Feld DreierPasch { get; set; }
        public Feld ViererPasch { get; set; }
        public Feld FullHouse { get; set; }
        public Feld KleineStrasse { get; set; }
        public Feld GrosseStrasse { get; set; }
        public Feld Gniffel { get; set; }
        public Feld Chance { get; set; }
        
        
        // Berechnungen 
        public uint GesamtOben { get; set; }
        public uint GesamtObenBonus { get; set; }
        public uint GesamtUnten { get; set; }
        public uint Gesamt { get; set; }
    }
}
