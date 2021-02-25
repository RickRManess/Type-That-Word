using System;
using System.Collections.Generic;

namespace Type_That_Word
{
    class Program
    {
        static void Main(string[] args)
        {


            // Initialize the Words List
            int myRandomIndex = 0;
            var wordList = new List<string>(new[] { "apple", "bird", "cat", "dog", "elephant", "fish", "goat"});
            var words = new List<string>();
            var w = new Random();

            for (int i = 0; i<3; i++)
            {
                myRandomIndex = w.Next(wordList.Count);
                words.Add(wordList[myRandomIndex]);
               
            }

            Console.WriteLine(string.Join(" ", words));
            
        }


    }

}
