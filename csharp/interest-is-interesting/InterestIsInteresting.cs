using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        // throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
        if (balance < 0)
        {
            return 3.213f;
        }
        else if (balance < 1000)
        {
            return 0.5f;
        }
        else if (balance < 5000)
        {
            return 1.621f;
        }
        else
        {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        // throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
        return balance * ((decimal)InterestRate(balance) / 100.0m);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        // throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        // throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
        int ans = 0;
        do
        {
            balance = AnnualBalanceUpdate(balance);
            ans += 1;
        } while (balance < targetBalance);
        return ans;
    }
}
