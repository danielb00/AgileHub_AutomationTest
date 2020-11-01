using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseFortyFive
    {
        // Exercise 45
        // Cititi de la tastatura elementele unui array de marime 5.(string)
        public static void PrintExerciseFortyFive()
        {
            string[] array = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a words or letters: ");
                array[i] = Console.ReadLine();
            }

            foreach (string element in array)
            {
                Console.Write($"{element},");
            }
        }
    }
}

