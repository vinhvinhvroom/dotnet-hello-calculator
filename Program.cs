using System;

namespace dotnet_hello_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = AddNumbers(64, 32);
            Console.WriteLine(result); 
            Console.ReadKey();
        }

        private static int AddNumbers(int numberOne, int numberTwo)
        {
            int CalculationResult; 
            CalculationResult = numberOne + numberTwo; 
            return CalculationResult;
        }

    }
}
