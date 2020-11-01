using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
   public static class ExerciseThirtyTwo
    {
        // Exercise 32
        // Afisati cubul primelor 5 numere naturale.(do while)
        public static void PrintExerciseThirtyTwo()
        {
            int number = 1;
            do
            {
                Console.WriteLine(Math.Pow(number, 3));
                number++;
            } while (number <= 5); 
        }
    }
}
