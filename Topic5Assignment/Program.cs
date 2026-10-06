namespace Topic5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }
        public static void Task1()
        {
            double earthWeight, otherWeight;
            int whichPlanet;

            Console.WriteLine("Please enter your current earth weight: ");
            Double.TryParse(Console.ReadLine(), out earthWeight);
            Console.WriteLine();
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("1. Venus    2. Mars     3. Jupiter");
            Console.WriteLine("4. Saturn   5. Uranus   6. Neptune");
            Console.WriteLine();
            Console.WriteLine("Which planet do you want information for?");
            Int32.TryParse(Console.ReadLine(), out whichPlanet);
            if (whichPlanet >= 1 && whichPlanet <= 6)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }
}
