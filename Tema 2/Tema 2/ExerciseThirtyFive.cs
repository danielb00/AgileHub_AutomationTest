using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public static class ExerciseThirtyFive
    {
        public static void PrintExerciseThirtyFive()
        {
            int i;
            int z = 0;
            for (i = 1; i <= 10; i++)
            {
                z = i + z;
            }
            Console.WriteLine(z);

        }
    }
}
