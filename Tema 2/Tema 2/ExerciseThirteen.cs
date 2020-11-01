using System;


namespace Tema_2
{
    public static class ExerciseThirteen
    {
        // Exercise 13
        // Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar afisati: “Numarul este intre 20 si 40!”

        public static void PrintExerciseThirteen()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 20 || number > 40)
            {
                Console.WriteLine("The number is less than 20 or greater than 40!");
            }
            else
            {
                Console.WriteLine("The number is between 20 and 40!");
            }
        }
    }
}
