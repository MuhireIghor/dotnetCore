using System;
public class Calculator
{
    public  int calculateNumbers(int num1, int num2, char operators)
    {
        int result;
        switch (operators)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"the sum of {num1} and {num2} is {result}");
                return result;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"The difference of {num1} and {num2} is {result}");
                return result;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"The product of {num1} and {num2} is {result}");
                return result;
            case '/':
                result = num1 / num2;
                Console.WriteLine($"The quotient of {num1} and {num2} is {result}");
                return result;
            default:
                throw new ArgumentException("Invalid operator");
        }

    }
}