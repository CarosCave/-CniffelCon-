using CniffelCon.Interfaces;

namespace CniffelCon;

public class Game
{
    int[] leftPosition = new int[5] { 0, 12, 24, 36, 48 };
    public void Init()
    {
        IWürfel[] würfel = new IWürfel[5];
       // Players[] players = new Players[4];
        
        //players[0] = new Players("Player ");

            
        würfel[0] = new Würfel();
        würfel[1] = new Würfel();
        würfel[2] = new Würfel();
        würfel[3] = new Würfel();
        würfel[4] = new Würfel();
        
        for (int i = 0; i < 5; i++) 
            würfel[i].Wurf(würfel[i].Würfeln(),leftPosition[i],0);
    }
}