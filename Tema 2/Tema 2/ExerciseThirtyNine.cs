using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseThirtyNine
    {
        // Exercise 39
        // Afisati cubul primelor 5 numere naturale.(for)
        public static void PrintExerciseThirtyNine()
        {
            for (int i = 1; i <= 5; i++) { 
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
    }
}
