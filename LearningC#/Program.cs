namespace LearningC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //V 1 + 2
            Console.WriteLine("Hello, World!");
            Console.WriteLine("My Name is Hassan");
            Console.Beep();
            //This is a comment in c#

            //V 3
            int x; // declaration
            x = 123; // initialization

            int y = 321; // declaration + initialization
            int z = x + y;

            int age = 21; // whole integer
            double height = 174.5; // decimal number
            bool alive = true; //true or false
            char symbol = '@'; // single character
            String name = "Hassan"; // a series of characters

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            String userName = symbol + name;

            Console.WriteLine("Your username is: " + userName);

            // V 4

            // constants  = immutable values which are known at compile time
            //              and do not change for the life of the program

            const double pi = 3.14;

            //pi = 420; //can't change this constant

            Console.WriteLine(pi);

            //V 5

            // type casting = Converting a value to a different data type
            //                Useful when we accept user input (string)
            //                Different data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());

            //V 6 
            Console.WriteLine("What's your name?");
            String yourName = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + yourName);
            Console.WriteLine("You are " + yourAge + " years old");

            //V 7

            int friends = 5;

            friends = friends + 1;
            //friends += 1;
            //friends++;

            //friends = friends - 1;
            //friends -= 1;
            //friends--;

            //friends = friends * 2;
            //friends *= 2;

            //friends = friends / 2;
            //friends /= 2;

            //int remainder = friends % 2;
            //Console.WriteLine(remainder);

            Console.WriteLine(friends);



            Console.ReadKey();
        }
    }
}
