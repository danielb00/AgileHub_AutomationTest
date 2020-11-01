using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseFortyThree
    {
        // Exercise 43
        // Afisati array-ul in ordine inversa: “mom”, “dad”, “child”.
        public static void PrintExerciseFortyThree()
        {
            string[] firstArray = { "mom", "dad", "child" };
            string[] secondArray = firstArray;
            Array.Reverse(secondArray);

            foreach (string array in secondArray) { 

                Console.WriteLine(array);
            }
        }
    }
}
