namespace ExercismExercises
{
    using System;
    using System.Text;

    /*
Convert a phrase to its acronym.
Techies love their TLA (Three Letter Acronyms)!
Help generate some jargon by writing a program that converts a long name like Portable Network Graphics to its acronym(PNG).
*/

    public static class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            string a = phrase.Replace("-", " ");
            string b = a.Replace("_", " ");
            string c = b.Replace(",", " ");
            StringBuilder zs = new StringBuilder();
            string[] wordList = c.Split(" ");
            
            foreach (string word in wordList)
            {

                char[] chars = word.ToCharArray();
                foreach (char ch in chars)
                {
                    if (ch != ' ')
                    {
                        zs.Append(ch);
                        break;
                    }
                }
                
            }
            Console.WriteLine(zs);
            string finalR = zs.ToString();
            return finalR.ToUpper();
        }

    }
}
