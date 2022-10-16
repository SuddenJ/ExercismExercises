using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismExercises
{
    public static class CollatzConjecture
    {
        public static int Steps(int number)
        {
            int step = 0;
            decimal num = number;
            while (num != 1)
            {
                if (num % 2 == 0) { num = Even(num); }
                else { num = Odd(num); }

                step++;          
                if (step > 1000001) 
                { 
                    throw new ArgumentOutOfRangeException(); 
                    Console.WriteLine("loop exceeded 1Million !forced stop!"); 
                    return step; 
                }
            }
            return step;
        }

        public static decimal Even(decimal inputE)
        {
            return inputE / 2;
        }
        public static decimal Odd(decimal inputO)
        {
            return (inputO * 3) + 1;
        }
    }
}
