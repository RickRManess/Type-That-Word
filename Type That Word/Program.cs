using System;
using System.Collections.Generic;
using System.Linq;

namespace Type_That_Word
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variable for Random index
            int myRandomIndex = 0;
            //Initialize the wordlist with the words to choose from
            var wordList = new List<string> { "apple", "bird", "cat", "dog", "elephant", "fish", "goat" };

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
            string stringToType = string.Join(" ", words);
            Console.WriteLine(stringToType);

            // for loop to move the comparison check through all characters of randomly generated words
            for (int i = 0; i < stringToType.Length;)
            {
                //user input converted to string to check against generated words
                ConsoleKeyInfo userInputGame;
                userInputGame = Console.ReadKey(true);

            // if statement to compare characters from generated words and user input
                if (userInputGame.KeyChar == stringToType[i])
                {
                    Console.Write(userInputGame.KeyChar);
                    i++;
                }
                else
                {
                    Console.Beep();
                }
            }


        }

    }
}


