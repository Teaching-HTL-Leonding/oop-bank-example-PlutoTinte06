namespace Banking.Logic;

public class BusinessAccount : Account
{
    public override bool IsAllowed(Transaction t)
    {
        if (AccountNumber == t.AccountNumber && CurrentBalance + t.Amount >= -1000000 && CurrentBalance + t.Amount <= 100000000 && t.Amount <= 1000000)
        {
            return true;
        }

        return false;
    }
}
