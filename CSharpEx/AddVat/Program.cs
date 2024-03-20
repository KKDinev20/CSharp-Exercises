namespace AddVat;

class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .Select(p => p * 1.2m)
            .ToList()
            .ForEach(p => Console.WriteLine($"{p:F2}"));

    }
}