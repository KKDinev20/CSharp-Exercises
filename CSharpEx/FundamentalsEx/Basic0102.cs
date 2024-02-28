/*
namespace _012Solutions;

class Basic0102
{
    static void Main(string[] args)
    {
        //Ex1
        /*
        string name = Console.ReadLine();
        int age = Convert.ToInt32(Console.ReadLine());
        decimal grade = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"Name: {name}, Age: {age}, Grade: {Math.Round(grade, 2)}");
        #1#

        //Ex2
        /*double grade = double.Parse(Console.ReadLine());
        if(grade >= 3.00)
        {
            Console.WriteLine("Passed!");
        #1#

        //Ex3
        /*double grade = double.Parse(Console.ReadLine());
        if(grade >= 3.00)
        {
            Console.WriteLine("Passed!");
        }
        else
        {
            Console.WriteLine("Failed!");
        }#1#

        //Ex4
        /*int hours = Convert.ToInt32(Console.ReadLine());
        int minutes = Convert.ToInt32(Console.ReadLine());

        int total = hours * 60 + minutes + 30;

        hours = total / 60;
        minutes = total % 60;

        if (hours > 23)
        {
            hours = 0;
        }

        if (minutes > 59)
        {
            hours += 1;
        }

        if (minutes < 10)
        {

            Console.WriteLine($"{hours}:0{minutes}");
        }
        else
        {
            Console.WriteLine($"{hours}:{minutes}");
        }#1#
        
        //Ex5
        /*int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1: Console.WriteLine("January"); break;
            case 2: Console.WriteLine("February"); break;
            case 3: Console.WriteLine("March"); break;
            case 4: Console.WriteLine("April"); break;
            case 5: Console.WriteLine("May"); break;
            case 6: Console.WriteLine("June"); break;
            case 7: Console.WriteLine("July"); break;
            case 8: Console.WriteLine("August"); break;
            case 9: Console.WriteLine("September"); break;
            case 10: Console.WriteLine("October"); break;
            case 11: Console.WriteLine("November"); break;
            case 12: Console.WriteLine("December"); break;
            default: Console.WriteLine("Error!"); break;
        }#1#
        
        //Ex6
        /*string country = Console.ReadLine();
        if(country == "USA" || country == "England")
        {
            Console.WriteLine("English");
        }
        else if (country == "Spain" || country == "Argentina" || country == "Mexico")
        {
            Console.WriteLine("Spanish");
        }
        else
        {
            Console.WriteLine("unknown");
        }#1#
        
        //Ex8
        /*
        for (int i = 3; i < 100; i += 3)
        {
            Console.WriteLine(i);
        }#1#
        
        //Ex9
        /*int oddN = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= oddN; i++)
        {
            
            Console.WriteLine(2 * i - 1);
            sum += 2 * i - 1;   
            
        }
        
        Console.WriteLine($"Sum: {sum}");#1#
        
        //Ex10
        /*int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} X {i} = {n*i}");
        }
        #1#
        
        //Ex11
        /*int integer = Convert.ToInt32(Console.ReadLine());
        int multiplier = Convert.ToInt32(Console.ReadLine());
        
        if (multiplier <= 10) {
            for (int i = multiplier; i <= 10; i++) {
                Console.WriteLine($"{integer} X {i} = {integer * i}");
            }
        } else {
            Console.WriteLine($"{integer} X {multiplier} = {integer * multiplier}");
        }
        #1#
        
        
        //Ex12
        /*int n = Convert.ToInt32(Console.ReadLine());
        while (n % 2 != 0)
        {
            Console.WriteLine("Please write an even number.");
            n = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"The number is: {Math.Abs(n)}");#1#
    }
}
*/
