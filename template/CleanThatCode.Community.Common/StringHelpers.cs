using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;

namespace CleanThatCode.Community.Common;

// Your job is to implement this class
public static class StringHelpers
{
    // Instead of spaces it should be separated with dots, e.g. Hello World -> Hello.World
    public static string ToDotSeparatedString(this string str)
    {

        string[] data = str.Split(' ');
        string result = string.Join(".", data);
        return result;
    }
        
    // All words in the string should be capitalized, e.g. teenage mutant ninja turtles -> Teenage Mutant Ninja Turtles
    public static string CapitalizeAllWords(this string str)
    {
        string[] data = str.Split(' ');

        int count = 0;
        foreach (string word in data)
        {
            if (word.Length > 0) {
            data[count] = char.ToUpper(data[count][0]) + data[count][1..];
            }
            count += 1;
        }
        
        string new_string = string.Join(" ", data);
        return new_string;

    }

    // The words should be reversed in the string, e.g. Hi Ho Silver Away! -> Away! Silver Ho Hi
    public static string ReverseWords(this string str)
    {
        string[] words = str.Split(' ');
        string[] reversed = new string[words.Length]; 

        int count = 0;
        for (int i = words.Length - 1; i>=0; i--)
        {
            reversed[count] = words[i];
            count++;
        }

        string new_string = string.Join(" ", reversed);
        return new_string;

    }
}