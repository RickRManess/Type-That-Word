using System;
using System.Collections.Generic;
using System.Linq;

namespace Type_That_Word
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo cki;

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

            //Converting random word list to string and displaying it
            string newString = string.Join(" ", words);
            Console.WriteLine(newString);

            //user input converted to string to check against generated words
            string userInputWords = Console.ReadLine();
            int length = newString.Length - 1;

            // if statement to compare characters from generated words and user input
            for (int i = 0; i < length; i++)
            {
                if (userInputWords[i] == newString[i])
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }


        }

    }
}


