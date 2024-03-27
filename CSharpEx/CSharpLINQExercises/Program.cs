namespace CSharpLINQExercises;

class Program
{
    static void Main(string[] args)
    {
        // Write a program in C# Sharp to show how the three parts of a query operation execute.
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        var evenNumbers =
            from n in numbers
            where n % 2 == 0
            select n;

        foreach (var num in evenNumbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
        //Write a program in C# Sharp to find the +ve numbers
        //from a list of numbers using two where conditions in LINQ Query.

        var arr1 = new[] { -3, 9, -2, 8, -6, 5 };

        var positiveNumbers =
            from num in arr1
            where num > 0
            where num < 11
            select num;
        foreach (var num in positiveNumbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();

        //3. Write a program in C# Sharp to find the number of an array and the square of each number.
        var arr2 = new[] { 3, 9, 2, 8, 6, 5 };

        var sqNo = from int Number in arr1
            let SqrNo = Number * Number
            select new { Number, SqrNo };

        foreach (var a in sqNo)
            Console.Write(a + " ");

        Console.WriteLine();

        // Write a program in C# Sharp to display the number and frequency of a given number from an array.
        int[] arr3 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };


        var frequency =
            from n in arr3
            group n by n
            into m
            select m;

        foreach (var arrNo in frequency)
        {
            Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
        }

        //5. Write a program in C# Sharp to display the characters
        //and frequency of each character in a given string.

        string word = Console.ReadLine();

        var wordFrequency =
            from n in word
            group n by n
            into m
            select m;

        foreach (var arrNo in wordFrequency)
        {
            Console.WriteLine("Character " + arrNo.Key + " appears " + arrNo.Count() + " times");
        }

        //6. Write a program in C# Sharp to display the name of the days of the week.
        string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        var days = from WeekDay in dayWeek
            select WeekDay;

        // Display the days of the week
        foreach (var WeekDay in days)
        {
            Console.WriteLine(WeekDay);
        }

        Console.WriteLine();

        //7. Write a program in C# Sharp to display numbers,
        //multiplication of numbers with frequency
        //and the frequency of a number in an array.

        int[] arr4 = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

        var frequentNums = from x in arr4
            group x by x
            into y
            select y;

        foreach (var arrEle in frequentNums)
        {
            Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
        }

        //8. Write a program in C# Sharp to find a string that starts and ends with a specific character.
        string[] cities =
            { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };


        var chosenCity =
            from cit in cities
            where cit.StartsWith("A")
            where cit.EndsWith("M")
            select cit;

        foreach (var city in chosenCity) // Looping through the filtered cities and displaying them
        {
            Console.Write("The city starting with A and ending with M is : {0} \n", city);
        }

        Console.WriteLine();

        //9. Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
        int[] numbersA =  new int[]{ 55, 200, 740, 76, 230, 482, 95 };

        var bigNums =
            from n in numbersA
            where n > 80
            select n;
    }
}