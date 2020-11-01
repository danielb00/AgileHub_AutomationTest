using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseOne
    {
        // Exercise 1
        // Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!
        public static void PrintExerciseOne()
        {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            string presetNumber = "20";

            if (number == presetNumber)
            {
                Console.WriteLine("Your number is equal to 20!");
            }
            else
            {
                Console.WriteLine("Your number is not equal to 20!");
            }
        }

        //another solution of exercise 1
        /*public static void PrintExerciseOne()
            {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            int presetNumber;

            Int32.TryParse(number, out presetNumber);

            if (presetNumber == 20)
             {
                Console.WriteLine("Your number is equal to 20!");
             }
            else
             {
                Console.WriteLine("Your number is not equal to 20!");
             }*/

    }
}
