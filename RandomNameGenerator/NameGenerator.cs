using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static RandomNameGenerator.StringManipulator;

namespace RandomNameGenerator;

public enum ElementNameType
{
    Sun,
    Moon,
    Fire,
    Iron,
    Earth,
    Wood,
    Water,
    Ice,
    Wind,
    Lightning,
    Life,
    Death,
    Suffix
}

public static class NameGenerator
{
    private static List<string> wordList = new();
    private static Random RANDOM = new();

    private static Dictionary<ElementNameType, List<string>> elementNames = new();
    public const string ERR_NULL = "ERR_NULL";


    public static string GetElementName(ElementNameType type)
    {
        string elemWord = PickRandomWord(elementNames[type]);
        string suffix = PickRandomWord(elementNames[ElementNameType.Suffix]);
        
        return (elemWord.Contains(ERR_NULL) || suffix.Contains(ERR_NULL)) ? ERR_NULL : $"{elemWord}{suffix}";
    }

    public static void FillElementalNames(HashSet<string> names, ElementNameType nameType)
    {
        foreach (var nameRoot in elementNames[nameType])
        {
            foreach (var suffix in elementNames[ElementNameType.Suffix])
            {
                names.Add(nameRoot + suffix);
            }
        }
    }

    public static void Initialize()
    {
        wordList.Clear();
        elementNames.Clear();
        RANDOM = new Random();
        
        string fileName = ConfigurationManager.AppSettings["wordListFileName"];
        wordList = FileIO.ReadListFromFile(fileName);

        fileName = ConfigurationManager.AppSettings["elementListFileName"];
        JObject namesJson = FileIO.ReadFromJson(fileName);

        foreach (ElementNameType nameType in (ElementNameType[])Enum.GetValues(typeof(ElementNameType)))
        {
            elementNames.Add(nameType, namesJson[nameType.ToString()].Values<string>().ToList());
        }
    }

    public static int GetCount(ElementNameType nameType)
    {
        return elementNames[nameType].Count * elementNames[ElementNameType.Suffix].Count;
    }

    public static string Randomize(ref string prefix, ref string suffix,
                                   ref string prefixFilterString, ref string suffixFilterString, int nameLength)
    {
        string randomName = BuildWord
        (BuildWordFragmentList(
            prefixFilterString, suffixFilterString, nameLength));
        return CapitalizeWord(AddSuffix(AddPrefix(prefix, randomName), suffix));
    }

    private static List<string> BuildWordFragmentList(string prefixFilterString, string suffixFilterString,
                                                      int nameLength)
    {
        List<string> resultsList = new();
        string wordFragment;

        bool hasPrefix = !string.IsNullOrEmpty(prefixFilterString);
        bool hasSuffix = !string.IsNullOrEmpty(suffixFilterString);

        if (hasPrefix)
        {
            var filterList = FilterList(prefixFilterString, wordList);
            if (!filterList.Any())
            {
                resultsList.Add(ERR_NULL);
                return resultsList;
            }

            //var prefixesList = FilterList(prefixFilterString, 0); //THIS IS FOR PRE/SUF
            wordFragment = PickRandomWord(filterList);
            resultsList.Add(wordFragment);
            if (wordFragment == ERR_NULL)
            {
                return resultsList;
            }
        }

        if (nameLength > 0)
        {
            // if (hasPrefix &&
            //     !wordList.Any(o => o.StartsWith(prefixFilterString)) 
            //   ||
            //     !string.IsNullOrEmpty(suffixFilterString) &&
            //     !wordList.Any(o => o.StartsWith(suffixFilterString)))
            // {
            //     return resultsList;
            // }

            if (hasPrefix)
            {
                nameLength--;
            }

            //add the remaining fragments
            for (int i = 0; i < nameLength; i++)
            {
                wordFragment = PickRandomWord(wordList);

                //wordFragment = PickRandomWord(_suffixList); //THIS IS FOR PRE/SUF
                resultsList.Add(wordFragment);
                if (wordFragment == ERR_NULL)
                {
                    return resultsList;
                }
            }
        }

        if (string.IsNullOrEmpty(suffixFilterString)) return resultsList;


        var suffixFilteredList = FilterList(suffixFilterString, wordList);

        //var suffixesList = FilterList(suffixFilterString, 2); //THIS IS FOR PRE/SUF

        wordFragment = PickRandomWord(suffixFilteredList);

        //resultsList.Add(wordFragment);
        if (wordFragment == ERR_NULL)
        {
            return resultsList;
        }


        int lastIndex = resultsList.Count - 1;
        if (resultsList.Count > 0)
        {
            resultsList[lastIndex] = wordFragment;
        }

        return resultsList;
    }

    public static string PickRandomWord(List<string> wordsList)
    {
        try
        {
            return wordsList.Count <= 0 ? ERR_NULL : wordsList[RandomValue(0, wordsList.Count - 1)];
        }
        catch (System.Runtime.InteropServices.ExternalException)
        {
            MessageBox.Show("No matching word was found. Try a different word.", "Error: word not found.",
                MessageBoxButtons.OK);
        }

        return null;
    }

    private static List<string> FilterList(string firstLetters, List<string> givenWordList)
    {
        var resultsList = new List<string>();

        if (string.IsNullOrEmpty(firstLetters))
        {
            return givenWordList;
        }

        foreach (string word in givenWordList)
        {
            if (word.StartsWith(firstLetters))
            {
                resultsList.Add(word);
            }
        }

        return resultsList;
    }


    public static int RandomValue(int min, int max)
    {
        return RANDOM.Next(min, max);
    }
}