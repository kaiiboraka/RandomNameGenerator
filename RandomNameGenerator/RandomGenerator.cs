using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace RandomNameGenerator
{
    public partial class MainWindow : Form
    {
        private DataGridViewTextBoxColumn column;
        private string firstLetters;
        private string lastLetters;
        private int nameLength;
        private int nameQuantity;
        private const string BUTTON_TEXT_COPY = "&Copy Results";
        private const string BUTTON_TEXT_SORT = "S&ort Results";
        private const string BUTTON_TEXT_UNSORT = "&Unsort Results";
        private const string BUTTON_TEXT_RANDOM = "Randomize!";
        private string prefix;
        private string suffix;
        private static bool isSorted;
        const bool OFF = false;
        const bool ON = true;

        private static List<string> generatedList = new();
        private static List<string> sortedList = new();
        private static List<string> holdingList = new();

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
            
            buttonSort.Text = BUTTON_TEXT_SORT;
            buttonCopy.Text = BUTTON_TEXT_COPY;
            
            ToggleFileButtons(OFF);
            
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
            buttonCopy.Text = BUTTON_TEXT_COPY;
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

            
            ToggleAllFields(OFF);

            buttonSort.Text = BUTTON_TEXT_SORT;
            firstLetters = textPrefixFilter.Text.ToLower();
            lastLetters = textSuffixFilter.Text.ToLower();

            nameLength = trackBarNameLength.Value;
            nameQuantity = Convert.ToInt32(nameQuantityNumberInput.Value);

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

                nameLength = checkRandomLength.Checked ? 
                    NameRandomizer.RandomValue(trackBarNameLength.Minimum, trackBarNameLength.Maximum) 
                    : trackBarNameLength.Value;

                string resultWord = NameRandomizer.Randomize(ref prefix, ref suffix, ref firstLetters, ref lastLetters,
                    nameLength);

                generatedList.Add(resultWord);
                holdingList.Add(resultWord);
                sortedList.Add(resultWord);

                PickAndFillCell(i, resultWord);

                progressBarGenerating.PerformStep();

                if (resultWord.Contains("NULL") || resultWord.Contains("null"))
                {
                    MessageBox.Show("No matching word was found. Try a different word.", "Error: word not found.",
                        MessageBoxButtons.OK);
                    break;
                }
            }


            generatedList.Sort();
            sortedList = generatedList.ToList();
            generatedList = holdingList.ToList();

            ToggleAllFields(ON);
            checkRandomFirstLetters_CheckedChanged(this,null);
            checkRandomLastLetters_CheckedChanged(this,null);
            checkRandomLength_CheckedChanged(this,null);

            buttonRandom.Text = BUTTON_TEXT_RANDOM;

            progressBarGenerating.Value = 0;

            //progressBarGenerating.Visible = false;
        }

        private void ToggleAllFields(bool toggle)
        {
            TogglePrefixFields(toggle);
            ToggleSuffixFields(toggle);
            ToggleNameLengthFields(toggle);
            ToggleRandomButton(toggle);
            ToggleFileButtons(toggle);
            ToggleQuantityFields(toggle);
        }

        private void ToggleRandomButton(bool toggle)
        {
            buttonRandom.Enabled = toggle;
        }

        private void ToggleFileButtons(bool toggle)
        {
            buttonSort.Enabled = toggle && dataGridNames.Rows.Count > 1;
            buttonCopy.Enabled = toggle;
            buttonSave.Enabled = toggle;
        }

        private void CreateDataGridViewColumn(int index)
        {
            column = new DataGridViewTextBoxColumn();
            dataGridNames.Columns.Insert(index, column);
        }

        private void PickAndFillCell(int wordNum, string resultWord)
        {
            int colHeight = dataGridNames.Rows.Count;
            int colIndex = wordNum / colHeight;
            wordNum -= colHeight * colIndex;
            PopulateCellData(wordNum, colIndex, resultWord);
        }

        private void PopulateCellData(int row, int col, string word)
        {
            dataGridNames.Rows[row].Cells[col].Value = StringManipulator.CapitalizeWord(word);
        }

        private void CreateRows(int quantity)
        {
            const int colHeight = 20;
            int rowNumber = 1;
            int colNumber = 1;
            int numColumns = quantity / colHeight;
            if (quantity % colHeight > 0)
            {
                numColumns++;
            }

            for (int i = 0; i < numColumns; i++)
            {
                CreateDataGridViewColumn(i);
            }

            dataGridNames.Rows.Add(quantity <= colHeight ? quantity : colHeight);

            foreach (DataGridViewRow row in dataGridNames.Rows)
            {
                row.HeaderCell.Value = rowNumber.ToString();
                rowNumber += 1;
            }

            foreach (DataGridViewColumn gridViewColumn in dataGridNames.Columns)
            {
                gridViewColumn.HeaderCell.Value = colNumber.ToString();
                dataGridNames.AutoResizeColumnHeadersHeight(colNumber - 1);
                colNumber += 1;
            }

            dataGridNames.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
        
        private void checkRandomFirstLetters_CheckedChanged(object sender, EventArgs e)
        {
            TogglePrefixFields(!checkRandomFirstLetters.Checked);
        }

        private void checkRandomLastLetters_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSuffixFields(!checkRandomLastLetters.Checked);
        }

        private void checkRandomLength_CheckedChanged(object sender, EventArgs e)
        {
            ToggleNameLengthFields(!checkRandomLength.Checked);
        }

        private void ToggleSuffixFields(bool toggle)
        {
            labelSuffixDescription.Enabled = toggle;
            textSuffixInput.Enabled = toggle;
            labelSuffixInput.Enabled = toggle;
            textSuffixFilter.Enabled = toggle;
            labelSuffixFilterInput.Enabled = toggle;
        }

        private void TogglePrefixFields(bool toggle)
        {
            labelPrefixDescription.Enabled = toggle;
            textPrefixInput.Enabled = toggle;
            labelPrefixInput.Enabled = toggle;
            textPrefixFilter.Enabled = toggle;
            labelPrefixFilterInput.Enabled = toggle;
        }

        private void ToggleNameLengthFields(bool toggle)
        {
            trackBarNameLength.Enabled = toggle;
            labelTrackBarSize.Enabled = toggle;
            labelNameLength.Enabled = toggle;
            labelNameLengthDescription.Enabled = toggle;
        }

        private void ToggleQuantityFields(bool toggle)
        {
            labelQuantity.Enabled = toggle;
            labelQuantityDescription.Enabled = toggle;
            nameQuantityNumberInput.Enabled = toggle;
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
                    if (nameQuantityNumberInput.Value < nameQuantityNumberInput.Maximum)
                    {
                        nameQuantityNumberInput.Value++;
                    }

                    break;
                case Keys.Down:
                    if (nameQuantityNumberInput.Value > nameQuantityNumberInput.Minimum)
                    {
                        nameQuantityNumberInput.Value--;
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
            if (!buttonSort.Enabled) return;

            int generatedCount = generatedList.Count;
            int sortedCount = sortedList.Count;

            if (!isSorted)
            {
                for (int i = 0; i < generatedCount; i++)
                {
                    PickAndFillCell(i, sortedList[i]);
                }

                buttonSort.Text = BUTTON_TEXT_UNSORT;
                isSorted = true;
            }
            else if (isSorted)
            {
                for (int i = 0; i < sortedCount; i++)
                {
                    PickAndFillCell(i, generatedList[i]);
                }

                buttonSort.Text = BUTTON_TEXT_SORT;
                isSorted = false;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!buttonCopy.Enabled) return;

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Random Names.txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            using TextWriter tw = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.Unicode);

            for (int i = 0; i < dataGridNames.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridNames.Columns.Count; j++)
                {
                    tw.Write($"{dataGridNames.Rows[i].Cells[j].Value}");

                    if (j != dataGridNames.Columns.Count - 1)
                    {
                        tw.Write(",");
                    }
                }

                tw.WriteLine();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit? Don't forget to save your names!", "I'll miss you. :(",
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}