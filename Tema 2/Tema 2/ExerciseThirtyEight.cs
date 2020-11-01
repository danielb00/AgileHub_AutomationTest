using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseThirtyEight
    {
        // Exercise 38
        // Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi.(for)
        public static void PrintExerciseThirtyEight()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < number; i++) { 
                sum += i;
            }
            Console.WriteLine($"The sum is...{sum}");
        }
    }
}
