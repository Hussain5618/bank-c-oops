public class Transaction
{
    public Guid TransactionId { get; private set; }
    public Account? SenderAccount { get; private set; }
    public string OperationType { get; private set; }
    public Account? ReceiverAccount { get; private set; }
    public double Amount { get; private set; }
    public DateTime Date { get; private set; }

    public Transaction(Account senderAccount, Account receiverAccount, double amount, string operationType)
    {
        TransactionId = Guid.NewGuid();
        SenderAccount = senderAccount;
        OperationType = operationType;
        ReceiverAccount = receiverAccount;
        Amount = amount;
        Date = DateTime.Now;
    }
    public Transaction(Account account, double amount, string operationType)
    {
        TransactionId = Guid.NewGuid();
        if (operationType == "deposit")
        {
            ReceiverAccount = account;
        }
        else
        {
            SenderAccount = account;
        }
        OperationType = operationType;
        Amount = amount;
        Date = DateTime.Now;
    }

}