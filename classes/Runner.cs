using System;
public class Runner
{
    public static void main(string[] args)
    {
        int num1;
        int num2;
        char operators;
        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the operator:");
        operators = Convert.ToChar(Console.ReadLine());
        Calculator calc1 = new Calculator();
      int result =  calc1.calculateNumbers(num1, num2, operators);



    }
}