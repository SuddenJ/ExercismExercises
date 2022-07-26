namespace ExercismExercises
{
    using System;

    public static class Darts
    {
        public static int Score(double x, double y)
        {
            double absX = Math.Abs(x);
            double absY = Math.Abs(y);
            double XYdart = Math.Sqrt(Math.Pow(absY, 2) + Math.Pow(absX, 2));

            if (XYdart > 10)
            {
                return 0;
            }
            else if (XYdart > 5 && XYdart <= 10)
            {
                return 1;
            }
            else if (XYdart > 1 && XYdart <= 5)
            {
                return 5;
            }
            else
            {
                return 10;
            }
        }
    }
}
