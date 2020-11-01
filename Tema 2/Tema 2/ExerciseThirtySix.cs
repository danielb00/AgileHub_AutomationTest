using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseThirtySix
    {
        // Exercise 36
        // Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi. (for)
        public static void PrintExerciseThirtySix()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= number; i++) { 

            Console.WriteLine(i);
            }
        }
    }
}
