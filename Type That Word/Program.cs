using System;
using System.Collections.Generic;

namespace Type_That_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings for the list
            string firstWord = "Quick";
            string secondWord = "Lazy";
            string thirdWord = "Brown";

            // Initialize the Words List
            List<string> WordList = new List<string>();

            WordList.Add(firstWord);
            WordList.Add(secondWord);
            WordList.Add(thirdWord);

            foreach (string s in WordList)
            {
                Console.WriteLine(s);
            }
        }

    }

}
