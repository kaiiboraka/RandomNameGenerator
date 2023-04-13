using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RandomNameGenerator
{
    public class FileIO
    {
        public static List<string> ReadListFromFile(string fileName)
        {
            List<string> wordList = File.ReadAllLines(fileName).ToList();

            return wordList;
        }

        public static JObject ReadFromJson(string fileName)
        {
            return (JObject)JsonConvert.DeserializeObject(File.ReadAllText(fileName));
        }

        public static void OpenFile(string fileName)
        {
            try
            {
                if (Directory.Exists(fileName))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                                                 {
                                                     Arguments = fileName,
                                                     FileName = "explorer.exe", 
                                                 };

                    Process.Start(startInfo);
                }
                else
                {
                    MessageBox.Show(string.Format("{0} Directory does not exist!", fileName));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}