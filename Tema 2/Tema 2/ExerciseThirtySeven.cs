﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseThirtySeven
    {
        // Exercise 37
        // Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi. (for)
        public static void PrintExerciseThirtySeven()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 3; i <= number; i++) { 
            
                Console.WriteLine(i);
            }
        }
    }
}
