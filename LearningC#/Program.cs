using System.Security.Cryptography;
using System.Collections.Generic;
using System.Numerics;

namespace LearningC_
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

            //String name = "";

            //while (name == "")
            //{
            //    Console.Write("Enter your name: ");
            //    name = Console.ReadLine();
            //}

            //Console.WriteLine("Hello " + name);
            //===============================================================================
            // V 16
            // for loop = repeats some code a FINITE amount of times

            // Count up to 10
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //// Count down from 10
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("HAPPY NEW YEAR!");

            //===============================================================================
            //V 17

            // nested loops = loops inside of other loops
            //                Uses vary. Used a lot in sorting algorithms

            //Console.Write("How many rows?: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.Write("How many columns?: ");
            //int columns = Convert.ToInt32(Console.ReadLine());

            //Console.Write("What symbol: ");
            //String symbol = Console.ReadLine();

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(symbol);
            //    }
            //    Console.WriteLine();
            //}
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
            //Random random = new Random();
            //bool playAgain = true;
            //String player;
            //String computer;
            //String answer;

            //while (playAgain)
            //{
            //    player = "";
            //    computer = "";
            //    answer = "";

            //    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            //    {
            //        Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
            //        player = Console.ReadLine();
            //        player = player.ToUpper();
            //    }


            //    switch (random.Next(1, 4))
            //    {
            //        case 1:
            //            computer = "ROCK";
            //            break;
            //        case 2:
            //            computer = "PAPER";
            //            break;
            //        case 3:
            //            computer = "SCISSORS";
            //            break;
            //    }

            //    Console.WriteLine("Player: " + player);
            //    Console.WriteLine("Computer: " + computer);

            //    switch (player)
            //    {
            //        case "ROCK":
            //            if (computer == "ROCK")
            //            {
            //                Console.WriteLine("It's a draw!");
            //            }
            //            else if (computer == "PAPER")
            //            {
            //                Console.WriteLine("You lose!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("You win!");
            //            }
            //            break;
            //        case "PAPER":
            //            if (computer == "ROCK")
            //            {
            //                Console.WriteLine("You win!");
            //            }
            //            else if (computer == "PAPER")
            //            {
            //                Console.WriteLine("It's a draw!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("You lose!");
            //            }
            //            break;
            //        case "SCISSORS":
            //            if (computer == "ROCK")
            //            {
            //                Console.WriteLine("You lose!");
            //            }
            //            else if (computer == "PAPER")
            //            {
            //                Console.WriteLine("You win!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("It's a draw!");
            //            }
            //            break;
            //    }

            //    Console.Write("Would you like to play again (Y/N): ");
            //    answer = Console.ReadLine();
            //    answer = answer.ToUpper();

            //    if (answer == "Y")
            //    {
            //        playAgain = true;
            //    }
            //    else
            //    {
            //        playAgain = false;
            //    }

            //}

            //Console.WriteLine("Thanks for playing!");
            //===============================================================================
            //V 20
            //do
            //{
            //    double num1 = 0;
            //    double num2 = 0;
            //    double result = 0;

            //    Console.WriteLine("------------------");
            //    Console.WriteLine("Calculator Program");
            //    Console.WriteLine("------------------");

            //    Console.Write("Enter number 1: ");
            //    num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter number 2: ");
            //    num2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Enter an option: ");
            //    Console.WriteLine("\t+ : Add");
            //    Console.WriteLine("\t- : Subtract");
            //    Console.WriteLine("\t* : Multiply");
            //    Console.WriteLine("\t/ : Divide");
            //    Console.Write("Enter an option: ");


            //    switch (Console.ReadLine())
            //    {
            //        case "+":
            //            result = num1 + num2;
            //            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            //            break;
            //        case "-":
            //            result = num1 - num2;
            //            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            //            break;
            //        case "*":
            //            result = num1 * num2;
            //            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            //            break;
            //        case "/":
            //            result = num1 / num2;
            //            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            //            break;
            //        default:
            //            Console.WriteLine("That was not a valid option");
            //            break;
            //    }
            //    Console.Write("Would you like to continue? (Y = yes, N = No): ");
            //} while (Console.ReadLine().ToUpper() == "Y");

            //Console.WriteLine("Bye!");
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

            //String[] cars = { "BMW", "Mustang", "Corvette" };

            //foreach (String car in cars)
            //{
            //    Console.WriteLine(car);
            //}

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

            //static void SingHappyBirthday(String birthdayBoy, int yearsOld)
            //{
            //    Console.WriteLine("Happy birthday to you!");
            //    Console.WriteLine("Happy birthday to you!");
            //    Console.WriteLine("Happy birthday dear " + birthdayBoy);
            //    Console.WriteLine("You are " + yearsOld + " years old!");
            //    Console.WriteLine("Happy birthday to you!");
            //    Console.WriteLine();
            //}

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
            //static double Multiply(double x, double y)
            //{
            //    return x * y;
            //}
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

            //static double CheckOut(params double[] prices)
            //{
            //    double total = 0;

            //    foreach (double price in prices)
            //    {
            //        total += price;
            //    }
            //    return total;
            //}

            //===============================================================================
            //V 27
            // exception = errors that occur during execution

            //        try     = try some code that is considered "dangerous"
            //        catch   = catches and handles exceptions when they occur
            //        finally = always executes regardless if exception is caught or not

            //int x;
            //int y;
            //double result;

            //try
            //{
            //    Console.Write("Enter number 1: ");
            //    x = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter number 2: ");
            //    y = Convert.ToInt32(Console.ReadLine());

            //    result = x / y;

            //    Console.WriteLine("result: " + result);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Enter ONLY numbers PLEASE!");
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("You can't divide by zero! IDIOT!");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Something went wrong!");
            //}
            //finally
            //{
            //    Console.WriteLine("Thanks for visiting!");
            //}

            //===============================================================================
            // V 28

            // conditional operator = used in conditional assignment if a condition is true/false

            //(condition) ? x : y

            //double temperature = 20;
            //String message;

            //message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

            //Console.WriteLine(message);

            //===============================================================================
            // V 29
            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders

            //String firstName = "Bro";
            //String lastName = "Code";
            //int age = 21;

            //Console.WriteLine($"Hello {firstName} {lastName}.");
            //Console.WriteLine($"You are {age,-10} old.");





            //===============================================================================
            // V 30
            //String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
            //                                       { "Corvette", "Camaro", "Silverado" },
            //                                       { "Corolla", "Camry", "Rav4" }
            //                                     };

            //parkingLot[0, 2] = "Fusion";
            //parkingLot[2, 0] = "Tacoma";
            ///*
            //foreach(String car in parkingLot)
            //{
            //    Console.WriteLine(car);
            //}
            //*/
            //for (int i = 0; i < parkingLot.GetLength(0); i++)
            //{
            //    for (int j = 0; j < parkingLot.GetLength(1); j++)
            //    {
            //        Console.Write(parkingLot[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //===============================================================================
            // V 31
            // class = A bundle of related code.
            //              Can be used as a blueprint to create objects (OOP)

            //Messages.Hello();
            //Messages.Waiting();
            //Messages.Bye();



            //===============================================================================
            // V 32
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            //Human human1 = new Human();
            //Human human2 = new Human();

            //human1.name = "Rick";
            //human1.age = 65;

            //human2.name = "Morty";
            //human2.age = 16;

            //human1.Eat();
            //human1.Sleep();

            //human2.Eat();
            //human2.Sleep();

            //===============================================================================
            // V 33
            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            //Car car1 = new Car("Ford", "Mustang", 2022, "red");
            //Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            //car1.Drive();
            //car2.Drive();





            //===============================================================================
            // V 34
            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            //Car car3 = new Car("Ford", "Mustang", 2022, "red");
            //Car car4 = new Car("Chevy", "Corvette", 2021, "blue");
            //Car car5 = new Car("Chevy", "Corvette", 2021, "blue");

            //Console.WriteLine(Car.numberOfCars);
            //Car.StartRace();

            //===============================================================================
            // V 35
            // overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature

            //Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");


            //===============================================================================
            // V 36
            // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

            //Bicycle bicycle = new Bicycle();

            //Console.WriteLine(bicycle.speed);
            //Console.WriteLine(bicycle.wheels);
            //bicycle.go();


            //class Bicycle : Vehicle
            //{
            //    public int wheels = 2;
            //}


            //===============================================================================
            // V 37 
            //Check V 37 to see ex.
            // abstract classes =  modifier that indicates missing components or incomplete implementation


            //===============================================================================
            // V 38
            //Array of objects

            //Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

            //foreach (Car car in garage)
            //{
            //    Console.WriteLine(car.model);
            //}


            //===============================================================================
            // V 39

            /*
             objects as arguments:

        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }


             */

            //===============================================================================
            // V 40
            /*
            //method overriding = provides a new version of a method inherited from a parent class
            //                    inherited method must be: abstract, virtual, or already overriden
            //                    Used with ToString(), polymorphism 

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            THE CLASSES
                class Animal 
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }
    class Cat : Animal
    {

    }
}

*/

            //===============================================================================
            // V 41
            //ToString() = converts an object to its string representation so that it is suitable for display

            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car.ToString());


            //===============================================================================
            // V 42 check vedio please 42
            // polymorphism = Greek word that means to "have many forms"
            //                Objects can be identified by more than one type
            //                Ex. A Dog is also: Canine, Animal, Organism

            //Car car = new Car();
            //Bicycle bicycle = new Bicycle();
            //Boat boat = new Boat();

            //Vehicle[] vehicles = { car, bicycle, boat };

            //foreach (Vehicle vehicle in vehicles)
            //{
            //    vehicle.Go();
            //}



            //===============================================================================
            // V 43
            /*
                         // interface = defines a "contract" that all the classes inheriting from should follow

            //             An interface declares "what a class should have"
            //             An inheriting class defines "how it should do it"

            //             Benefit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();

            //CLASSES
            
        {
            void Flee();
        }
        interface IPredator
        {
            void Hunt();
        }
        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }
        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food!");
            }
        }
        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away!");
            }
            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        } 
   

*/


            //===============================================================================
            // V 44
            //// List = data structure that represents a list of objects that can be accessed by index.
            ////        Similar to array, but can dynamically increase/decrease in size 
            ////        using System.Collections.Generic;

            //List<String> food = new List<String>();

            //food.Add("pizza");
            //food.Add("hamburger");
            //food.Add("hotdog");
            //food.Add("fries");

            ////Console.WriteLine(food[0]);
            ////Console.WriteLine(food[1]);
            ////Console.WriteLine(food[2]);
            ////Console.WriteLine(food[3]);

            ////food.Remove("fries");
            ////food.Insert(0, "sushi");
            ////Console.WriteLine(food.Count);
            ////Console.WriteLine(food.IndexOf("pizza"));
            ////Console.WriteLine(food.LastIndexOf("fries"));
            ////Console.WriteLine(food.Contains("pizza"));
            ////food.Sort();
            ////food.Reverse();
            ////food.Clear();
            ////String[] foodArray = food.ToArray();

            //foreach (String item in food)
            //{
            //    Console.WriteLine(item);
            //}




            //===============================================================================
            // V 45
            //List<Player> players = new List<Player>();

            //players.Add(new Player("Chad"));
            //players.Add(new Player("Steve"));
            //players.Add(new Player("Karen"));

            //foreach (Player player in players)
            //{
            //    Console.WriteLine(player);
            //}


            //===============================================================================
            // V 46
            //getters & setters = add security to fields by encapsulation
            //                    They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // set accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)

            //Car car = new Car(400);

            //car.Speed = 1000000000;

            //Console.WriteLine(car.Speed);

            //     class Car
            //{
            //    private int speed;

            //    public Car(int speed)
            //    {
            //        Speed = speed;
            //    }

            //    public int Speed
            //    {
            //        get { return speed; }
            //        set
            //        {
            //            if (value > 500)
            //            {
            //                speed = 500;
            //            }
            //            else
            //            {
            //                speed = value;
            //            }
            //        }
            //    }




            //===============================================================================
            // V 47



            //===============================================================================
            // V 48



            //===============================================================================
            // V 49



            //===============================FINISH================================================
            // V 50



            Console.ReadKey();
        }
    }
}
