using System;

namespace Example
{
    // A simple calculator class
    public class Calculator
    {
        public int AddNumbers(int a, int b)
        {
            return checked(a + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int result1 = calc.AddNumbers(5, 3);

            Console.WriteLine($"AddNumbers result: {result1}");
        }
    }
}
