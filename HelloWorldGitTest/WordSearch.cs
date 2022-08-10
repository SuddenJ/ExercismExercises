
namespace ExercismExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WordSearch
    {
        Dictionary<char, Tuple<int, int>> lookUp = new Dictionary<char, Tuple<int, int>>();
        
        public WordSearch(string grid)
        {
            //use a 2D array
            // Two-dimensional array.
            //int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            //make a number for each letter by making a char array,
            //find the linq thing that looks up the letter 
            //use that number to look up the corrisponding 2d tuple
            //
            //I think the first thing to do is acually do the code to find the word 


            //Console.WriteLine(grid);
            string[] strings = grid.Split("/n");
            int yCounter = 0; //counts down the rows
            int xChounter = 0; //counts accross the columns

            foreach (string line in strings)
            {
                yCounter++; // which level of the word find is it on
                foreach (char c in line)
                {
                    xChounter++;
                    lookUp.Add(c, Tuple.Create(yCounter, xChounter));
                }
                xChounter = 0;  
            }
            
            foreach(KeyValuePair<char, Tuple<int, int>> d in lookUp)
            {
                Console.WriteLine(d);
            }



            public Dictionary<string, ((int, int), (int, int))?> Search(string[] wordsToSearchFor)
            {
                throw new NotImplementedException("You need to implement this function.");
            }
        
    }
}












/*
public class WordSearch
{
    Dictionary<char, Tuple<int, int>> lookUp = new Dictionary<char, Tuple<int, int>>();

    public WordSearch(string grid)
    {
        //Console.WriteLine(grid);
        string[] strings = grid.Split("/n");
        int yCounter = 0; //counts down the rows
        int xChounter = 0; //counts accross the columns

        foreach (string line in strings)
        {
            yCounter++; // which level of the word find is it on
            foreach (char c in line)
            {
                xChounter++;
                lookUp.Add(c, Tuple.Create(yCounter, xChounter));
            }
            xChounter = 0;
        }

        foreach (KeyValuePair<char, Tuple<int, int>> d in lookUp)
        {
            Console.WriteLine(d);
        }



        // Dictionary<char, int> xyValue = new Dictionary<string, string>();


        /*
                    foreach(string s in strings)
                    {
                        Console.Write(s);
                    }
        */
    }

    // Take an array of libraries and parse them into = Search(string[] wordsToSearchFor)
    // Make an array whichh is a field - an array of libraries

    public Dictionary<string, ((int, int), (int, int))?> Search(string[] wordsToSearchFor)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

}
}
*/
