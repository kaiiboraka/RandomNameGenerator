using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace RandomNameGenerator
{
    public class FileIO
    {
        public static List <string> ReadListFromFile(string fileName)
        {
            List<string> wordList = File.ReadAllLines(fileName).ToList();

            return wordList;
        }
    }
}
