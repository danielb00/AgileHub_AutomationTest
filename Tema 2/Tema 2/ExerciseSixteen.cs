using System;


namespace Tema_2
{
    public static class ExerciseSixteen
    {
        // Exercise 16
        // Cititi de la tastatura o ora a zilei. In cazul in care ora respectiva este mai mica de 12 afisati: “Buna dimineata!”. Daca ora este mai mica decat 17 afisati mesajul: “Buna ziua!”. In caz contrar afisati mesajul :”Buna seara!”

        public static void PrintExerciseSixteen()
        {
            Console.WriteLine("Enter an hour of the day: ");

            double hourDay = Convert.ToDouble(Console.ReadLine());

            if (hourDay <= 11.59)
            {
                Console.WriteLine($"Good morning!");
            }
            else if (hourDay <= 16.59)
            {
                Console.WriteLine($"Hello!");
            }
            else
            {
                Console.WriteLine($"Good evening!");
            }
        }
    }
}
