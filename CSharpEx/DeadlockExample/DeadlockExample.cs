namespace ThreadsDeadlockLivelock;

public class Account
{
    public int Id { get; }
    private double Balance { get; set;}

    public Account(int id, double balance)
    {
        Id = id;
        Balance = balance;
    }
        
    public void WithdrawMoney(double amount)
    {
        Balance -= amount;
    }

    public void DepositMoney(double amount)
    {
        Balance += amount;
    }
}

public class AccountManager
{
    private Account _fromAccount;
    private Account _toAccount;
    private double _transferAmount;

    public AccountManager(Account accountFrom, Account accountTo, double amountTransfer)
    {
        _fromAccount = accountFrom;
        _toAccount = accountTo;
        _transferAmount = amountTransfer;
    }

    public void FundTransfer()
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {_fromAccount.Id}");
        lock (_fromAccount)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {_fromAccount.Id}");
            Console.WriteLine($"{Thread.CurrentThread.Name} Doing Some work");
            Thread.Sleep(1000);
            Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {_toAccount.Id}");

            lock (_toAccount)
            {
                _fromAccount.WithdrawMoney(_transferAmount);
                _toAccount.DepositMoney(_transferAmount);
            }
        }
    }
}


class DeadlockExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Thread Started");
        Account account1001 = new Account(1001, 5000);
        Account account1002 = new Account(1002, 3000);

        AccountManager accountManager1 = new AccountManager(account1001, account1002, 5000);
        Thread thread1 = new Thread(accountManager1.FundTransfer)
        {
            Name = "Thread1"
        };

        AccountManager accountManager2 = new AccountManager(account1002, account1001, 6000);
        Thread thread2 = new Thread(accountManager2.FundTransfer)
        {
            Name = "Thread2"
        };

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
        Console.WriteLine("Main Thread Completed");
        Console.ReadKey();
    }
}