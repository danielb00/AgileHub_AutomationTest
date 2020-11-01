using System;


namespace Tema_2
{
    public static class ExerciseTen
    {
        // Exercise 10
        // Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul  *character* pe care l-ai introdus este cifra!”, in caz contrat afisati “Caracterul *character* pe care l-ai introdus nu este cifra.

        public static void PrintExerciseTen()
        {
            Console.WriteLine("Enter a character: ");

            char character;
            character = Console.ReadLine()[0];

            if (char.IsNumber(character) == true)
            {
                Console.WriteLine($"The character {character} which you entered is a number!");
            }
            else
            {
                Console.WriteLine($"The character {character} which you entered isn't a number!");
            }
        }
    }
}
