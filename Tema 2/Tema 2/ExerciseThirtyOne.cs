using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseThirtyOne
    {
        // Exercise 31
        // Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi. .( do while)
        public static void PrintExerciseThirtyOne()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i = 0;
            do
            {
                sum += i;
                i++;
            } while (i < number);

            Console.WriteLine($"The sum is...{sum}");
        }
    }
}
