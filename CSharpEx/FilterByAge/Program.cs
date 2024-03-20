namespace FilterByAge;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of pairs:");
        int N = int.Parse(Console.ReadLine());

        List<string> names = new List<string>();
        List<int> ages = new List<int>();

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter name and age separated by comma:");
            string[] input = Console.ReadLine().Split(", ");
            names.Add(input[0]);
            ages.Add(int.Parse(input[1]));
        }

        Console.WriteLine("Enter condition (younger or older):");
        string condition = Console.ReadLine();

        Console.WriteLine("Enter age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter format (name, age or name age):");
        string format = Console.ReadLine();

        if (condition == "younger")
        {
            PrintByAge(names, ages, age, format, true);
        }
        else if (condition == "older")
        {
            PrintByAge(names, ages, age, format, false);
        }
        else
        {
            Console.WriteLine("Invalid condition.");
        }    
    }
    static void PrintByAge(List<string> names, List<int> ages, int age, string format, bool younger)
    {
        for (int i = 0; i < names.Count; i++)
        {
            if ((younger && ages[i] < age) || (!younger && ages[i] > age))
            {
                if (format == "name")
                {
                    Console.WriteLine(names[i]);
                }
                else if (format == "age")
                {
                    Console.WriteLine(ages[i]);
                }
                else if (format == "name age")
                {
                    Console.WriteLine($"{names[i]} - {ages[i]}");
                }
                else
                {
                    Console.WriteLine("Invalid format.");
                    break;
                }
            }
        }
    }
}