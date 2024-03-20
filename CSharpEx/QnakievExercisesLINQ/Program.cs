namespace QnakievExercisesLINQ;

class Program
{
    static void Main(string[] args)
    {
        //Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.
        int[] arrA = { 67, 92, 153, 15 };

        arrA = arrA.Where(x => x > 30 && x < 100).ToArray();
        foreach(var i in arrA)
        {
            Console.Write(i + " ");
        }
        
        //Write a program in C# Sharp to shows how the three parts of a query operation execute.
        int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        Console.Write("\nBasic structure of LINQ : "); 
        Console.Write("\n---------------------------");
        
        var nQuery =
            from VrNum in n1
            where (VrNum % 2) == 0
            select VrNum;
        
        
        Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
        foreach (int VrNum in nQuery)
        {
            Console.Write("{0} ", VrNum);
        }
        Console.Write("\n\n");

        //Given a non-empty list of words, sort it alphabetically and return a word that contains letter 'e'.
        List<string> arr = new List<string>(){"bike", "plane", "ferry", "car"};
        arr.Sort();
        
        string word = arr.Where(str => str.Contains("e")).Last();
        
        Console.WriteLine(word);
        
        //Given a non-empty string consisting only of special chars (!, @, # etc.), return a number (as a string) where each digit corresponds to given special char on the keyboard ( 1→ !, 2 → @, 3 → # etc.).
        var chars = new char[] { ')', '!', '@', '#', '$', '%', '^', '&', '*', '(' };

        var encryptedNumber = Console.ReadLine();

        var decryptedNum = string.Join("", encryptedNumber.Select(c => Array.IndexOf(chars, c)));
        Console.WriteLine(decryptedNum);

        //Write a query that returns most frequent character in string. Assume that there is only one such character.
        string input = Console.ReadLine();

        var mostRepeated = input.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;
        
        Console.WriteLine(mostRepeated);

        //Write a program in C# to display the name of the days of a week in LINQ
        string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        Console.WriteLine("Days of a week");
        
        var daysOfWeek = dayWeek.Select(day => day);

        foreach (var d in daysOfWeek)
        {
            Console.WriteLine(d);
        }
    }
}