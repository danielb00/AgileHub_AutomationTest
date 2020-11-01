using System;


namespace Tema_2
{
    public static class ExerciseEight
    {
        // Exercise 8
        // Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!”, in caz contrar: “Numarul tau este diferit de 20”.

        public static void PrintExerciseEight()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 20)
            {
                Console.WriteLine($"Your number is equal to 20!");
            }
            else
            {
                Console.WriteLine($"Your number is different from 20!");
            }
        }
    }
}
