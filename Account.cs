namespace Banking.Logic;

public abstract class Account
{
    public string AccountNumber { get; set; } = "";
    public string AccountHolder { get; set; } = "";
    public decimal CurrentBalance { get; set; }

    public abstract bool IsAllowed(Transaction t);
    public bool TryExecute(Transaction t)
    {
        if (IsAllowed(t) == true)
        {
            CurrentBalance += t.Amount;
            return true;
        }

        return false;
    }
}
