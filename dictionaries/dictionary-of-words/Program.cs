using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
        // DICTIONARY OF WORDS PRACTICE    
            
            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Yoga", "A thing you do when your sister is in town in order to spend time with her despite your lack of natural talent");
            wordsAndDefinitions.Add("Bunny", "A very hungry cat. Don't listen to her; she has already been fed");
            wordsAndDefinitions.Add("Pretzel Thins", "Pretzels, but thin");
            wordsAndDefinitions.Add("Graeter's", "The only ice cream");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            String awesome = wordsAndDefinitions["Awesome"]; 
            String bunny = wordsAndDefinitions["Bunny"];
            Console.WriteLine("Awesome: " + awesome);
            Console.WriteLine($"Bunny: {bunny}");
            Console.WriteLine();
            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            { Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }

            Console.WriteLine();

        // LIST OF DICTIONARIES ABOUT WORDS

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> ennuiWord = new Dictionary<string, string>();
            ennuiWord.Add("word", "ennui");
            ennuiWord.Add("definition", "a feeling of listlessness and dissatisfaction arising from a lack of occupation or excitement");
            ennuiWord.Add("part of speech", "noun");
            ennuiWord.Add("example sentence", "He succumbed to ennui and despair.");
            
            dictionaryOfWords.Add(ennuiWord);
            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach ( Dictionary<string, string> dict in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in dict)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }

                Console.WriteLine();
            }


        }
    }
}
