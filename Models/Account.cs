public class Account
{
    public Guid AccountId { get; set; }
    public Customer AccountHolder { get; private set; }
    public double Balance { get; private set; }
    public string AccountType { get; private set; }

    public Account(Customer accountHolder, string accountType)
    {
        AccountId = Guid.NewGuid();
        AccountHolder = accountHolder;
        AccountType = accountType;
        Balance = 0; // Initializing balance
    }
    public bool BalanceOperation(double amount, string operationType)
    {
        bool returnVal = true;
        switch (operationType)
        {
            case "deposit":
                Balance += amount;
                break;
            case "withdraw":
                if (Balance >= amount)
                {
                    Balance -= amount;
                }
                else
                {
                    returnVal = false;
                }
                break;
            default:
                return returnVal = false;
        }
        return returnVal;
    }
}