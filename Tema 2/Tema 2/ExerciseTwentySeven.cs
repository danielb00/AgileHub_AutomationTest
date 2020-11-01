using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseTwentySeven
    {
        // Exercise 27
        // Scrieti un program care sa afiseze primele 10 numere naturale.(do while)
        public static void PrintExerciseTwentySeven()
        {
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }
    }
}
