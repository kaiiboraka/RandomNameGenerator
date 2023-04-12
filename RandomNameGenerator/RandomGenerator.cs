using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace RandomNameGenerator
{
    public partial class MainWindow : Form
    {
        DataGridViewTextBoxColumn column;
        public string firstLetters;
        public string lastLetters;
        public int nameLength;
        public int nameQuantity;
        public string buttonTextCopy = "&Copy Results";
        public string buttonTextSort = "S&ort Results";
        public string buttonTextUnsort = "&Unsort Results";
        public string buttonTextRandom = "Randomize!";
        public string prefix;
        public string suffix;
        public static bool isSorted;

        public static List<string> generatedList = new List<string>();
        public static List<string> sortedList    = new List<string>();
        public static List<string> holdingList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            dataGridNames.Rows.Clear();
            dataGridNames.Refresh();
        }

        private void RandomGenerator_Load(object sender, EventArgs e)
        {
            NameRandomizer.Initialize();
            trackBarNameLength.Minimum = 1;
            trackBarNameLength.Maximum = 5;
            trackBarNameLength.TickFrequency = 1;
            trackBarNameLength.Value = 3;
            labelTrackBarSize.Text = trackBarNameLength.Value.ToString();
            isSorted = false;
            buttonSort.Text = buttonTextSort;
            buttonCopy.Text = buttonTextCopy;
            buttonSort.Enabled = false;
            buttonCopy.Enabled = false;
            buttonSave.Enabled = false;
            dataGridNames.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;


            // Display the ProgressBar control.
            progressBarGenerating.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            progressBarGenerating.Minimum = 0;
            // Set Maximum to the total number of files to copy.
            progressBarGenerating.Maximum = 100;
            // Set the initial value of the ProgressBar.
            progressBarGenerating.Value = 0;
            // Set the Step property to a value of 1 to represent each file being copied.
            progressBarGenerating.Step = 1;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {

            buttonCopy.Text = buttonTextCopy;
            if (dataGridNames.Columns.Count > 0)
            {
                dataGridNames.Columns.Clear();
            }
            generatedList.Clear();
            sortedList.Clear();
            holdingList.Clear();

            dataGridNames.Rows.Clear();
            dataGridNames.Refresh();

            isSorted = false;


            buttonRandom.Text = "Generating...";

            buttonSort.Enabled = false;
            buttonCopy.Enabled = false;
            buttonSave.Enabled = false;
            buttonRandom.Enabled = false;


            buttonSort.Text = buttonTextSort;
            firstLetters = textPrefixFilter.Text.ToLower();
            lastLetters = textSuffixFilter.Text.ToLower();

            nameLength = trackBarNameLength.Value;
            nameQuantity = Convert.ToInt32(numberInput.Value);

            progressBarGenerating.Maximum = nameQuantity;
            //progressBarGenerating.Visible = true;
            progressBarGenerating.Value = 1;
            progressBarGenerating.Step = 1;

            prefix = textPrefixInput.Text.ToLower();
            suffix = textSuffixInput.Text.ToLower();

            if (dataGridNames.Rows.Count <= 0)
            {
                CreateRows(nameQuantity);
            }
            //make new button to copy all printed values, or print them to a txt file

           

            #region Old randomize loop
            /*
            if (checkRandomFirstLetters.Checked)
            {
                for (int i = 0; i < nameQuantity; i++)
                {
                    string resultWord = NameRandomizer.Randomize(null, suffix, null, lastLetters, nameLength);
                    
                    PickAndFillCell(i, nameQuantity, resultWord);
                    //dataGridNames . add word as new entry (row, etc)
                }
            }
            else if (checkRandomLastLetters.Checked)
            {
                for (int i = 0; i < nameQuantity; i++)
                {
                    string resultWord = NameRandomizer.Randomize(null, suffix, null, lastLetters, nameLength);

                    PickAndFillCell(i, nameQuantity, resultWord);
                    //dataGridNames . add word as new entry (row, etc)
                }
            }
            else
            {
                for (int i = 0; i < nameQuantity; i++)
                {
                    string resultWord = NameRandomizer.Randomize(prefix, suffix, firstLetters, lastLetters, nameLength);

                    PickAndFillCell(i, nameQuantity, resultWord);
                }
            }
            */
            #endregion


            for (int i = 0; i < nameQuantity; i++)
            {
                if (checkRandomFirstLetters.Checked)
                {
                    prefix = null;
                    firstLetters = null;
                }

                if (checkRandomLastLetters.Checked)
                {
                    suffix = null;
                    lastLetters = null;
                }
                if (checkRandomLength.Checked)
                {
                    nameLength = NameRandomizer.PickRandomWordLength(trackBarNameLength.Minimum, trackBarNameLength.Maximum);
                }
                else
                {
                    nameLength = trackBarNameLength.Value;
                }
                string resultWord = NameRandomizer.Randomize(ref prefix, ref suffix, ref firstLetters, ref lastLetters, nameLength);

                generatedList.Add(resultWord);
                holdingList.Add(resultWord);
                sortedList.Add(resultWord);

                PickAndFillCell(i, nameQuantity, resultWord);

                progressBarGenerating.PerformStep();

                if (resultWord == "NULL")
                {
                    MessageBox.Show("No matching word was found. Try a different word.", "Error: word not found.", MessageBoxButtons.OK);
                    break;
                }

            }


            SortList(generatedList);
            sortedList = generatedList.ToList();
            generatedList = holdingList.ToList();

            if (dataGridNames.Rows.Count > 1)
            {
            buttonSort.Enabled   = true;}
            buttonCopy.Enabled   = true;
            buttonSave.Enabled   = true;
            buttonRandom.Enabled = true;

            buttonRandom.Text = buttonTextRandom;

            progressBarGenerating.Value = 0;
            //progressBarGenerating.Visible = false;
        }

        public void CreateDataGridViewColumn(int index)
        {
            column = new DataGridViewTextBoxColumn();
            dataGridNames.Columns.Insert(index, column);
        }

        public void PickAndFillCell(int wordNum, int quantity, string resultWord)
        {
            int colHeight = dataGridNames.Rows.Count;
            int colIndex = wordNum / colHeight;
            int remainder = quantity - wordNum;
            wordNum -= colHeight * colIndex;
            PopulateCellData(wordNum, colIndex, resultWord);

        }
       
        public void PopulateCellData(int row, int col, string word)
        {
            dataGridNames.Rows[row].Cells[col].Value = CapitalizeOutputWord(word);
        }

        public void CreateRows(int quantity)
        {
            int rowNumber = 1;
            int colNumber = 1;
            int colHeight = 20;
            int numColumns = quantity / colHeight;
            if (quantity % colHeight > 0)
            {
                numColumns++;
            }

            for (int i = 0; i < numColumns; i++)
            {
                CreateDataGridViewColumn(i);
            }

            if (quantity <= colHeight)
            {
                dataGridNames.Rows.Add(quantity);
            }
            else
            {
                dataGridNames.Rows.Add(colHeight);
            }    
            
            foreach (DataGridViewRow row in dataGridNames.Rows)
            {
                row.HeaderCell.Value = rowNumber.ToString();
                rowNumber += 1;
            }
            foreach (DataGridViewColumn column in dataGridNames.Columns)
            {
                column.HeaderCell.Value = colNumber.ToString();
                dataGridNames.AutoResizeColumnHeadersHeight(colNumber - 1);
                colNumber += 1;
            }

            dataGridNames.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            
        }

        public string CapitalizeOutputWord(string word)
        {
            string capitalized = word;
            if (word == "NULL")
            {
                return capitalized;
            }
            else
            {
                capitalized = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word.ToLower());
            }
            return capitalized;
        }

        public static List<string> SortList(List<string> generated)
        {
            generated.Sort();
            List<string> sorted = generated;
            return sorted;
        }

        private void checkRandomFirstLetters_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRandomFirstLetters.Checked == true)
            {
                labelPrefixDescription.Enabled = false;
                textPrefixInput.Enabled = false;
                labelPrefixInput.Enabled = false;
                textPrefixFilter.Enabled = false;
                labelPrefixFilterInput.Enabled = false;
            }
            else
            {
                labelPrefixDescription.Enabled = true;
                textPrefixInput.Enabled = true;
                labelPrefixInput.Enabled = true;
                textPrefixFilter.Enabled = true;
                labelPrefixFilterInput.Enabled = true;
            }
        }

        private void checkRandomLastLetters_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRandomLastLetters.Checked == true)
            {
                labelSuffixDescription.Enabled = false;
                textSuffixInput.Enabled = false;
                labelSuffixInput.Enabled = false;
                textSuffixFilter.Enabled = false;
                labelSuffixFilterInput.Enabled = false;
            }
            else
            {
                labelSuffixDescription.Enabled = true;
                textSuffixInput.Enabled = true;
                labelSuffixInput.Enabled = true;
                textSuffixFilter.Enabled = true;
                labelSuffixFilterInput.Enabled = true;
            }
        }

        private void checkRandomLength_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRandomLength.Checked == true)
            {
                trackBarNameLength.Enabled         = false;
                labelTrackBarSize.Enabled          = false;
                labelNameLength.Enabled            = false;
                labelNameLengthDescription.Enabled = false;
            }
            else
            {
                trackBarNameLength.Enabled         = true;
                labelTrackBarSize.Enabled          = true;
                labelNameLength.Enabled            = true;
                labelNameLengthDescription.Enabled = true;
            }
        }

        private void trackBarNameLength_Scroll(object sender, EventArgs e)
        {
            labelTrackBarSize.Text = trackBarNameLength.Value.ToString();
        }

        private void FormWindow_KeyPress(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Space:
                    btnRandom_Click(sender, null);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Up:
                    if (numberInput.Value < numberInput.Maximum)
                    {
                        numberInput.Value++;
                    }
                    break;
                case Keys.Down:
                    if (numberInput.Value > numberInput.Minimum)
                    {
                        numberInput.Value--;
                    }
                    break;
                case Keys.Right:
                    if (trackBarNameLength.Value < trackBarNameLength.Maximum)
                    {
                        trackBarNameLength.Value++;
                        labelTrackBarSize.Text = trackBarNameLength.Value.ToString();
                    }
                    break;
                case Keys.Left:
                    if (trackBarNameLength.Value > trackBarNameLength.Minimum)
                    {
                        trackBarNameLength.Value--;
                        labelTrackBarSize.Text = trackBarNameLength.Value.ToString();
                    }
                    break;
                default:
                     e.Handled = false;
                      e.SuppressKeyPress = false;
                    break;
            }
           
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (buttonSort.Enabled == true)
            {
                //dataGridNames.Sort();
                

                int generatedCount = generatedList.Count;
                int sortedCount = sortedList.Count;

                if (!isSorted)
                {
                    for (int i = 0; i < generatedCount; i++)
                    {
                        PickAndFillCell(i, sortedCount, sortedList[i]);
                    }
                    buttonSort.Text = buttonTextUnsort;
                    isSorted = true;
                }
                else if (isSorted)
                {
                    for (int i = 0; i < generatedCount; i++)
                    {
                        PickAndFillCell(i, generatedCount, generatedList[i]);
                    }
                    buttonSort.Text = buttonTextSort;
                    isSorted = false;
                }
                

            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (buttonCopy.Enabled == true)
            {
                try
                {
                    dataGridNames.ClearSelection();
                    dataGridNames.MultiSelect = true;
                    dataGridNames.SelectAll();
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(dataGridNames.GetClipboardContent());
                    dataGridNames.ClearSelection();
                    buttonCopy.Text = "Copied!";

                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    buttonCopy.Text = "Failed to Copy";
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Random Names.txt";
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (TextWriter tw = new StreamWriter(savefile.FileName, false, System.Text.Encoding.Unicode))
                {
                    for (int i = 0; i < dataGridNames.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridNames.Columns.Count; j++)
                        {
                            tw.Write($"{dataGridNames.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dataGridNames.Columns.Count - 1)
                            {
                                tw.Write(",");
                            }
                        }
                        tw.WriteLine();
                    }
                }
            }

            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit? Don't forget to save your names!", "I'll miss you. :(", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
