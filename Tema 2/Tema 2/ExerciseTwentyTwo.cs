using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseTwentyTwo
    {
        // Exercise 22
        // Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi.
        public static void PrintExerciseTwentyTwo()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = number; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
