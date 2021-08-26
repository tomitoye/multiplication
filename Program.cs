using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            int thirdNum;
            int result;

            Console.WriteLine("Enter the first number");
            firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            thirdNum = int.Parse(Console.ReadLine());

            result = firstNum * secondNum * thirdNum;
            Console.WriteLine("The answer is " + result);
        }
    }
}
