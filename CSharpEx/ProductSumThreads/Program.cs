//using System;
using System.Numerics;
//using System.Threading;

/*Да се напише програма, която получава цяло число и.
 След това програмата да генерира масива с и на брой елементи от случайни числа в интервала [-100; 100]. 
 Програмата трябва да разполага с две паралелни нишки, които пресмятат съответно сумата и произведението 
 от елементите в масива. 
 На всяка итерация от пресмятането трябва да се извежда текущия резултат.
Забележка: Понеже произведението може да надхвърли сравнително лесно стандартния диапазон на 64- 
битовите типове, използвайте подходящ клас (BigInteger) за големи числа.*/

namespace ProductSumThreads;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        Random randomValues = new Random();

        Thread sumThread = new Thread(() => CalculateSum(arr));
        Thread productThread = new Thread(() => CalculateProduct(arr));
        
        Console.Write("Array elements: ");
        for (int index = 0; index < n; index++)
        {
            arr[index] = randomValues.Next(-100, 101);
            Console.Write(arr[index] + " ");
        }

        Console.WriteLine();
        
        sumThread.Start();
        productThread.Start();
        
        sumThread.Join();
        productThread.Join();

    }

    private static void CalculateProduct(int[] arr)
    {
        BigInteger product = 1;
        for (int index = 0; index < arr.Length; index++)
        {
            product *= arr[index];
            Console.WriteLine($"Product: {product}");
            Thread.Sleep(100); 
        }
    }

    private static void CalculateSum(int[] arr)
    {
        int sum = 0;
        for (int index = 0; index < arr.Length; index++)
        {
            sum += arr[index];
            Console.WriteLine($"Sum: {sum}");
            Thread.Sleep(100); 
        }
    }
}