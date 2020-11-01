using System;


namespace Tema_2
{
    public static class ExerciseSix
    {
        // Exercise 6
        // Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar nu afisati nimic.

        public static void PrintExerciseSix()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 20 || number > 40)
            {
                Console.WriteLine("The number is less than 20 or greater than 40!");
            }
        }
    }
}
