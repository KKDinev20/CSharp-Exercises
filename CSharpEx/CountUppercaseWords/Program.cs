namespace CountUppercaseWords;

class Program
{
    static void Main(string[] args)
    {
        string[] sentence = Console.ReadLine().Split(' ');

        IEnumerable<string> upperCaseWords = sentence.Where(word => char.IsUpper(word[0]));
        
        foreach (string word in upperCaseWords) {
            Console.WriteLine(word);
        }
    }
}