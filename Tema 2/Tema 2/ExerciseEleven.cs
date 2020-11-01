using System;


namespace Tema_2
{
    public static class ExerciseEleven
    {
        // Exercise 11
        // Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. In caz contrar scadeti numarul cu 5 si afisati rezultatul final.

        public static void PrintExerciseEleven()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 20)
            {
                int result = number + 5;
                Console.WriteLine($"The end result is...{result}!");
            }
            else
            {
                int result = number - 5;
                Console.WriteLine($"The end result is...{result}!");
            }
        }
    }
}
