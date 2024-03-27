using System;
using System.Threading;

class Program
{
    static int balance = 1000; // Shared resource

    static void WithdrawMoney(int amount)
    {
        if (balance >= amount)
        {
            // Simulate delay in processing
            Thread.Sleep(100);

            balance -= amount;
            Console.WriteLine($"Withdrawn {amount}$. Remaining balance: {balance}$");
        }
        else
        {
            Console.WriteLine($"Insufficient funds to withdraw {amount}$. Current balance: {balance}$");
        }
    }

    static void Main(string[] args)
    {
        Thread[] threads = new Thread[5]; 

        for (int i = 0; i < 5; i++)
        {
            threads[i] = new Thread(() => WithdrawMoney(500));
            threads[i].Start();
        }

        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine($"Final balance: {balance}$");
    }
}