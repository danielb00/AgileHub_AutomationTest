using System;


namespace Tema_2
{
    public static class ExerciseSeventeen
    {
        // Exercise 17
        // Cititi de la tastatura o inaltime a unei persoane in cm si afisati: daca inaltimea este <150 cm afisati: “Aceasta persoana este miniona”, daca inaltimea este intre 150 si 165, afisati mesajul: “Aceasta persoana este mica de statura”. Daca inaltimea este intre 165 si <195 afisati mesajul:”Aceasta persoana este inalta”. In caz contrar afisati :”Aceasta persoana este foarte inalta”.

        public static void PrintExerciseSeventeen()
        {
            Console.WriteLine("Enter a person's height in centimeters: ");

            double heightPerson = Convert.ToDouble(Console.ReadLine());

            if (heightPerson <= 149.99)
            {
                Console.WriteLine($"This person is petite!");
            }
            else if (heightPerson >= 150 && heightPerson <= 164.99)
            {
                Console.WriteLine($"This person is small in stature!");
            }
            else if (heightPerson >= 165 && heightPerson <= 194.99)
            {
                Console.WriteLine($"This person is tall!");
            }
            else
            {
                Console.WriteLine($"This person is very tall!");
            }
        }
    }
}
