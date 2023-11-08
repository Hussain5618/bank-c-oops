Bank bank = new();
Customer customer1 = new Customer("User 1", "Address 1");
Customer customer2 = new Customer("User 2", "Address 2");
bank.AddCustomer(customer1);
bank.AddCustomer(customer2);
Account acc1 = bank.CreateAccount(customer1, "Savings");
Account acc2 = bank.CreateAccount(customer2, "Savings");
bank.DisplayDetails();
Console.WriteLine("Adding funds to customer 1");
bank.AddFunds(acc1.AccountId, 200.00);
bank.DisplayDetails();
Console.WriteLine("Moving funds from customer 1 to customer 2");
bank.PerformTransaction(acc1.AccountId, acc2.AccountId, 100);
bank.DisplayDetails();
Console.WriteLine("Withdrawing funds from customer 2");
bank.WithdrawFunds(acc2.AccountId, 50.00);
bank.DisplayDetails();
bank.DisplayTrasactions();

