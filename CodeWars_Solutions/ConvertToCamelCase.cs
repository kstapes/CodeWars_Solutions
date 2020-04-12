using System;
using System.Collections.Generic;

/*
Instruction: 
Complete the method/function so that it converts dash/underscore delimited words into camel casing.
The first word within the output should be capitalized only if the original word was 
capitalized (known as Upper Camel Case, also often referred to as Pascal case).
*/


namespace CodeWars_Solutions
{

    class ConvertToCamelCase
    {

        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("Hello_World-Baby_okay"));
        }

        static string ToCamelCase(string str)
        {
            String camelCase;
            List<String> stringList = new List<String>();

            //Split string by delimiters and create an array
            String[] split = str.Split(new Char[] { '-', '_' });

            for (int i = 0; i < split.Length; i++)
            {
                //the word in the first position should remain as is from the provided input
                if (i == 0)
                {
                    stringList.Add(split[0]);
                }
                else
                {
                    //for the rest of the words in the array capitalise the first letter
                    stringList.Add(split[i][0].ToString().ToUpper());
                    // add the rest of the word to the list
                    stringList.Add(split[i].ToString().Substring(1).ToLower());
                }
            }

            //create a new string from the List   
            camelCase = string.Join("", stringList);
            return camelCase;
        }
    }
}
