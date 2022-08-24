using System;
using System.Collections.Generic;

namespace ExercismExercises
{ 
public static class ResistorColor
{


        public static int ColorCode(string color)
    {
        Dictionary<string, int> colours = new Dictionary<string, int>();

            colours.Add("black", 0);
            colours.Add("brown", 1);
            colours.Add("red", 2);
            colours.Add("orange", 3);
            colours.Add("yellow", 4);
            colours.Add("green", 5);
            colours.Add("blue", 6);
            colours.Add("violet", 7);
            colours.Add("grey", 8);
            colours.Add("white", 9);
         
            return colours[color];
    }

    public static string[] Colors()
        {
            string[] data = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
            return data;
        }
    
}
}