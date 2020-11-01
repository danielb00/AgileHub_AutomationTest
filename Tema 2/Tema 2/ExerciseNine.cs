using System;


namespace Tema_2
{
    public static class ExerciseNine
    {
        // Exercise 9
        // Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””. In caz contrar afisati mesajul: “Cuvantul pe care l-ai citit nu este “automation””.

        public static void PrintExerciseNine()
        {
            Console.WriteLine("Enter a word from the automated test: ");
            string word = Console.ReadLine();
            string presetWord = "automation";
            bool areEquals = (word == presetWord);
            if (areEquals)
            {
                Console.WriteLine($"The word you read is {presetWord}!");
            }
            else
            {
                Console.WriteLine($"The word you read isn't {presetWord}!");
            }
        }
    }
}
