using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RandomNameGenerator;

public static class StringManipulator
{
    public static string BuildWord(List<string> wordFragments)
    {
        var resultWord = wordFragments.Aggregate("", (current, wordFragment) => current + wordFragment);
        if (string.IsNullOrEmpty(resultWord))
        {
            resultWord = "NULL";
        }

        return resultWord;
    }

    public static string CapitalizeWord(string word)
    {
        switch (word)
        {
            case null:
                return "NULL";
            case "NULL":
                return word;
            default:

                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word);
                ;
        }
    }

    public static string AddPrefix(string prefix, string word)
    {
        if (string.IsNullOrEmpty(prefix)) return word;
        if (word.Contains("null", StringComparison.OrdinalIgnoreCase)) return "NULL";
        return prefix + word;
    }

    public static string AddSuffix(string word, string suffix)
    {
        if (string.IsNullOrEmpty(suffix)) return word;
        if (word.Contains("null", StringComparison.OrdinalIgnoreCase)) return "NULL";
        return word + suffix;
    }
}

public static class StringExtensions
{
    public static bool Contains(this String str, String substring, 
                                StringComparison comp)
    {                            
        if (substring == null)
            throw new ArgumentNullException("substring", 
                "substring cannot be null.");
        else if (! Enum.IsDefined(typeof(StringComparison), comp))
            throw new ArgumentException("comp is not a member of StringComparison",
                "comp");

        return str.IndexOf(substring, comp) >= 0;                      
    }
}