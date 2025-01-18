using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1;
            float number2;

            float result;

            string answer;

            Console.WriteLine("Hello, welcome to my calculator program!");
            Console.WriteLine("Please enter your first number: ");

            number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");

            number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter A for addition, S for subtraction, M for multiplication, or any other key for division");

            answer = Console.ReadLine().ToUpper();

            if (answer == "A")
            {
                result = number1 + number2;
            }
            else if (answer == "S")
            {
                result = number1 - number2;
            }
            else if (answer == "M")
            {
                result = number1 * number2;
            }
            else
            {
                result = number2 == 0? float.NaN : number1 / number2;
            }

            if(float.IsNaN(result))
            {
                Console.WriteLine("Cannot divide by 0!");
            }
            else
            { 
                Console.WriteLine("The answer is: " + result); 
            }

            Console.WriteLine("Thank you for using my calculator!"); ;

            Console.ReadKey();
        }
    }
}

