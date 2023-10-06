namespace Banking.Logic;

public class CheckingAccount : Account
{
    public override bool IsAllowed(Transaction t)
    {
        if (AccountNumber == t.AccountNumber && t.Amount <= 100000 && CurrentBalance + t.Amount >= -10000 && CurrentBalance + t.Amount <= 10000000)
        {
            return true;
        }

        return false;
    }
}
