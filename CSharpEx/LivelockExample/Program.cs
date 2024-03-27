namespace LivelockExample;

class Program
{
    public class Spoon
    {
        private Diner owner;
        public Spoon(Diner d) { owner = d; }
        public Diner GetOwner() { return owner; }
        public void SetOwner(Diner d) { owner = d; }
        public void Use()
        {
            Console.WriteLine($"{owner.Name} has eaten!");
        }
    }

    public class Diner
    {
        private string name;
        private bool isHungry;
        public Diner(string n) { name = n; isHungry = true; }
        public string Name { get { return name; } }
        public bool IsHungry { get { return isHungry; } }
        public void EatWith(Spoon spoon, Diner spouse)
        {
            while (isHungry)
            {
                if (spoon.GetOwner() != this)
                {
                    try { Thread.Sleep(1); }
                    catch (ThreadInterruptedException e) { continue; }
                    continue;
                }

                if (spouse.IsHungry)
                {
                    Console.WriteLine($"{name}: You eat first my darling {spouse.Name}!");
                    spoon.SetOwner(spouse);
                    continue;
                }

                spoon.Use();
                isHungry = false;
                Console.WriteLine($"{name}: I am stuffed, my darling {spouse.Name}!");
                spoon.SetOwner(spouse);
            }
        }
    }

    public static void Main(string[] args)
    {
        Diner husband = new Diner("Bob");
        Diner wife = new Diner("Alice");
        Spoon s = new Spoon(husband);
        new Thread(() => { husband.EatWith(s, wife); }).Start();
        new Thread(() => { wife.EatWith(s, husband); }).Start();
    }
}