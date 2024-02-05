using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if(balance < 0)
        {
            return 3.213f;
        }
        if(balance >= 0 && balance < 1000)
        {
            return 0.5f;
        }
        if(balance >= 1000 && balance < 5000)
        {
            return 1.621f;
        }
        return 2.475f;
    }

    public static decimal Interest(decimal balance)
    {
        decimal res = (decimal)SavingsAccount.InterestRate(balance);

        return balance * (res/100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return SavingsAccount.Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal rolling = SavingsAccount.AnnualBalanceUpdate(balance);
        int count = 1;
        while(rolling < targetBalance)
        {
            rolling = SavingsAccount.Interest(rolling) + rolling;
            count++;
        }
        return count;
    }
}
