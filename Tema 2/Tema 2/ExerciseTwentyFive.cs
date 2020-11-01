using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseTwentyFive
    {
        // Exercise 25
        // Afisati cubul primelor 5 numere naturale.
        public static void PrintExerciseTwentyFive(int number = 1)
        {
            if (number <= 5)
            {
                Console.WriteLine(Math.Pow(number, 3));
                PrintExerciseTwentyFive(number + 1);
            }

        }
    }
}