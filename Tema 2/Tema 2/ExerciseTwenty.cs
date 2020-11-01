using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseTwenty
    {
        // Exercise 20
        // Scrieti un program care sa afiseze primele 10 numere naturale.
        public static void PrintExerciseTwenty(int number)
        {
            if (number <= 10)
            {
                Console.WriteLine(number + " ");
                PrintExerciseTwenty(number + 1);
            }
           
        }

    }
}
