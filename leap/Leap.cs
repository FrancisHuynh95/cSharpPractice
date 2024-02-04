using System;

public static class Leap
{
    /*
        a leap year is: divisible by 4
        or evenly divisible by 100
    */
    public static bool IsLeapYear(int year)
    {
        if(year % 100 == 0 && year % 400 != 0)
        {
            return false;
        }
        else if(year % 4 == 0)
        {
            return true;
        }
    return false;
    }
}
