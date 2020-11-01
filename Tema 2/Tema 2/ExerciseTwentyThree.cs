using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseTwentyThree
    {
        // Exercise 23
        // Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi.
        public static void PrintExerciseTwentyThree()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 3)
            {
                for (int i = 3; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }else if (number <= 3)
            {
                Console.WriteLine("The number is less than the number 3.Please enter a larger number.");
            }
        }
    }
}
