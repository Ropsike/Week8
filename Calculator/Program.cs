using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe ('+', '-', '*' või '/'");
            char userOpertaion = Convert.ToChar(Console.ReadLine());

            switch (userOpertaion)
            {
                case '+':
                    AddTwoNumbers(firstNumber, secondNumber);
                    break;
                case '/':
                    DivideTwoNumber(firstNumber, secondNumber);
                    break;
                case '-':
                    SubstractTwoNumbers(firstNumber, secondNumber);
                    break;
                case '*':
                    KorrutaTwoNumbers(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("Vale tehe");
                    break;
            }


        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }


        private static void DivideTwoNumber(int x, int y)
        {
            int result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }


        private static void SubstractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }

        private static void KorrutaTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }


    }
}
