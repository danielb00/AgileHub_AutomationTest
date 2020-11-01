using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseThirtyThree
    {
        // Exercise 33
        // Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru.( do while)
        public static void PrintExerciseThirtyThree()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            do
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            } while (i < number);
        }
    }
}
