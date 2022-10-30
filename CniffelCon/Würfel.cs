using CniffelCon.Interfaces;

namespace CniffelCon
{
    public class Würfel : IWürfel
    {
        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        public int Würfeln()
        {
            return rnd.Next(1, 7);
        }

        public int Augen { get; set; }
        public bool Gehalten { get; set; }

        public void Wurf(int augen, int left, int top)
        {
            switch (augen)
            {
                case 1:
                    Eins(left, top);
                    break;
                case 2:
                    Zwei(left, top);
                    break;
                case 3:
                    Drei(left, top);
                    break;
                case 4:
                    Vier(left, top);
                    break;
                case 5:
                    Fünf(left, top);
                    break;
                case 6:
                    Sechs(left, top);
                    break;
            }
        }
        
        internal void Eins(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("  _______ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine(" /______/|");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("|       ||");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("|       ||");
            Console.SetCursorPosition(left, top+4);
            Console.WriteLine("|   #   ||");
            Console.SetCursorPosition(left, top+5);
            Console.WriteLine("|       ||");
            Console.SetCursorPosition(left, top+6);
            Console.WriteLine("|_______|/");
        }
        internal void Zwei(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("  _______ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine(" /______/|");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("|       ||");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("|     # ||");
            Console.SetCursorPosition(left, top+4);
            Console.WriteLine("|       ||");
            Console.SetCursorPosition(left, top+5);
            Console.WriteLine("| #     ||");
            Console.SetCursorPosition(left, top+6);
            Console.WriteLine("|_______|/");
        }
        internal void Drei(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("  _______ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine(" /______/|");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("|       ||");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("|     # ||");
            Console.SetCursorPosition(left, top+4);
            Console.WriteLine("|   #   ||");
            Console.SetCursorPosition(left, top+5);
            Console.WriteLine("| #     ||");
            Console.SetCursorPosition(left, top+6);
            Console.WriteLine("|_______|/");
        }
        internal void Vier(int left, int top)
        {
            Console.SetCursorPosition(left, top); 
            Console.WriteLine("  _______ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine(" /______/|");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("|       ||");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("| #   # ||");
            Console.SetCursorPosition(left, top+4);
            Console.WriteLine("|       ||");
            Console.SetCursorPosition(left, top+5);
            Console.WriteLine("| #   # ||");
            Console.SetCursorPosition(left, top+6);
            Console.WriteLine("|_______|/");
        }
        internal void Fünf(int left, int top)
        {
            Console.SetCursorPosition(left, top); 
            Console.WriteLine("  _______ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine(" /______/|");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("|       ||");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("| #   # ||");
            Console.SetCursorPosition(left, top+4);
            Console.WriteLine("|   #   ||");
            Console.SetCursorPosition(left, top+5);
            Console.WriteLine("| #   # ||");
            Console.SetCursorPosition(left, top+6);
            Console.WriteLine("|_______|/");
        }
        internal void Sechs(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("  _______ ");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine(" /______/|");
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("|       ||");
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("| #   # ||");
            Console.SetCursorPosition(left, top+4);
            Console.WriteLine("| #   # ||");
            Console.SetCursorPosition(left, top+5);
            Console.WriteLine("| #   # ||");
            Console.SetCursorPosition(left, top+6);
            Console.SetCursorPosition(left, top+6);
            Console.WriteLine("|_______|/");
        }
    }
}
