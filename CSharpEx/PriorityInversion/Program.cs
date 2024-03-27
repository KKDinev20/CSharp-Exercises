using System;
using System.Threading;

class Program
{
    static object resource = new object();

    static void LowPriorityTask()
    {
        Console.WriteLine("Low-priority task starts.");
        // Simulate work
        Thread.Sleep(2000);

        lock (resource)
        {
            Console.WriteLine("Low-priority task holds the resource.");
            // Simulate work
            Thread.Sleep(2000);
        }
        Console.WriteLine("Low-priority task releases the resource.");
    }

    static void HighPriorityTask()
    {
        Console.WriteLine("High-priority task starts.");
        // Simulate work
        Thread.Sleep(1000);
        
        Console.WriteLine("High-priority task requests the resource.");
        lock (resource)
        {
            Console.WriteLine("High-priority task holds the resource.");
            // Simulate work
            Thread.Sleep(2000);
        }
        Console.WriteLine("High-priority task releases the resource.");
    }

    static void Main(string[] args)
    {
        Thread lowPriorityThread = new Thread(LowPriorityTask);
        Thread highPriorityThread = new Thread(HighPriorityTask);

        // Set thread priorities
        lowPriorityThread.Priority = ThreadPriority.Lowest;
        highPriorityThread.Priority = ThreadPriority.Highest;

        lowPriorityThread.Start();
        highPriorityThread.Start();

        lowPriorityThread.Join();
        highPriorityThread.Join();

        Console.WriteLine("Both tasks completed.");
    }
}