using System;


namespace Tema_2
{
    public static class ExerciseFour
    {
        // Exercise 4
        // Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. Afisati fie noul rezultat, fie numarul.
        public static void PrintExerciseFour()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 20)
            {
                int result = number + 5;
                Console.WriteLine($"The new number is...{result}!");
            }
            else
            {
                Console.WriteLine($"The number entered is not less than the value 20.");
            }
        }

    }
}
