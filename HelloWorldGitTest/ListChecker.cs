using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



// Thhis problem is not finished


namespace ExercismExercises
{
    public enum SublistType
    {
        Equal,
        Unequal,
        Superlist,
        Sublist
    }

    public static class Sublist
    {
        public static SublistType Unequal { get; private set; }

        public static SublistType Classify<T>(List<T> list1, List<T> list2)
            where T : IComparable
        {
            List<T> copylist1 = new List<T>(list1);
            List<T> copylist2 = new List<T>(list2);

            if (list1.Capacity == 0 || list2.Capacity == 0)
            {
                if (list1.Capacity == 0 && list2.Capacity == 0)
                { return SublistType.Equal; }
                else if (list1.Capacity > 0 && list2.Capacity == 0)
                { return SublistType.Superlist; }

                return SublistType.Sublist;
            }

            if (list1.Count == list2.Count)
            { 
                bool match = true;
                for (var i = 0; i < list1.Count; i++)
                {
                    if (list1[i].ToString() != list2[i].ToString()) { match = false; break; }
                    return SublistType.Equal;
                }
                if (match) { return SublistType.Equal; }
            }

            //Splitting into two paths A contains B or B contains A

            SublistType result = AcontainsB(list1, list2, copylist2);

            if (result != SublistType.Unequal) { return result; }

            result = BcontainsA(list2, list1, copylist1);

            if (result != SublistType.Unequal) { return result; }


            return SublistType.Unequal;








            static SublistType AcontainsB(List<T> list1, List<T> list2, List<T> copylist2)
            {
                int trueBuilder = 0;
                int listLenght = copylist2.Count - 1;
                int ? consecutive = null;
                int ? index = null;
                if (listLenght <= 1) { return SublistType.Unequal; }
                for (int i = list1.Count - 1; i > -1; i--)
                {
                    if (copylist2.Contains(list1[i]))
                    {
                        trueBuilder++;
                        // going to need to find the index and check if the next element 
                        index = copylist2.IndexOf(list1[i]);
                        copylist2.RemoveAt(listLenght);
                        listLenght--;
                    }

                    if (consecutive != null)
                    {
                        if (consecutive != index + 1)
                        {
                            if (copylist2.Contains(list1[i]))
                            {
                                if (AcontainsB(list1, list2, copylist2) == SublistType.Unequal) { return SublistType.Unequal; }
                            }
                        }
                    }
                    consecutive = index;


                    if (trueBuilder >= list1.Count) // list 1 is contained in list 2
                    {
                        if (list1.Count == list2.Count) { return SublistType.Equal; }
                        return SublistType.Sublist;
                    }

                    if (listLenght <= 0) { return SublistType.Unequal; }
                }
                return SublistType.Unequal;
            }





            static SublistType BcontainsA(List<T> list2, List<T> list1, List<T> copylist1)
            {
                int trueBuilder = 0;
                int listLenght = copylist1.Count - 1;
                int ? consecutive = null;
                int ? index = null;
                if (listLenght <= 1) { return SublistType.Unequal; }
                for (int i = list2.Count - 1; i > -1; i--)
                {
                    if (copylist1.Contains(list2[i]))
                    { 
                        trueBuilder++; 
                        // going to need to find the index and check if the next element 
                        index = copylist1.IndexOf(list2[i]);
                        copylist1.RemoveAt(listLenght);
                        listLenght--;
                    }
                    if (consecutive != null)
                    {
                        if (consecutive != index + 1)
                        {
                            if (copylist1.Contains(list2[i]))
                            {
                                trueBuilder = 0;
                                listLenght = list2.Count - 1;
                                consecutive = null;

                                if (AcontainsB(list2, list1, copylist1) == SublistType.Unequal) { return SublistType.Unequal; }
                            }
                        }
                    }
                    consecutive = index;


                    if (trueBuilder >= list2.Count) // list 1 is contained in list 2
                    {
                        if (list2.Count == list1.Count) { return SublistType.Equal; }
                        return SublistType.Sublist;
                    }

                    if (listLenght == 0) { return SublistType.Unequal; }
                }
                return SublistType.Unequal;
            }

        }
    }
}
