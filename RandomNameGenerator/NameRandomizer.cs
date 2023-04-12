using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using static RandomNameGenerator.StringManipulator;

namespace RandomNameGenerator;

public static class NameRandomizer
{
    private static List<string> _wordList = new();
    private static List<string> _prefixList = new();
    private static List<string> _suffixList = new();
    private static readonly Random RANDOM = new();

    public static void Initialize()
    {
        string fileName = ConfigurationManager.AppSettings["wordListFileName"];
        _wordList = FileIO.ReadListFromFile(fileName);

        fileName = ConfigurationManager.AppSettings["prefixListFileName"];
        _prefixList = FileIO.ReadListFromFile(fileName);

        fileName = ConfigurationManager.AppSettings["suffixListFileName"];
        _suffixList = FileIO.ReadListFromFile(fileName);
    }

    public static string Randomize(ref string prefix, ref string suffix, 
                                   ref string prefixFilterString, ref string suffixFilterString, int nameLength)
    {
        string randomName = BuildWord
        (BuildWordFragmentList(
            prefixFilterString, suffixFilterString, nameLength));
        return CapitalizeWord(AddSuffix(AddPrefix(prefix, randomName),suffix));
    }

    private static List<string> BuildWordFragmentList(string prefixFilterString, string suffixFilterString,
                                                      int nameLength)
    {
        //add the first filtered word
        List<string> resultsList = new ();
        string wordFragment;

        if (!string.IsNullOrEmpty(prefixFilterString))
        {
            // CHANGE HERE
            var prefixList = FilterList(prefixFilterString, 1); //THIS IS NORMAL
            //var prefixesList = FilterList(prefixFilterString, 0); //THIS IS FOR PRE/SUF
            wordFragment = PickRandomWord(prefixList);
            resultsList.Add(wordFragment);
            if (wordFragment == "ERR_NULL")
            {
                return resultsList;
            }
        }

        if (nameLength > 0)
        {
            if (!string.IsNullOrEmpty(prefixFilterString) &&
                !_wordList.Any(o => o.StartsWith(prefixFilterString)) ||
                !string.IsNullOrEmpty(suffixFilterString) &&
                !_wordList.Any(o => o.StartsWith(suffixFilterString)))
            {
                return resultsList;
            }

            if (!string.IsNullOrEmpty(prefixFilterString))
            {
                nameLength--;
            }
            //add the remaining fragments
            for (int i = 0; i < nameLength; i++)
            {
                // CHANGE THIS
                wordFragment = PickRandomWord(_wordList); //THIS IS NORMAL
                //wordFragment = PickRandomWord(_suffixList); //THIS IS FOR PRE/SUF
                resultsList.Add(wordFragment);
                if (wordFragment == "ERR_NULL")
                {
                    return resultsList;
                }
            }
        }

        if (string.IsNullOrEmpty(suffixFilterString)) return resultsList;

        // CHANGE HERE
        var suffixList = FilterList(suffixFilterString, 1); //THIS IS NORMAL
        //var suffixesList = FilterList(suffixFilterString, 2); //THIS IS FOR PRE/SUF

        wordFragment = PickRandomWord(suffixList);
        //resultsList.Add(wordFragment);
        if (wordFragment == "ERR_NULL")
        {
            return resultsList;
        }
        // CHANGE HERE
        int lastIndex = resultsList.Count - 1; //THIS IS NORMAL
        if (resultsList.Count > 0)
        {
            resultsList[lastIndex] = wordFragment;
        }
        return resultsList;
    }

    private static string PickRandomWord(List<string> wordsList)
    {
        try
        {
            bool hasWords = wordsList is { Count: > 0 };
            return hasWords ? wordsList[ RandomValue(0, wordsList.Count - 1)] : "ERR_NULL";
        }
        catch (System.Runtime.InteropServices.ExternalException)
        {
            MessageBox.Show("No matching word was found. Try a different word.", "Error: word not found.", MessageBoxButtons.OK);

        }
        return null;
    }

    private static List<string> FilterList(string firstLetters, int whichList)
    {

        var resultsList = new List<string>();

        switch (whichList)
        {
            case 0:
            {
                resultsList.AddRange(_prefixList);
                break;
            }
            case 1:
            {
                foreach (string word in _wordList)
                {
                    if (firstLetters == null)
                    {
                        resultsList.Add(word);
                    }
                    else if (word.StartsWith(firstLetters))
                    {
                        resultsList.Add(word);
                    }

                    else if (!_wordList.Any(o => o.StartsWith(firstLetters)))
                    {
                        resultsList = null;
                        break;
                    }
                }

                break;
            }
            case 2:
            {
                resultsList.AddRange(_suffixList);
                break;
            }
        }

        return resultsList;
    }
        


    public static int RandomValue(int min, int max)
    {
        return RANDOM.Next(min, max);
    }



        
}