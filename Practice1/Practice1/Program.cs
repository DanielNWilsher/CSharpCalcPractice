using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator application enter your first number: ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculator application enter your second number: ");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number for the corresponding arithmetic operation you would like performed on the first two numbers: ");
            Console.WriteLine("1: Addition (+), 2: Subtraction (-), 3: Multiplication (*), 4: Division (÷)");
            int calcChoice = Convert.ToInt32(Console.ReadLine());
            switch (calcChoice)
            {
                case 1:
                    Console.WriteLine("You selected Addition.");
                    int addResult = Add(Number1, Number2);
                    Console.WriteLine("the answer is: " + addResult);
                    break;

                case 2:
                    Console.WriteLine("You selected Subtraction.");
                    int subtractResult = Subtract(Number1, Number2);
                    Console.WriteLine("the answer is: " + subtractResult);
                    break;

                case 3:
                    Console.WriteLine("You selected Multiplication.");
                    int multiplyResult = Multiply(Number1, Number2);
                    Console.WriteLine("the answer is: " + multiplyResult);
                    break;

                case 4:
                    Console.WriteLine("You selected Division.");
                    int divideResult = Divide(Number1, Number2);
                    Console.WriteLine("The answer is: " + divideResult);
                    break;
            };
            Console.Read();
        }

        static int Add(int Number1, int Number2)
        {
            int result = Number1 + Number2;
            return result;
        }

        static int Subtract(int Number1, int Number2)
        {
            int result = Number1 - Number2;
            return result;
        }

        static int Multiply(int Number1, int Number2)
        {
            int result = Number1 * Number2;
            return result;
        }

        static int Divide(int Number1, int Number2)
        {
            int result = Number1 / Number2;
            return result;
        }
    }
}
