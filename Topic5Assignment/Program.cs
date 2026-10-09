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
            int answer;
            double score = 0, percentScore = 0;

            Console.WriteLine("Here is the best Mini-Quiz ever. It is about animals.");

            Console.WriteLine();

            Console.WriteLine("Question 1: What animal is known for barking? Type the number of your answer.");
            Console.WriteLine("1.) Dog  2.) Cat  3.) Zebra  4.) Gerbil");
            Int32.TryParse(Console.ReadLine(), out answer);
            if (answer == 1)
            {
                Console.WriteLine();
                Console.WriteLine("You are correct!");
                score = score + 1;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Wrong...");
            }

            Console.WriteLine();
            Console.WriteLine("Question 2: How many legs does a spider have?");
            Console.WriteLine("1.) 4  2.) 16  3.) 20  4.) 8");
            Int32.TryParse(Console.ReadLine(), out answer);
            if (answer == 4)
            {
                Console.WriteLine();
                Console.WriteLine("You are correct!");
                score = score + 1;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Wrong...");
            }

            Console.WriteLine();
            Console.WriteLine("Question 3: What is a baby kangaroo called?");
            Console.WriteLine("1.) Johnny  2.) Bill  3.) Joey  4.) Steven");
            Int32.TryParse(Console.ReadLine(), out answer);
            if (answer == 3)
            {
                Console.WriteLine();
                Console.WriteLine("You are correct!");
                score = score + 1;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Wrong...");
            }

            Console.WriteLine();
            Console.WriteLine("Question 4: What is the animal with a long neck and spots?");
            Console.WriteLine("1.) Elephant  2.) Giraffe  3.) Pony  4.) Turtle");
            Int32.TryParse(Console.ReadLine(), out answer);
            if (answer == 2)
            {
                Console.WriteLine();
                Console.WriteLine("You are correct!");
                score = score + 1;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Wrong...");
            }

            Console.WriteLine();
            Console.WriteLine("Your final score is: " + score);

            if (score == 4)
            {
                percentScore = score / 4.00;
                Console.WriteLine("You did perfect! " + Math.Round(percentScore * 100, 2) + "%.");
            }

            else if (score == 3)
            {
                percentScore = score / 4.00;
                Console.WriteLine("Alright! " + Math.Round(percentScore * 100, 2) + "%.");
            }

            else if (score == 2)
            {
                percentScore = score / 4.00;
                Console.WriteLine("Half marks. " + Math.Round(percentScore * 100, 2) + "%.");
            }

            else if (score == 1)
            {
                percentScore = score / 4.00;
                Console.WriteLine("You suck! Go to school. " + Math.Round(percentScore * 100, 2) + "%.");
            }

            else if (score == 0)
            {
                percentScore = score / 4.00;
                Console.WriteLine("You suck, A LOT! Go to school. " + Math.Round(percentScore * 100, 2) + "%.");
            }
        }
    }
}
