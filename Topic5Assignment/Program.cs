namespace Topic5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Please pick a program to run, out of these:");
            Console.WriteLine("1. Space Boxing");
            Console.WriteLine("2. Simple Calculator");
            Console.WriteLine("3. Mini Quiz");
            Int32.TryParse(Console.ReadLine(), out choice);
            if(choice == 1)
            {
                Console.Clear();
                Task1();
            }
            else if(choice == 2)
            {
                Console.Clear();
                Task2();
            }
            else if(choice == 3)
            {
                Console.Clear();
                Task3();
            }
            else
            {
                Console.WriteLine("Not valid input. Try again. Press ENTER to exit.");
                Console.ReadLine();
            }
        }
        public static void Task1()
        {
            double earthWeight, otherWeight;
            int whichPlanet;

            Console.WriteLine("Please enter your current earth weight in lbs.: ");
            Double.TryParse(Console.ReadLine(), out earthWeight);
            Console.WriteLine();
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("1. Venus    2. Mars     3. Jupiter");
            Console.WriteLine("4. Saturn   5. Uranus   6. Neptune");
            Console.WriteLine();
            Console.WriteLine("Which planet do you want information for?");
            Int32.TryParse(Console.ReadLine(), out whichPlanet);
            if(whichPlanet == 1)
            {
                otherWeight = earthWeight * 0.78;
                Console.WriteLine("Your weight on Venus is: " + Math.Round(otherWeight, 2) + " lbs.");
            }
            else if(whichPlanet == 2)
            {
                otherWeight = earthWeight * 0.39;
                Console.WriteLine("Your weight on Mars is: " + Math.Round(otherWeight, 2) + " lbs.");
            }
            else if(whichPlanet == 3)
            {
                otherWeight = earthWeight * 2.65;
                Console.WriteLine("Your weight on Jupiter is: " + Math.Round(otherWeight, 2) + " lbs.");
            }
            else if(whichPlanet == 4)
            {
                otherWeight = earthWeight * 1.17;
                Console.WriteLine("Your weight on Saturn is: " + Math.Round(otherWeight, 2) + " lbs.");
            }
            else if(whichPlanet == 5)
            {
                otherWeight = earthWeight * 1.05;
                Console.WriteLine("Your weight on Uranus is: " + Math.Round(otherWeight, 2) + " lbs.");
            }
            else if(whichPlanet == 6)
            {
                otherWeight = earthWeight * 1.23;
                Console.WriteLine("Your weight on Neptune is: " + Math.Round(otherWeight, 2) + " lbs.");
            }
            else
            {
                Console.WriteLine("Not valid input. Please try that again.");
            }
        }
        public static void Task2()
        {
            int operatorChoice;
            double num1, num2, answer;

            Console.WriteLine("Here is a simple calculator. I can do these operations:");
            Console.WriteLine("1. +  2. -");
            Console.WriteLine("3. ×  4. \u00F7");
            Console.WriteLine("Please enter your choice below:");
            Int32.TryParse(Console.ReadLine(), out operatorChoice);

            Console.WriteLine();

            Console.WriteLine("Enter the first number: ");
            Double.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Enter the second number: ");
            Double.TryParse(Console.ReadLine(), out num2);

            if(operatorChoice == 1)
            {
                answer = num1 + num2;
                Console.WriteLine("The answer to " + num1 + " + " + num2 + " is " + Math.Round(answer, 2) + ".");
            }

            else if(operatorChoice == 2)
            {
                answer = num1 - num2;
                Console.WriteLine("The answer to " + num1 + " - " + num2 + " is " + Math.Round(answer, 2) + ".");
            }

            else if (operatorChoice == 3)
            {
                answer = num1 * num2;
                Console.WriteLine("The answer to " + num1 + " × " + num2 + " is " + Math.Round(answer, 2) + ".");
            }

            else if (operatorChoice == 4)
            {
                answer = num1 / num2;
                Console.WriteLine("The answer to " + num1 + " \u00F7 " + num2 + " is " + Math.Round(answer, 2) + ".");
            }

            else
            {
                Console.WriteLine("Please enter valid input.");
            }
        }
        public static void Task3()
        {
            // finish task 3
        }
    }
}
