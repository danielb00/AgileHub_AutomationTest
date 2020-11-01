using System;


namespace Tema_2
{
    public static class ExerciseSeven
    {
        // Exercise 7
        // Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :”Numarul *numar* pe care l’ati introdus este par!”. In caz contrar nu afisati nimic.

        public static void PrintExerciseSeven()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} you entered is even!");
            }
        }
    }
}
