using System;


namespace Tema_2
{
    public static class ExerciseFifteen
    {
        // Exercise 15
        // Cititi de la tastatura un caracter. Daca acel caracter este litera afisati mesajul :”Caracterul *caracter* este litera!”. In cazul in care este o cifra afisati mesajul :”Caracterul *caracter* este o cifra!”. In cazul contrar afisati mesajul: “Caracterul *caracter* nu este nici cifra nici litera

        public static void PrintExerciseFifteen()
        {
            Console.WriteLine("Enter a character: ");

            char character;
            character = Console.ReadLine()[0];

            if (char.IsLetter(character))
            {
                Console.WriteLine($"The character {character} which you entered is a letter!");
            }
            else if (char.IsDigit(character))
            {
                Console.WriteLine($"The character {character} which you entered is a digit!");
            }
            else
            {
                Console.WriteLine($"The character {character} is neither a digit or a letter.");
            }
        }
    }
}
