using System;
using System.Linq;

public class ConvertBoolToString
{
    static void Main(string[] args)
    {
        Console.WriteLine(boolToWord(true));
    }
    public static string boolToWord(bool word)
    {
        if (word == true)
        {
            return "Yes";
        }
        else if (word == false)
        {
            return "No";
        }
        else
        {
            return "N/A";
        }
    }
}
