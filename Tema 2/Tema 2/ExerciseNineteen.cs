using System;


namespace Tema_2
{
    public static class ExerciseNineteen
    {
        // Exercise 19
        // Cititi de la tastatura 2 numere. Faceti un calculator care sa accepte operatiile +,-,*,/ si sa afiseze rezultatul:
        public static void PrintExerciseNineteen()
        {
            Console.WriteLine("Enter first number :");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator (+, -, *, /): ");
            string arithmeticOperator = Console.ReadLine();

            switch (arithmeticOperator)
            {
                case "*":
                    Console.WriteLine($"{numberOne} {arithmeticOperator} {numberTwo} = {numberOne * numberTwo}");
                    break;
                case "/":
                    Console.WriteLine($"{numberOne} {arithmeticOperator} {numberTwo} = {numberOne / numberTwo}");
                    break;
                case "+":
                    Console.WriteLine($"{numberOne} {arithmeticOperator} {numberTwo} = {numberOne + numberTwo}");
                    break;
                case "-":
                    Console.WriteLine($"{numberOne} {arithmeticOperator} {numberTwo} = {numberOne - numberTwo}");
                    break;
            }
        }
    }
}
