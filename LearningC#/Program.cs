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



            Console.ReadKey();
        }
    }
}
