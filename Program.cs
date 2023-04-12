namespace Prog_120_S23_Lecture_3_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program just ran") ;
            Console.Write("Please enter your name: ");
            string userInput = Console.ReadLine();
            Console.Write("Please enter your password: ");

            string password = Console.ReadLine();
         
            if(userInput == "Will" && password == "Cram")
            {
                for (int i = 0; i < userInput.Length; i++)
                {
                    Console.WriteLine(userInput[i]);
                }
            }
            else
            {
                Console.WriteLine("That is invalid");
            }


            // Input - Console.Readline
        }

        public static void ExampleDataTypes()
        {
            // Four main variable types
            // strings - words
            // int - whole numbers
            // double - decimal numbers
            // bool - true or false


            // variable name is unique to scope

            // Data Types
            // Primitive Data Types - basic
            // string and char
            // char data type can only have ONE character, defined with single quotes ''
            // char can be converted into a whole number
            char letterA = 'A';
            // convert into a number with (int)
            // string data type can have MULTIPLE characters, define with double quotes ""
            // array is a collection of a single type of variables.
            // a string is an array of characters
            // get a single character with [index]
            string name = "Danna";
            Console.WriteLine(name);

            // Whole Number - Technical Term: Integral - Most Common type is int
            int number1 = 2;
            int number2 = 4;
            int sum = number1 + number2;

            Console.WriteLine(sum);

            // Byte type
            byte oneGig = 0;

            // Double - Floating Point - decimal number
            double doubleNumber = 5.5;
            float floatingPointNumber = 14.5f;
            decimal dollarValue = 15.3m;
            Console.WriteLine(doubleNumber);

            // last Primitive type
            // boolean - true / false
            // 0 or 1
            // bool
            bool isRaining = true;
            bool isSunny = false;
        }

        public static void ExampleVariables()
        {
            string name = "Will";
            // Variables
            // Declaring a variable
            // Delcares - name - value

            // Quick tip of the day - cw tab to quickly display writeline
            Console.WriteLine(name);

            name = "Danna";
            Console.WriteLine(name);
        }

        // Inputs
        // Outputs
        // Console.Write() and WriteLine()
        // Loops
        // COnditions
        // Variables
        // Operations

    }
}