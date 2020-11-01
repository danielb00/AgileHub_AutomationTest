using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseFortyFour
    {
        // Exercise 43
        // Afisati array-ul sortat: “mom”, “dad”, “child”.
        public static void PrintExerciseFortyFour()
        {
            string[] firstArray = { "mom", "dad", "child" };
            string[] secondArray = firstArray;
            Array.Sort(secondArray);

            foreach (string array in secondArray)
            {

                Console.WriteLine(array);
            }
        }
    }
}
