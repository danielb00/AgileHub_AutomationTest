using System;


namespace Tema_2
{
    public static class ExerciseThree
    {
        // Exercise 3
        // Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul  *character* pe care l-ai introdus este cifra!”

        public static void PrintExerciseThree()
        {
            Console.WriteLine("Enter a character: ");

            char character;
            character = Console.ReadLine()[0];

            if (char.IsNumber(character) == true)
            {
                Console.WriteLine($"The character {character} which you entered is a number!");
            }
        }
    }
}
