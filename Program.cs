using Banking.Logic;

Console.WriteLine("Type of Account? ([c]hecking, [b]usiness, [s]avings): ");
var accountType = Console.ReadLine()!;
Console.WriteLine("Account number: ");
var accountNumber = Console.ReadLine()!;
Console.WriteLine("Account holder: ");
var accountHolder = Console.ReadLine()!;
Console.WriteLine("Current balance: ");
var currentBalance = decimal.Parse(Console.ReadLine()!);

Account account;
Transaction transaction = new Transaction();

switch (accountType)
{
    case "c":
        account = new CheckingAccount();
        account.AccountNumber = accountNumber;
        account.AccountHolder = accountHolder;
        account.CurrentBalance = currentBalance;
        break;
    case "b":
        account = new BusinessAccount();
        account.AccountNumber = accountNumber;
        account.AccountHolder = accountHolder;
        account.CurrentBalance = currentBalance;
        break;
    case "s":
        account = new SavingsAccount();
        account.AccountNumber = accountNumber;
        account.AccountHolder = accountHolder;
        account.CurrentBalance = currentBalance;
        break;
    default:
        return;
}

Console.WriteLine("Transaction account number: ");
var transactionNumber = Console.ReadLine()!;
Console.WriteLine("Transaction description: ");
var transactionDescription = Console.ReadLine()!;
Console.WriteLine("Transaction amount: ");
var transactionAmount = decimal.Parse(Console.ReadLine()!);
Console.WriteLine("Transaction timestamp: ");
var transactionTimeStamp = DateTime.Parse(Console.ReadLine()!);

transaction.AccountNumber = transactionNumber;
transaction.Description = transactionDescription;
transaction.Amount = transactionAmount;
transaction.Timestamp = transactionTimeStamp;

if (account.TryExecute(transaction) == true)
{
    Console.WriteLine($"Transaction executed successfully. The new current balance is {account.CurrentBalance}€.");
}

else { Console.WriteLine("Transaction not allowed."); }
