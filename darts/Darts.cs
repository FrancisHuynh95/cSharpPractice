using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
       double hyp = Math.Sqrt(x * x + y * y);
       if(hyp > 10) return 0;
       if(hyp > 5) return 1;
       if(hyp > 1) return 5;
       return 10;

    }
}
