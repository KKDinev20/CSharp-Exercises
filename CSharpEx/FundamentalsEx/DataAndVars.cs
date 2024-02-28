namespace _012Solutions;

class DataAndVars
{
    static void Main(string[] args)
    {
        //Ex1
        /*int numA = Convert.ToInt32(Console.ReadLine());
        int numB = Convert.ToInt32(Console.ReadLine());
        int numC = Convert.ToInt32(Console.ReadLine());
        int numD = Convert.ToInt32(Console.ReadLine());

        numB += numA;
        numB /= numC;
        numB *= numD;
        Console.WriteLine(numB);*/
        
        //Ex2
        /*int bigNum = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        while (bigNum != 0)
        {
            sum += bigNum % 10;

            bigNum /= 10;
        }
        Console.WriteLine(sum);*/
        
        //Ex3
        /*int people = Convert.ToInt32(Console.ReadLine());
        int capacity = Convert.ToInt32(Console.ReadLine());

        int courses = (int)Math.Ceiling((double) people / capacity);
        Console.WriteLine(courses);*/
        
        //Ex4
        /*
        int lines = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < lines; i++)
        {
            char letter = Convert.ToChar(Console.ReadLine());
            sum += Convert.ToInt32(letter);
        }
        Console.WriteLine("The sum equals: " + sum);*/
        
        //Ex5
        /*int start = Convert.ToInt32(Console.ReadLine());
        int end = Convert.ToInt32(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            Console.Write(Convert.ToChar(i) + " ");
        }*/
        
        //Ex6
        /*int n = Convert.ToInt32(Console.ReadLine());
        for (char i = 'a'; i < 'a' + n; i++) {
            for (int j = 'a'; j < 'a' + n; j++) {
                for (int k = 'a'; k < 'a' + n; k++) {
                    Console.WriteLine($"{Convert.ToChar(i)}{Convert.ToChar(j)}{Convert.ToChar(k)}");
                }
            }
        }*/
        
        //Ex7
        /*int n = Convert.ToInt32(Console.ReadLine());
        int capacity;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            capacity = Convert.ToInt32(Console.ReadLine());
            if(capacity + sum <= 255)
            {
                sum += capacity;
            } 
            else 
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }
        
        Console.WriteLine(sum);*/
        
        //Ex8
        int n = Convert.ToInt32(Console.ReadLine());
        double maxVolume = Double.MinValue;
        string brand = "";
        string biggestBrand = "";

        for (int i = 0; i < n ; i++) 
        {
            brand = Console.ReadLine();
            double rad = Convert.ToDouble(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            double volume = Math.PI * rad * rad * height;
            if(volume > maxVolume)
            {
                maxVolume = volume;
                biggestBrand = brand;
            }
        }
        
        Console.WriteLine(biggestBrand);
    }

}