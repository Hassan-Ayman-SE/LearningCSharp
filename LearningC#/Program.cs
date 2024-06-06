﻿namespace LearningC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////V 1 + 2
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("My Name is Hassan");
            //Console.Beep();
            ////This is a comment in c#
            //===============================================================================
            ////V 3
            //int x; // declaration
            //x = 123; // initialization

            //int y = 321; // declaration + initialization
            //int z = x + y;

            //int age = 21; // whole integer
            //double height = 174.5; // decimal number
            //bool alive = true; //true or false
            //char symbol = '@'; // single character
            //String name = "Hassan"; // a series of characters

            //Console.WriteLine("Hello " + name);
            //Console.WriteLine("Your age is " + age);
            //Console.WriteLine("Your height is " + height + "cm");
            //Console.WriteLine("Are you alive? " + alive);
            //Console.WriteLine("Your symbol is: " + symbol);

            //String userName = symbol + name;

            //Console.WriteLine("Your username is: " + userName);
            //===============================================================================
            //// V 4

            //// constants  = immutable values which are known at compile time
            ////              and do not change for the life of the program

            //const double pi = 3.14;

            ////pi = 420; //can't change this constant

            //Console.WriteLine(pi);
            //===============================================================================
            ////V 5

            //// type casting = Converting a value to a different data type
            ////                Useful when we accept user input (string)
            ////                Different data types can do different things

            //double a = 3.14;
            //int b = Convert.ToInt32(a);

            //int c = 123;
            //double d = Convert.ToDouble(c);

            //int e = 321;
            //String f = Convert.ToString(e);

            //String g = "$";
            //char h = Convert.ToChar(g);

            //String i = "true";
            //bool j = Convert.ToBoolean(i);

            //Console.WriteLine(b.GetType());
            //Console.WriteLine(d.GetType());
            //Console.WriteLine(f.GetType());
            //Console.WriteLine(h.GetType());
            //Console.WriteLine(j.GetType());
            //===============================================================================
            ////V 6 
            //Console.WriteLine("What's your name?");
            //String yourName = Console.ReadLine();

            //Console.WriteLine("What's your age?");
            //int yourAge = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hello " + yourName);
            //Console.WriteLine("You are " + yourAge + " years old");
            //===============================================================================
            ////V 7

            //int friends = 5;

            //friends = friends + 1;
            ////friends += 1;
            ////friends++;

            ////friends = friends - 1;
            ////friends -= 1;
            ////friends--;

            ////friends = friends * 2;
            ////friends *= 2;

            ////friends = friends / 2;
            ////friends /= 2;

            ////int remainder = friends % 2;
            ////Console.WriteLine(remainder);

            //Console.WriteLine(friends);

            //===============================================================================
            ////V 8

            //double xx = 3;
            //double yy = 5;

            //double aa = Math.Pow(xx, 2);
            //double bb = Math.Sqrt(xx);
            //double cc = Math.Abs(xx);
            //double dd = Math.Round(xx);
            //double ee = Math.Ceiling(xx);
            //double ff = Math.Floor(xx);
            //double gg = Math.Max(xx, yy);
            //double hh = Math.Min(xx, yy);

            //Console.WriteLine(aa);

            //===============================================================================
            ////V 9

            //Random random = new Random();

            //int num1 = random.Next(1, 7);
            //int num2 = random.Next(1, 7);
            //int num3 = random.Next(1, 7);

            ////double num = random.NextDouble();

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //===============================================================================
            ////V 10 
            //Console.WriteLine("Enter side A: ");
            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter side B: ");
            //double b = Convert.ToDouble(Console.ReadLine());

            //double c = Math.Sqrt((a * a) + (b * b));

            //Console.WriteLine("The hypotenuse is: " + c);
            //===============================================================================
            //V 11 

            //String fullName = "Hassan Karraz";
            //String phoneNumber = "123-456-7890";

            ////fullName = fullName.ToUpper();
            ////fullName = fullName.ToLower();
            ////Console.WriteLine(fullName);

            ////phoneNumber = phoneNumber.Replace("-","");
            ////Console.WriteLine(phoneNumber);

            ////String userName = fullName.Insert(0,"Mr.");
            ////Console.WriteLine(userName);

            ////Console.WriteLine(fullName.Length);

            //String firstName = fullName.Substring(0, 6);
            //String lastName = fullName.Substring(7);

            //Console.WriteLine(firstName);
            //Console.WriteLine(lastName);
            //===============================================================================

            ////V 12


            ////if statement = a basic form of decision making

            //Console.WriteLine("Please enter your name: ");
            //String name = Console.ReadLine();

            //if (name == "")
            //{
            //    Console.WriteLine("You did not enter your name!");
            //}
            //else
            //{
            //    Console.WriteLine("Hello " + name);
            //}
            //===============================================================================
            ////V 13

            //// switch = an efficient alternative to many else if statements

            //Console.WriteLine("What day is it today?");
            //String day = Console.ReadLine();

            //switch (day)
            //{
            //    case "Monday":
            //        Console.WriteLine("It's Monday!");
            //        break;
            //    case "Tuesday":
            //        Console.WriteLine("It's Tuesday!");
            //        break;
            //    case "Wednesday":
            //        Console.WriteLine("It's Wednesday!");
            //        break;
            //    case "Thursday":
            //        Console.WriteLine("It's Thursday!");
            //        break;
            //    case "Friday":
            //        Console.WriteLine("It's Friday!");
            //        break;
            //    case "Saturday":
            //        Console.WriteLine("It's Saturday!");
            //        break;
            //    case "Sunday":
            //        Console.WriteLine("It's Sunday!");
            //        break;
            //    default:
            //        Console.WriteLine(day + " is not a day!");
            //        break;
            //}

            //===============================================================================
            ////V 14
            //// logical operators = Can be used to check if more than 1 condition is true/false

            //// && (AND)
            //// || (OR)

            //Console.WriteLine("What's the temperature outside: (C)");
            //double temp = Convert.ToDouble(Console.ReadLine());

            //if (temp >= 10 && temp <= 25)
            //{
            //    Console.WriteLine("It's warm outside!");
            //}
            //else if (temp <= -50 || temp >= 50)
            //{
            //    Console.WriteLine("DO NOT GO OUTSIDE!");
            //}
            //===============================================================================
            //V 15 

            // while loop = repeats some code while some condition remains true

            String name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);
            //===============================================================================
            // V 16
            // for loop = repeats some code a FINITE amount of times

            // Count up to 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Count down from 10
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("HAPPY NEW YEAR!");

            //===============================================================================
            //V 17

            // nested loops = loops inside of other loops
            //                Uses vary. Used a lot in sorting algorithms

            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            //===============================================================================
            //==============Exercises==============
            //V 18
            //Random random = new Random();
            //bool playAgain = true;
            //int min = 1;
            //int max = 100;
            //int guess;
            //int number;
            //int guesses;
            //String response;

            //while (playAgain)
            //{
            //    guess = 0;
            //    guesses = 0;
            //    response = "";
            //    number = random.Next(min, max + 1);

            //    while (guess != number)
            //    {
            //        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
            //        guess = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Guess: " + guess);

            //        if (guess > number)
            //        {
            //            Console.WriteLine(guess + " is to high!");
            //        }
            //        else if (guess < number)
            //        {
            //            Console.WriteLine(guess + " is to low!");
            //        }
            //        guesses++;
            //    }
            //    Console.WriteLine("Number: " + number);
            //    Console.WriteLine("YOU WIN!");
            //    Console.WriteLine("Guesses: " + guesses);

            //    Console.WriteLine("Would you like to play again (Y/N): ");
            //    response = Console.ReadLine();
            //    response = response.ToUpper();

            //    if (response == "Y")
            //    {
            //        playAgain = true;
            //    }
            //    else
            //    {
            //        playAgain = false;
            //    }
            //}

            //Console.WriteLine("Thanks for playing! ... I guess");

            //===============================================================================
            //V 19
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }


                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }

            Console.WriteLine("Thanks for playing!");
            //===============================================================================
            //V 20
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("Would you like to continue? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            //===============================================================================
            //V 21
            // array = a variable that can store multiple values. fixed size

            //String[] cars = {"BMW", "Mustang", "Corvette"};

            //String[] cars = new string[3];

            //cars[0] = "Tesla";
            //cars[1] = "Mustang";
            //cars[2] = "Corvette";

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            //===============================================================================
            //V 22
            // foreach loop = a simpler way to iterate over an array, but it's less flexible

            String[] cars = { "BMW", "Mustang", "Corvette" };

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            //===============================================================================
            //V 23
            /*
             inside the main

            / method  = performs a section of code, whenever it's called "invoked".
            //           benefit = Let's us reuse code w/o writing it multiple times
            //           Good practice is to capitalize method names (I forgot in this video)

            String name = "Bro";
            int age = 21;

            SingHappyBirthday(name, age);

             */

            static void SingHappyBirthday(String birthdayBoy, int yearsOld)
            {
                Console.WriteLine("Happy birthday to you!");
                Console.WriteLine("Happy birthday to you!");
                Console.WriteLine("Happy birthday dear " + birthdayBoy);
                Console.WriteLine("You are " + yearsOld + " years old!");
                Console.WriteLine("Happy birthday to you!");
                Console.WriteLine();
            }

            //===============================================================================

            //V 24
            /*INSIDE MAIN
                         // return  = returns data back to the place where a method is invoked

            double x;
            double y;
            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine(result);

             */
            static double Multiply(double x, double y)
            {
                return x * y;
            }
            //===============================================================================
            //V 25
            // method overloading  = methods share same name, but different parameters
            //                       name + parameters = signature
            //                       methods must have a unique signature

            //===============================================================================
            //V 26
            /*INSIDE MAIN
             //params keyword = a method parameter that takes a variable number of arguments.
            //                 The parameter type must be a single - dimensional array

            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

            Console.WriteLine(total);
             */

            static double CheckOut(params double[] prices)
            {
                double total = 0;

                foreach (double price in prices)
                {
                    total += price;
                }
                return total;
            }

            //===============================================================================
            //V 27




            //===============================================================================
            // V 28

            Console.ReadKey();
        }
    }
}
