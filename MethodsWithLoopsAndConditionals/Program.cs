using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
            AddByThree();
            Console.WriteLine("Pick an integer:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick a second integer:");
            int num2 = int.Parse(Console.ReadLine());
            CompareNumbers(num1, num2);
            Console.WriteLine(EvenOrOdd(num1));
            Console.WriteLine(EvenOrOdd(num2));
            PositiveOrNegative(num1);
            PositiveOrNegative(num2);
            Console.WriteLine(InRange(num1));
            Console.WriteLine(InRange(num2));
            MultiplicativeTable(num1);
            MultiplicativeTable(num2);
            Console.WriteLine(CanVote());
        }
        public static void PrintNumbers()
        {
            int i = -1000;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 1000);
        }
        public static void AddByThree()
        {
            for (int j = 3; j <= 999; j+=3)
            {
                Console.WriteLine(j);
            }
        }
        public static void CompareNumbers(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine($"{x} and {y} are equal to each other.");
            }
            else
            {
                Console.WriteLine($"{x} and {y} are not equal to each other.");
            }
        }
        public static string EvenOrOdd(int a)
        {
            string evenOddCheck = (a % 2 == 0) ? $"{a} is even!" : $"{a} is odd!";
            return evenOddCheck;
        }
        public static void PositiveOrNegative(int b)
        {
            if (b > 0)
            {
                Console.WriteLine($"{b} is positive!");
            }
            else if (b < 0)
            {
                Console.WriteLine($"{b} is negative!");
            }
            else
            {
                Console.WriteLine($"{b} is neither positive nor negative");
            }
        }
        public static string CanVote()
        {
            Console.WriteLine("What is your age?");
            int voterAge = int.Parse(Console.ReadLine());
            string voteCheck = (voterAge >= 18) ? "You can vote!" : "You cannot vote.";
            return voteCheck;
        }
        public static string InRange(int c)
        {
            string rangeCheck = (c >= -10 && c <= 10) ? $"{c} is in the range of -10 and 10" : $"{c} is not in the range of -10 and 10";
            return rangeCheck;
        }
        public static void MultiplicativeTable(int d)
        {
            for (int i = 1; i <= 12; i++)
            {
                int j = d * i;
                Console.WriteLine($"{d} x {i} = {j}");
            }
        }
    }
}
