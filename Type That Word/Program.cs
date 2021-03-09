using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Type_That_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction Text
            Console.WriteLine("Type the words as quick as you can!!");
            Console.WriteLine("Try to avoid the BEEEEP");
            Console.WriteLine("Press: 1= easy game 2= medium game 3= hard game");

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

           //Initializing var for the file with words
            var wordFile = File.ReadLines(@"../../../Sentences.txt");
            var WordList = new List<Word>();

            //foreach loop to split text file into sentences

            foreach (var lines in wordFile)
            {
                try
                {
                    string[] part = lines.Split(".");
                    var sentenceToType = new Word();
                    Int32.TryParse(part[0], out sentenceToType.lineNumber);
                    sentenceToType.sentence = part[1];
                    WordList.Add(sentenceToType);

                }
                catch (Exception e)
                {
                    
                }
            }

            //Variable for index to use in for loop
            var w = new Random();
            var typingTest = new List<Word>();
            
            //For loop to generate three random words
          for (int i = 0; i < listLength; i++)
            {
               var myRandomIndex = w.Next(typingTest.Count);
               typingTest.Add(WordList[myRandomIndex]);
            }

            //Converting random word list to string and displaying it
           string stringToType = string.Join(" ", typingTest);
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


