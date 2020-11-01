using System;


namespace Tema_2
{
    public static class ExerciseFourteen
    {
        // Exercise 14
        // Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :”Numarul *numar* pe care l’ati introdus este par!”. In caz contrar afisati “Numarul *numar* pe care l’ati introdus este impar!”.

        public static void PrintExerciseFourteen()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} you entered is even!");
            }
            else
            {
                Console.WriteLine($"The number {number} you entered is odd!");
            }
        }
    }
}
