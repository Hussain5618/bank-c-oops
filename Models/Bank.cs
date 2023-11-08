public class Bank
{
    private List<Customer> customers;
    private List<Account> accounts;
    private List<Transaction> transactions;

    public Bank()
    {
        customers = new List<Customer>();
        accounts = new List<Account>();
        transactions = new List<Transaction>();
    }

    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }

    public Account CreateAccount(Customer customer, string accountType)
    {
        // Create a new account for the customer
        var newAccount = new Account(customer, accountType);
        accounts.Add(newAccount);
        return newAccount;
    }

    public bool PerformTransaction(Guid senderId, Guid receiverId, float amount)

    {
        Account? sender = accounts.Find(account => account.AccountId == senderId);
        Account? receiver = accounts.Find(account => account.AccountId == receiverId);
        if (sender == null || receiver == null)
        {
            return false;
        }
        if (sender.Balance >= amount)
        {
            sender.BalanceOperation(amount, "withdraw");
            receiver.BalanceOperation(amount, "deposit");
            var newTransaction = new Transaction(sender, receiver, amount, "transfer");
            transactions.Add(newTransaction);
            return true;
        }
        return false;
    }

    public void DisplayDetails()
    {
        foreach (Account account in accounts)
        {
            Console.WriteLine($"Account ID: {account.AccountId}  {account.AccountHolder.Name}  {account.AccountType}  {account.Balance}");
        }
    }

    internal void AddFunds(Guid customerId, double amount)
    {
        Account? account = accounts.Find(account => account.AccountId == customerId);
        if (account != null)
        {
            Transaction transaction = new Transaction(account, amount, "deposit");
            transactions.Add(transaction);
            account.BalanceOperation(amount, "deposit");
        }
    }

    internal void WithdrawFunds(Guid customerId, double amount)
    {
        Account? account = accounts.Find(account => account.AccountId == customerId);
        if (account != null)

        {
            Transaction transaction = new Transaction(account, amount, "withdraw");
            transactions.Add(transaction);
            account.BalanceOperation(amount, "withdraw");
        }
    }
    public void DisplayTrasactions()
    {
        foreach (Transaction transaction in transactions)
        {
            Console.WriteLine($"Transaction ID: {transaction.TransactionId}  {transaction?.SenderAccount?.AccountHolder.Name}  {transaction?.OperationType}  {transaction?.ReceiverAccount?.AccountHolder.Name}  {transaction?.Amount}  {transaction?.Date}");
        }
    }
}