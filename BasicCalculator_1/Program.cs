using System;

namespace BasicCalculator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1, operand2;
            int result = 0;
            char operatorSymbol;

            Console.WriteLine("Basic Calculator");
            Console.WriteLine("----------------");
            Console.WriteLine();

            try
            {

                Console.WriteLine("Main method - Begin");
                Console.WriteLine();

                Console.WriteLine("Please enter a whole number value for the first operand");
                operand1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a whole number value for the second operand");
                operand2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a valid operator symbol ('+','-','*','/')");
                operatorSymbol = char.Parse(Console.ReadLine());

                switch (operatorSymbol)
                {
                    case '+':
                        checked
                        {
                            result = operand1 + operand2;
                        }
                        break;
                    case '-':
                        checked
                        {
                            result = operand1 - operand2;
                        }
                        break;
                    case '*':
                        checked
                        {
                            result = operand1 * operand2;
                        }
                        break;
                    case '/':
                        checked
                        {
                            result = operand1 / operand2;
                        }
                        break;
                    default:
                        break;
                }

                Console.WriteLine();

                Console.WriteLine($"{operand1} {operatorSymbol} {operand2} = {result}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You entered a value for one of the operands that is too great or too small for an integer value");
                Console.WriteLine();
                Console.ResetColor();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("For a division operation, the second operand cannot be 0");
                Console.WriteLine();
                Console.ResetColor();
            }
            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input value is invalid");
                Console.WriteLine();
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Main method - End");
            }

            Console.ReadKey();

        }
    }
}

