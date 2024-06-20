using System;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*To take inputs larger than 10,000,000 our input variable needs to be of value type "int" which has a 
            size of signed 32-bit integer and can assume values in the range -2147483648 to 2147483647.*/

            //Type a signed integer/whole-number of your choice.
            Console.WriteLine("Enter your signed integer: ");

            //creating an integer variable, getting the user input from the keyboard(as a string), converting it to an integer and storing it.
            int userInteger = Convert.ToInt32(Console.ReadLine());

            //MULTIPLICATION

            //creating an integer variable, multiplying the user input by 50, and storing the result in the new variable.
            int userProduct = userInteger * 50;

            //Printing the value of the variable to display the result of the multiplication operation.
            Console.WriteLine("The result of your input multiplied by 50 is: " + userProduct);

            //ADDITION

            //creating an integer variable, adding the user input to 25, and storing the result in the new variable.
            int userSum = userInteger + 25;

            //Printing the value of the variable to display the result of the addition operation.
            Console.WriteLine("The result of adding 25 to your input is: " + userSum);

            //DIVISION

            //The number 12.5 is of value type  "double" which represents the 64-bit double-precision floating point type.

            /*To divide an integer by a value of type "double", I note that the "int" value type is compatible with the "double" 
            value type, meaning the two data types can be operated together, however, the value type for the result will be 
            "double" due to its higher precision.*/

            //creating a double variable, dividing the user input by 12.5, and storing the result in the new variable.
            double userQuotient = userInteger / 12.5;

            //Printing the value of the variable to display the result of the division operation.
            Console.WriteLine("The quotient from dividing your input by 12.5 is: " + userQuotient);

            //GREATER THAN COMPARISON OPERATOR

            //The return value of a comparison is either True or False. These values are known as Boolean values.

            Console.WriteLine(userInteger > 50); //returns True if user input is greater than 50, otherwise it returns False.

            //INTEGER DIVISION

            /*An interesting behaviour for integers is that integer division ALWAYS produces an integer result rounded down, even 
            when you'd expect the result to include a decimal or fractional part. Although integer division truncates 
            the result, the remainder of the operation can always be obtained by using the modulo operator, the % character.*/

            //dividing the user input by 7.

            //creating an integer variable, dividing the user input by 7, and storing the result in the new variable.
            int userQuotient7 = userInteger / 7;

            //Printing the value of the variable to display the result of the division operation.
            Console.WriteLine("The quotient from dividing your input by 7 is: " + userQuotient7);

            Console.ReadLine();
        }
    }
}
