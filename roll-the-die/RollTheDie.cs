using System;

public class Player
{
    public int RollDie()
    {
        Random res = new Random(18);
        return res.Next()%18;
    }

    public double GenerateSpellStrength()
    {
        Random res = new Random(100);
        return res.NextDouble()*100;
    }
}
