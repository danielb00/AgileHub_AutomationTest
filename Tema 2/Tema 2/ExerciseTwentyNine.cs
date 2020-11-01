using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseTwentyNine
    {
        // Exercise 29
        // Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi. .( do while)
        public static void PrintExerciseTwentyNine()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            do
            { 
                Console.WriteLine(number);
                number--;

            } while (number >= 1);

        }
    }
}
