using System;

class CalculatorApp
{
    static void Main(string[] args)

        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator! Please use +, -, * or /.");
                    break;
            }

            Console.WriteLine("Thank you for using the Calculator!");
        }
}
