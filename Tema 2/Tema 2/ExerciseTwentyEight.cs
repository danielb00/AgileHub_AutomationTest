using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseTwentyEight
    {
        // Exercise 28
        // Scrieti un program care sa afiseze suma primelor 10 numere naturale. (do while)
        public static void PrintExerciseTwentyEight()
        {
            int i = 0;
            int sum = 0;
            do
            {
                sum += i;
                i++;
            } while (i <= 10);

            Console.WriteLine(sum);
        }
    }
}
