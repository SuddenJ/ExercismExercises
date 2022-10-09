using ExercismExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

/* word search
var grid =
            "jefblpepre\n" +
            "camdcimgtc\n" +
            "oivokprjsm\n" +
            "pbwasqroua\n" +
            "rixilelhrs\n" +
            "wolcqlirpc\n" +
            "screeaumgr\n" +
            "alxhpburyi\n" +
            "jalaycalmp\n" +
            "clojurermt";

WordSearch word = new WordSearch(grid);

*/

//Console.WriteLine(ResistorColor.ColorCode("white"));


Sublist.Classify(new List<int> { 0, 1, 2, 3, 4, 5 }, new List<int> { 3, 4, 5 });

/*
xxx.Classify(new List<int> {1,2,3} , new List<int> {1,2,3});



class xxx
{
    public static void Classify<T>(List<T> list1, List<T> list2)
        where T : IComparable
    {



        //Enumerable.SequenceEqual(list1.OrderBy(t => t), list2.OrderBy(t => t));

        int zzz = list1.Count - 1;
        for (int i = list1.Count; i > 0; i--)
        {
            
            foreach (T item in list1)
            {
                Console.WriteLine(item.ToString());
            }
            list1.RemoveAt(zzz);
            Console.WriteLine("finished");
            zzz--;
        }

        List<T> copylist1 = new List<T>(list1);
        List<T> copylist2 = new List<T>(list2);

        foreach (T item in copylist2) { Console.WriteLine(item.ToString()); }


            

    }
}
*/