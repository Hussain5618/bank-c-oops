public class Transaction
{
    public Guid TransactionId { get; private set; }
    public Account SenderAccount { get; private set; }
    public Account ReceiverAccount { get; private set; }
    public float Amount { get; private set; }
    public DateTime Date { get; private set; }

    public Transaction(Guid transactionId, Account senderAccount, Account receiverAccount, float amount)
    {
        TransactionId = transactionId;
        SenderAccount = senderAccount;
        ReceiverAccount = receiverAccount;
        Amount = amount;
        Date = DateTime.Now;
    }
}