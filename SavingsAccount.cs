namespace Banking.Logic;

public class SavingsAccount : Account
{
    public override bool IsAllowed(Transaction t)
    {
        if (AccountNumber == t.AccountNumber && CurrentBalance + t.Amount >= 0 && CurrentBalance + t.Amount <= 100000000)
        {
            return true;
        }

        return false;
    }
}
