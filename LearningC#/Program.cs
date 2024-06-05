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

            //// V 4

            //// constants  = immutable values which are known at compile time
            ////              and do not change for the life of the program

            //const double pi = 3.14;

            ////pi = 420; //can't change this constant

            //Console.WriteLine(pi);

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

            ////V 6 
            //Console.WriteLine("What's your name?");
            //String yourName = Console.ReadLine();

            //Console.WriteLine("What's your age?");
            //int yourAge = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hello " + yourName);
            //Console.WriteLine("You are " + yourAge + " years old");

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


            ////V 9

            //Random random = new Random();

            //int num1 = random.Next(1, 7);
            //int num2 = random.Next(1, 7);
            //int num3 = random.Next(1, 7);

            ////double num = random.NextDouble();

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);

            ////V 10 
            //Console.WriteLine("Enter side A: ");
            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter side B: ");
            //double b = Convert.ToDouble(Console.ReadLine());

            //double c = Math.Sqrt((a * a) + (b * b));

            //Console.WriteLine("The hypotenuse is: " + c);

            //V 11 

            String fullName = "Hassan Karraz";
            String phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            //phoneNumber = phoneNumber.Replace("-","");
            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0,"Mr.");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            String firstName = fullName.Substring(0, 6);
            String lastName = fullName.Substring(7);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            //V 12


            //if statement = a basic form of decision making

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }

            //V 13

            // switch = an efficient alternative to many else if statements

            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday!");
                    break;
                default:
                    Console.WriteLine(day + " is not a day!");
                    break;
            }


            //V 14
            // logical operators = Can be used to check if more than 1 condition is true/false

            // && (AND)
            // || (OR)

            Console.WriteLine("What's the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("DO NOT GO OUTSIDE!");
            }




            Console.ReadKey();
        }
    }
}
