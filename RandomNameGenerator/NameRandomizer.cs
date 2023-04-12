using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace RandomNameGenerator
{
    public class NameRandomizer
    {
        private static List<string> _wordList;
        private static List<string> _prefixList;
        private static List<string> _suffixList;
        static readonly Random rand = new Random();

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

        public static List<string> BuildWordFragmentList(string prefixFilterString, string suffixFilterString,
            int nameLength)
        {
            //add the first filtered word
            var resultsList = new List<string>();
            string wordFragment;

            if (!string.IsNullOrEmpty(prefixFilterString))
            {
                // CHANGE HERE
                var prefixList = FilterList(prefixFilterString, 1); //THIS IS NORMAL
                //var prefixesList = FilterList(prefixFilterString, 0); //THIS IS FOR PRE/SUF
                wordFragment = PickRandomWord(prefixList);
                resultsList.Add(wordFragment);
                if (wordFragment == "NULL")
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
                else
                {
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
                        if (wordFragment == "NULL")
                        {
                            return resultsList;
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(suffixFilterString))
            {
                // CHANGE HERE
                var suffixList = FilterList(suffixFilterString, 1); //THIS IS NORMAL
                //var suffixesList = FilterList(suffixFilterString, 2); //THIS IS FOR PRE/SUF

                wordFragment = PickRandomWord(suffixList);
                //resultsList.Add(wordFragment);
                if (wordFragment == "NULL")
                {
                    return resultsList;
                }
                // CHANGE HERE
                int lastIndex = resultsList.Count - 1; //THIS IS NORMAL
                if (resultsList.Count > 0)
                {
                    resultsList[lastIndex] = wordFragment;
                }


            }
            return resultsList;
        }

        public static string PickRandomWord(List<string> wordsList)
        {
            int randomIndex = 0;
            try
            {
                if (wordsList != null && wordsList.Count > 0)
                {
                    randomIndex = rand.Next(0, wordsList.Count - 1);
                    return wordsList[randomIndex];
                }
                else
                {
                    return "NULL";
                }
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {
                MessageBox.Show("No matching word was found. Try a different word.", "Error: word not found.", MessageBoxButtons.OK);

            }
            return null;
        }

        public static List<string> FilterList(string firstLetters, int whichList)
        {

            var resultsList = new List<string>();

            if (whichList == 1)
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
            }

            else if (whichList == 0)
            {
                foreach (string prefix in _prefixList)
                {
                    resultsList.Add(prefix);
                }
            }

            else if (whichList == 2)
            {
                foreach (string suffix in _suffixList)
                {
                    resultsList.Add(suffix);
                }
            }

            return resultsList;
        }

        public static string BuildWord(List<string> wordFragments)
        {
            string resultWord = "";
            foreach (string wordFragment in wordFragments)
            {
                resultWord += wordFragment;
            }
            if (resultWord == null || resultWord == "" || resultWord.Length == 0)
            {
                resultWord = "NULL";
            }
            return resultWord;
        }

        public static string CapitalizeWord(string word)
        {
            if (word == null)
            {
                return "NULL";
            }
            else if (word == "NULL")
            {
                return word;
            }
            word.ToLower();
            Char.ToUpper(word.First());
            return word;
        }





        public static int PickRandomWordLength(int min, int max)
        {
            int randLength = rand.Next(min, max);
            return randLength;
        }


        public static string AddPrefix(string prefix, string word)
        {
            if (!string.IsNullOrEmpty(prefix))
            {
                string combinedWord = prefix + word;
                return combinedWord;
            }
            else return word;
        }

        public static string AddSuffix(string word, string suffix)
        {
            if (!string.IsNullOrEmpty(suffix))
            {
                string combinedWord = word + suffix;
                return combinedWord;
            }
            else return word;
        }


        #region Deprecated
        /*
        public static string RandomNameWithInput(string firstLetters, int nameLength)
        {
            List<string> matchingPieces = FilterList(firstLetters);
            string resultWord = PickRandomWord(matchingPieces);
            for (int i = 0; i < nameLength - 1; i++)
            {
                string wordFragment = PickRandomWord(_wordList);
                resultWord += wordFragment;
            }
            return resultWord;
        }

       

        public static string RandomName(int nameLength)
        {
            string wordStart = PickRandomWord(_wordList);
            
            string resultWord = wordStart;
            for (int i = 0; i < nameLength - 1; i++)
            {
                string wordFragment = PickRandomWord(_wordList);
                resultWord += wordFragment;
            }
            return resultWord;
        }*/
        #endregion
    }
}