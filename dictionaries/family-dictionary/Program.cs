using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
        // Define a Dictionary that contains information about several members of your family. 

        Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

        myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Emily"},
            {"age", "25"}
        });

        myFamily.Add("mother", new Dictionary<string, string>(){
            {"name", "Susan"},
            {"age", "62"}
        });

        myFamily.Add("father", new Dictionary<string, string>(){
            {"name", "Tom"},
            {"age", "60"}
        });

        // Next, iterate over each item in myFamily and produce the following output: Krista is my sister and is 42 years old.

        foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily) {
            Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old.");
        }
        }
    }
}
