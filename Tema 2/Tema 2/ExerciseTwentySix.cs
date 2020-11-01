using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseTwentySix
    {
        // Exercise 26
        // Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru.
        public static void PrintExerciseTwentySix()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)

                if (i % 2 == 0) { 
                Console.WriteLine(i);
            }
        }
    }
}
