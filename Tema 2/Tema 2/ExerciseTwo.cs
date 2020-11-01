using System;

namespace Tema_2
{
    public static class ExerciseTwo
    {
        // Exercise 2
        // Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””.

        public static void PrintExerciseTwo()
        {
            Console.WriteLine("Enter a word from the automated test: ");
            string word = Console.ReadLine();
            string presetWord = "automation";

            if (word == presetWord)
            {
                Console.WriteLine($"The word you read is + {presetWord}!");
            }
            else
            {
                Console.WriteLine($"The word you read isn't + {presetWord}!");
            }
        }
    }
}
