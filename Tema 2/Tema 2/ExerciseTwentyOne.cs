using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseTwentyOne
    {
        // Exercise 21
        // Scrieti un program care sa afiseze suma primelor 10 numere naturale.
        public static void PrintExerciseTwentyOne(int number = 1, int sum = 0)
        {
    
            if (number <= 10)
            {
                sum = number + sum;    
                PrintExerciseTwentyOne(number + 1, sum);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
 
    }
}
