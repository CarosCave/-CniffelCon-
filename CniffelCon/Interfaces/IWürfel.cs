namespace CniffelCon.Interfaces
{
    public interface IWürfel
    {
        public int Würfeln();
        public void Wurf(int augen, int left, int top);
        
        public int Augen { get; set; }
        public bool Gehalten { get; set; }
    }
}
