using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseThirty 
    {
        // Exercise 30
        // Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi. (do while)
        public static void PrintExerciseThirty()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            int i = 3;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < number);
        }
    }
}
