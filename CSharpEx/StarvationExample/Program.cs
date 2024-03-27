using System;
using System.Threading;

class DiningPhilosophers
{
    private static object[] forks = { new object(), new object(), new object(), new object(), new object() };

    static void Philosopher(int id)
    {
        while (true)
        {
            // Pick up left fork
            lock (forks[id])
            {
                Console.WriteLine($"Philosopher {id} picks up left fork");

                // Simulate thinking
                Thread.Sleep(100);

                // Pick up right fork
                lock (forks[(id + 1) % forks.Length])
                {
                    Console.WriteLine($"Philosopher {id} picks up right fork and eats");

                    // Simulate eating
                    Thread.Sleep(100);

                    // Release forks
                }
            }

            // Simulate thinking
            Thread.Sleep(100);
        }
    }

    static void Main(string[] args)
    {
        Thread[] philosophers = new Thread[5];

        for (int i = 0; i < philosophers.Length; i++)
        {
            int philosopherId = i;
            philosophers[i] = new Thread(() => Philosopher(philosopherId));
            philosophers[i].Start();
        }

        foreach (Thread philosopher in philosophers)
        {
            philosopher.Join();
        }
    }
}