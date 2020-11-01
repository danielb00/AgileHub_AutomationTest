using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseFortySix
    {
        // Exercise 46
        // Cititi de la tastatura elementele unui array de marime 5.(int)
        public static void PrintExerciseFortySix()
        {
            int [] array = new int [5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int element in array)
            {
                Console.Write($"{element},");
            }
        }
    }
}
