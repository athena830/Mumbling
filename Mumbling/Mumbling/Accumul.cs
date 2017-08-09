using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Summary description for Accumul
/// </summary>
public class Accumul
{
    public static String Accum(string source)
    {
        return string.Join("-", TransformCharacters(source.ToArray()));       
    }

    private static IEnumerable<string> TransformCharacters(char[] sourceCharArray)
    {
        for (int i = 0; i < sourceCharArray.Length; i++)
        {
            var currentChar = sourceCharArray[i];
            yield return UpperFirstCharacter(currentChar) +
                         RepeatLowerCharacter(i, currentChar);
        }
    }

    private static string UpperFirstCharacter(char currentChar)
    {
        return currentChar.ToString().ToUpper();
    }

    private static string RepeatLowerCharacter(int times, char currentChar)
    {
        return string.Concat(Enumerable.Repeat(currentChar.ToString().ToLower(), times));
    }
}