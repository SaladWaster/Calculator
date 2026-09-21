using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isRepeating = true;    // shut down the calculator if no longer repeating

            while (isRepeating)
            {
               
                int firstNumber = readIntFromConsole("Enter 1st number: ");


                Console.WriteLine("List of operators: ");
                Console.WriteLine("1. plus (+)");
                Console.WriteLine("2. minus (-)");
                Console.WriteLine("3. multiply (*)");
                Console.WriteLine("4. divide (/)");

                Console.WriteLine();



                string operatorInput = readStringFromConsole("Enter an operator: ");

                Console.Write("Enter 2nd number: ");
                int secondNumber = readIntFromConsole("Enter 2nd number: ");


                double result = 0.0;
                bool inputCorrect = true;

                
                if (checkConditions("+", "1", "plus", operatorInput))
                {
                    result = firstNumber + secondNumber;
                    operatorInput = "+";

                }
                else if (checkConditions("-", "2", "minus", operatorInput))
                {
                    result = firstNumber - secondNumber;
                    operatorInput = "-";
                }
                else if (checkConditions("*", "3", "multiply", operatorInput))
                {
                    result = firstNumber * secondNumber;
                    operatorInput = "*";
                }
                else if (checkConditions("/", "4", "divide", operatorInput))
                {
                    result = (double) firstNumber / secondNumber;   // changing it to double allows us to see decimals
                    operatorInput = "/";
                }
                else
                {
                    inputCorrect = false;

                }

                if (inputCorrect)
                {
                    PrintResult(firstNumber, operatorInput, secondNumber, result);
                }
                else
                {
                    Console.WriteLine("An incorrect operator has been entered.");
                }

                             

                bool checkRepeat = true;

                while (checkRepeat)
                {

                    Console.WriteLine("Would you like to calculate something else?");
                    Console.WriteLine("Y / N ");

                    string repeatInput = Console.ReadLine();

                    if (repeatInput.ToLower() == "y")
                    {
                        isRepeating = true;
                        checkRepeat = false;
                    }
                    else if (repeatInput.ToLower() == "n")
                    {
                        Console.WriteLine("Press any key to exit the calculator");
                        isRepeating = false;
                        checkRepeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input");
                    }

                }


            }



            Console.ReadLine();
        }

        static void PrintResult(int firstNumber, string operatorInput, int secondNumber, double result)
        {
            Console.WriteLine($"The result of {firstNumber} {operatorInput} {secondNumber} is {result}.");
        }

        public static bool checkConditions(string symbol, string num, string word, string comparison)
        {
            if (comparison.Contains(symbol) || comparison.Contains(num) || comparison.Contains(word))
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }

        public static string readStringFromConsole(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int readIntFromConsole(string message)
        {
            return Convert.ToInt32(readStringFromConsole(message));
        }

    }
}
