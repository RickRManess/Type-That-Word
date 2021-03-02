using System;
using System.Collections.Generic;
using System.Linq;

namespace Type_That_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction Text
            Console.WriteLine("Type the words as quick as you can");
            Console.WriteLine("Try to avoid the BEEEEP");
            Console.WriteLine("Press 1 for easy 2 for medium 3 for hard");

            //switch case for difficulty
            int difficulty = Int32.Parse(Console.ReadLine());
            int listLength = 0;

            switch (difficulty)
            {
                case 1:
                    listLength = 3;
                    break;
                case 2:
                    listLength = 5;
                    break;
                case 3:
                    listLength = 7;
                    break;
            }

            //Variable for Random index
            int myRandomIndex = 0;
            //Initialize the wordlist with the words to choose from
            var wordList = new List<string> { "apple", "bird", "cat", "dog", "elephant", "fish", "goat" };

            //intialize wordlist to contain the three randomly chosen words
            var words = new List<string>();
            //Variable for index to use in for loop
            var w = new Random();

            //For loop to generate three random words
            for (int i = 0; i < listLength; i++)
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


