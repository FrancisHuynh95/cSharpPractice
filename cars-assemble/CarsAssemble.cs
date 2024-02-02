using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed >= 10)
        {
            return .77;
        }
        else if (speed == 9)
        {
            return .80;
        }
        else if (speed >= 5 && speed <= 8)
        {
            return .90;
        }
        else if (speed >= 1 && speed <= 4)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static double ProductionRatePerHour(int speed)
    {
        return AssemblyLine.SuccessRate(speed) * 221 * speed;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)AssemblyLine.ProductionRatePerHour(speed)/60;
    }
}
