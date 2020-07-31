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
        }
    }
}
