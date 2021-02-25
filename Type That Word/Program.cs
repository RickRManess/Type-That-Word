using System;
using System.Collections.Generic;

namespace Type_That_Word
{
    class Program
    {
        static void Main(string[] args)
        {


            //Variable for Random index
            int myRandomIndex = 0;
            //Initialize the wordlist with the words to choose from
            var wordList = new List<string>(new[] { "apple", "bird", "cat", "dog", "elephant", "fish", "goat" });
            //intialize wordlist to contain the three randomly chosen words
            var words = new List<string>();
            //Variable for index to use in for loop
            var w = new Random();

            //For loop to generate three random words
            for (int i = 0; i < 3; i++)
            {
                myRandomIndex = w.Next(wordList.Count);
                words.Add(wordList[myRandomIndex]);
            }

            Console.WriteLine(string.Join(" ", words));




        }
    }
}


