using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RandomNameGenerator
{
    public partial class MainWindow : Form
    {
        private const string BUTTON_TEXT_COPY = "&Copy Results";
        private const string BUTTON_TEXT_SORT = "S&ort Results";
        private const string BUTTON_TEXT_UNSORT = "&Unsort Results";
        private const string BUTTON_TEXT_RANDOM = "&Randomize!";
        private const string STATUS_TEXT = "Result Count: ";
        private const int MAX_NAMES = 1000;
        const bool OFF = false;
        const bool ON = true;

        private string firstLetters;
        private string lastLetters;
        private int nameLength;
        private int currentMaxNames;
        private string prefix;
        private string suffix;
        private static int nameQuantity;
        private static bool isSorted;
        private static bool main;

        private static HashSet<string> generatedSet = new();
        private static SortedSet<string> sortedSet = new();

        private static HashSet<string> elementalSet = new();
        private static List<string> generatedElements = new();
        private static ElementNameType currentElement;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Awake(object sender, EventArgs e)
        {
            NameGenerator.Initialize();
            trackBarNameLength.Minimum = 1;
            trackBarNameLength.Maximum = 5;
            trackBarNameLength.TickFrequency = 1;
            trackBarNameLength.Value = 3;
            labelTrackBarSize.Text = trackBarNameLength.Value.ToString();

            textPrefixInput.Text = "";
            textPrefixFilter.Text = "";
            textSuffixInput.Text = "";
            textSuffixFilter.Text = "";

            main_NumberInputQuantity.Value = 15;
            elem_NumberInputQuantity.Value = 15;

            checkRandomLength.Checked = false;
            checkRandomFirstLetters.Checked = false;
            checkRandomLastLetters.Checked = false;
            alwaysSortCheckBox.Checked = false;
            elem_CheckGenerateAll.Checked = false;

            isSorted = false;

            main_ButtonSort.Text = BUTTON_TEXT_SORT;
            main_ButtonCopy.Text = BUTTON_TEXT_COPY;

            ToggleFileButtons(OFF);

            main_Names.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

            main_NumberInputQuantity.Maximum = MAX_NAMES;

            SetQtyDescText(main_LabelQuantityDescription, MAX_NAMES);
            SetQtyDescText(elem_LabelQuantityDescription, MAX_NAMES);

            main_ProgressBar.Minimum = 0;
            main_ProgressBar.Maximum = MAX_NAMES;

            main_ProgressBar.Value = 0;
            main_ProgressBar.Step = 1;

            main_ProgressBar.Visible = false;
            elem_ProgressBar.Visible = false;

            elem_ComboBox.Items.Clear();
            foreach (ElementNameType nameType in (ElementNameType[])Enum.GetValues(typeof(ElementNameType)))
            {
                if (nameType == ElementNameType.Suffix) continue;
                elem_ComboBox.Items.Add(nameType);
            }

            elem_ComboBox.SelectedItem = ElementNameType.Sun;
            elem_ComboBox_SelectedIndexChanged(this, null);

            SetStatusText(0);

            main_Names.Rows.Clear();
            main_Names.Columns.Clear();
            main_Names.Refresh();

            elem_Names.Rows.Clear();
            elem_Names.Columns.Clear();
            elem_Names.Refresh();

            window_TabControl.SelectedTab = tab_Main;
        }

        private void main_ButtonRandom_Click(object sender, EventArgs e)
        {
            main_ButtonCopy.Text = BUTTON_TEXT_COPY;
            if (main_Names.Columns.Count > 0)
            {
                main_Names.Columns.Clear();
            }

            generatedSet.Clear();
            sortedSet.Clear();

            main_Names.Rows.Clear();
            main_Names.Refresh();

            isSorted = false;


            main_ButtonRandom.Text = "Generating";


            ToggleAllControls(OFF);

            main_ButtonSort.Text = BUTTON_TEXT_SORT;
            firstLetters = textPrefixFilter.Text.ToLower();
            lastLetters = textSuffixFilter.Text.ToLower();

            nameLength = trackBarNameLength.Value;

            prefix = textPrefixInput.Text.ToLower();
            suffix = textSuffixInput.Text.ToLower();

            nameQuantity = (int)main_NumberInputQuantity.Value;
            if (main_Names.Rows.Count <= 0)
            {
                CreateRows(main_PanelRight, main_Names, nameQuantity, trackBarNameLength.Value,
                    textPrefixInput.Text.Length, textSuffixInput.Text.Length);

                // CreateRows(nameQuantity, screenHeight / rowHeight);
            }

            main_ProgressBar.Maximum = nameQuantity;

            main_ProgressBar.Visible = true;
            main_ProgressBar.Value = 1;
            main_ProgressBar.Step = 1;

            FillMainNames();

            ToggleAllControls(ON);
            checkRandomFirstLetters_CheckedChanged(this, null);
            checkRandomLastLetters_CheckedChanged(this, null);
            checkRandomLength_CheckedChanged(this, null);

            main_ButtonRandom.Text = BUTTON_TEXT_RANDOM;

            main_ProgressBar.Value = 0;

            main_ProgressBar.Visible = false;

            LockSortButton();
            TrySort();
        }

        private void FillMainNames()
        {
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

                nameLength = checkRandomLength.Checked
                    ? NameGenerator.RandomValue(trackBarNameLength.Minimum, trackBarNameLength.Maximum)
                    : trackBarNameLength.Value;


                string resultWord = "";
                while (resultWord.Length <= 1)
                {
                    resultWord = NameGenerator.Randomize(ref prefix, ref suffix,
                        ref firstLetters, ref lastLetters, nameLength);
                }

                generatedSet.Add(resultWord);
                sortedSet.Add(resultWord);

                PickAndFillCell(main_Names, i, resultWord);

                main_ProgressBar.PerformStep();

                SetGeneratingText(i, main_ButtonRandom);
                SetStatusText(i + 1);
                if (resultWord.Contains("ERR_NULL", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("No matching word was found. Try a different word.", "Error: word not found.",
                        MessageBoxButtons.OK);
                    break;
                }
            }
        }

        private void elem_ButtonRandom_Click(object sender, EventArgs e)
        {
            main_ButtonCopy.Text = BUTTON_TEXT_COPY;
            if (elem_Names.Columns.Count > 0)
            {
                elem_Names.Columns.Clear();
            }

            elementalSet.Clear();

            elem_Names.Rows.Clear();
            elem_Names.Refresh();

            elem_ButtonRandom.Text = "Generating";

            ToggleAllControls(OFF);

            if (elem_CheckGenerateAll.Checked)
            {
                NameGenerator.FillElementalNames(elementalSet, currentElement);
            }
            else
            {
                nameQuantity = (int)elem_NumberInputQuantity.Value;
                double streak = 0;
                double limit = Math.Pow(2,18);
                double prevCount = 0;
                while (elementalSet.Count < nameQuantity)
                {
                    prevCount = elementalSet.Count;
                    string s = "";
                    while (s.Length <= 1)
                    {
                        s = NameGenerator.GetElementName(currentElement);
                        if (s == NameGenerator.ERR_NULL) break;
                    }

                    elementalSet.Add(s);
                    if (prevCount == elementalSet.Count) streak++;
                    else streak = 0;
                    if (streak >= limit) break;
                }
                System.GC.Collect();
            }

            nameQuantity = elementalSet.Count;

            SetStatusText(nameQuantity);

            CreateRows(elem_PanelRight, elem_Names, nameQuantity, 3,
                0, 0);

            generatedElements = elementalSet.ToList();
            
            elem_ProgressBar.Maximum = nameQuantity;
            elem_ProgressBar.Visible = true;
            elem_ProgressBar.Value = 1;
            elem_ProgressBar.Step = 1;

            int wordNum = 0;
            foreach (var s in generatedElements)
            {
                PickAndFillCell(elem_Names, wordNum, s);

                elem_ProgressBar.PerformStep();

                SetGeneratingText(wordNum, elem_ButtonRandom);
                wordNum++;
            }

            ToggleAllControls(ON);

            elem_ButtonRandom.Text = BUTTON_TEXT_RANDOM;

            elem_ProgressBar.Value = 0;

            elem_ProgressBar.Visible = false;

            window_TabControl_SelectedIndexChanged(this, null);
        }

        private static void CreateRows(Panel dataPanel, DataGridView names, int wordCount, int colMultiplier,
                                       int prepadding, int postpadding)
        {
            if (wordCount == 0) return;

            int colWidth = (42 * colMultiplier);


            colWidth += prepadding * 10;
            colWidth += postpadding * 10;

            int rowNumber = 1;
            int colNumber = 1;

            int numColumns = dataPanel.Size.Width / colWidth;
            numColumns = numColumns > wordCount ? wordCount : numColumns;

            int numRows = wordCount / numColumns;

            if (wordCount % numColumns > 0)
            {
                numRows++;
            }

            for (int i = 0; i < numColumns; i++)
            {
                CreateDataGridViewColumn(names, i);
            }

            names.Rows.Add(numRows);

            foreach (DataGridViewColumn gridViewColumn in names.Columns)
            {
                gridViewColumn.HeaderCell.Value = colNumber.ToString();
                names.AutoResizeColumnHeadersHeight(colNumber - 1);
                colNumber += 1;
            }

            foreach (DataGridViewRow row in names.Rows)
            {
                row.HeaderCell.Value = rowNumber.ToString();
                rowNumber += 1;
            }

            names.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private static void SetGeneratingText(int wordNum, Button elemButtonRandom)
        {
            if (wordNum / (float)nameQuantity > .75f)
            {
                if (elemButtonRandom.Text != "Generating...")
                {
                    elemButtonRandom.Text = "Generating...";
                    elemButtonRandom.Update();
                }
            }
            else if (wordNum / (float)nameQuantity > .5f)
            {
                if (elemButtonRandom.Text != "Generating..")
                {
                    elemButtonRandom.Text = "Generating..";
                    elemButtonRandom.Update();
                }
            }
            else if (wordNum / (float)nameQuantity > .25f)
            {
                if (elemButtonRandom.Text != "Generating.")
                {
                    elemButtonRandom.Text = "Generating.";
                    elemButtonRandom.Update();
                }
            }
        }

        private static void SetQtyDescText(Label labelQuantityDescription, int amount)
        {
            labelQuantityDescription.Text =
                $"How many names would you like to generate at once?\nThe maximum at one time is {amount}.";
        }

        private void SetStatusText(int quantity)
        {
            window_StatusStripLabel.Text = STATUS_TEXT + quantity;
        }

        private static void PickAndFillCell(DataGridView names, int wordNum, string resultWord)
        {
            // int colHeight = dataGridNames.Rows.Count;
            // int colIndex = wordNum / colHeight;
            // wordNum -= colHeight * colIndex;

            int rowIndex = wordNum / names.ColumnCount;
            int colIndex = wordNum % names.ColumnCount;

            names.Rows[rowIndex].Cells[colIndex].Value = StringManipulator.CapitalizeWord(resultWord);
        }

        private static void CreateDataGridViewColumn(DataGridView names, int index)
        {
            names.Columns.Insert(index, new DataGridViewTextBoxColumn());
        }

        private static void FillFromSet(IEnumerable<string> set, DataGridView names)
        {
            int i = 0;
            foreach (var s in set)
            {
                PickAndFillCell(names, i++, s);
            }
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

        private void ToggleAllControls(bool toggle)
        {
            TogglePrefixFields(toggle);
            ToggleSuffixFields(toggle);
            ToggleNameLengthFields(toggle);
            ToggleRandomButton(toggle);
            ToggleFileButtons(toggle);
            ToggleQuantityFields(toggle);

            ToggleElementalFields(toggle);
        }

        #region Toggles

        private void ToggleElementalFields(bool toggle)
        {
            elem_PromptLabel.Enabled = toggle;
            elem_TypeLabel.Enabled = toggle;
            elem_ComboBox.Enabled = toggle;
        }

        private void ToggleRandomButton(bool toggle)
        {
            main_ButtonRandom.Enabled = toggle;
            elem_ButtonRandom.Enabled = toggle;
        }

        private void ToggleFileButtons(bool toggle)
        {
            main_ButtonSort.Enabled = toggle && main_Names.Rows.Count > 1 && !alwaysSortCheckBox.Checked;
            main_ButtonCopy.Enabled = toggle;
            main_ButtonSave.Enabled = toggle;
            alwaysSortCheckBox.Enabled = toggle;

            elem_ButtonCopy.Enabled = toggle;
            elem_ButtonSave.Enabled = toggle;
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
            if (main) ToggleMainQtyFields(toggle);
            else ToggleElemQtyFields(toggle);
        }

        private void ToggleMainQtyFields(bool toggle)
        {
            main_LabelQuantity.Enabled = toggle;
            main_LabelQuantityDescription.Enabled = toggle;
            main_NumberInputQuantity.Enabled = toggle;
            main_ButtonQtyMax.Enabled = toggle;
        }

        private void ToggleElemQtyFields(bool toggle2)
        {
            bool toggle = toggle2 && !elem_CheckGenerateAll.Checked;
            elem_LabelQuantity.Enabled = toggle;
            elem_LabelQuantityDescription.Enabled = toggle;
            elem_NumberInputQuantity.Enabled = toggle;
            elem_ButtonQtyMax.Enabled = toggle;
        }

        #endregion Toggles

        private void main_TrackBarNameLength_Scroll(object sender, EventArgs e)
        {
            labelTrackBarSize.Text = trackBarNameLength.Value.ToString();
        }

        private void main_ButtonSort_Click(object sender, EventArgs e)
        {
            if (!main_ButtonSort.Enabled) return;

            SortGeneratedNames();
        }

        private void alwaysSortCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LockSortButton();
            TrySort();
        }

        private void LockSortButton()
        {
            main_ButtonSort.Enabled = generatedSet.Count > 0 && !alwaysSortCheckBox.Checked;
        }

        private void TrySort()
        {
            if (!alwaysSortCheckBox.Checked) return;

            isSorted = false;
            SortGeneratedNames();
        }

        private void SortGeneratedNames()
        {
            if (!isSorted)
            {
                FillFromSet(sortedSet, main_Names);

                main_ButtonSort.Text = BUTTON_TEXT_UNSORT;
                isSorted = true;
            }
            else if (isSorted)
            {
                FillFromSet(generatedSet, main_Names);

                main_ButtonSort.Text = BUTTON_TEXT_SORT;
                isSorted = false;
            }
        }

        private void elem_CheckGenerateAll_CheckedChanged(object sender, EventArgs e)
        {
            if (elem_CheckGenerateAll.Checked)
            {
                ToggleElemQtyFields(OFF);
            }
            else
            {
                ToggleElemQtyFields(ON);
            }
        }

        private void elem_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = elem_ComboBox.SelectedItem.ToString();

            currentElement = (ElementNameType)Enum.Parse(typeof(ElementNameType), selected);

            currentMaxNames = NameGenerator.GetCount(currentElement);
            SetQtyDescText(elem_LabelQuantityDescription, currentMaxNames);
            elem_NumberInputQuantity.Maximum = currentMaxNames;
        }

        private void main_ButtonCopy_Click(object sender, EventArgs e)
        {
            if (!main_ButtonCopy.Enabled) return;

            try
            {
                main_Names.ClearSelection();
                main_Names.MultiSelect = true;
                main_Names.SelectAll();

                // Add the selection to the clipboard.
                Clipboard.SetDataObject(main_Names.GetClipboardContent());
                main_Names.ClearSelection();
                main_ButtonCopy.Text = "Copied!";
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {
                main_ButtonCopy.Text = "Failed to Copy";
            }
        }

        private void elem_ButtonCopy_Click(object sender, EventArgs e)
        {
            if (!elem_ButtonCopy.Enabled) return;

            try
            {
                elem_Names.ClearSelection();
                elem_Names.MultiSelect = true;
                elem_Names.SelectAll();

                // Add the selection to the clipboard.
                Clipboard.SetDataObject(elem_Names.GetClipboardContent());
                elem_Names.ClearSelection();
                elem_ButtonCopy.Text = "Copied!";
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {
                elem_ButtonCopy.Text = "Failed to Copy";
            }
        }

        private void main_ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Random Names.txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            using TextWriter tw = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.Unicode);

            for (int i = 0; i < main_Names.Rows.Count - 1; i++)
            {
                for (int j = 0; j < main_Names.Columns.Count; j++)
                {
                    tw.Write($"{main_Names.Rows[i].Cells[j].Value}");

                    if (j != main_Names.Columns.Count - 1)
                    {
                        tw.Write(",");
                    }
                }

                tw.WriteLine();
            }
        }

        private void elem_ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Elemental Names.txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            using TextWriter tw = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.Unicode);

            for (int i = 0; i < elem_Names.Rows.Count - 1; i++)
            {
                for (int j = 0; j < elem_Names.Columns.Count; j++)
                {
                    tw.Write($"{elem_Names.Rows[i].Cells[j].Value}");

                    if (j != elem_Names.Columns.Count - 1)
                    {
                        tw.Write(",");
                    }
                }

                tw.WriteLine();
            }
        }

        private void main_NumberInputQuantity_ValueChanged(object sender, EventArgs e)
        {
            nameQuantity = (int)main_NumberInputQuantity.Value;
        }

        private void elem_NumberInputQuantity_ValueChanged(object sender, EventArgs e)
        {
            nameQuantity = (int)elem_NumberInputQuantity.Value;
        }

        private void main_ButtonQtyMax_Click(object sender, EventArgs e)
        {
            main_NumberInputQuantity.Value = MAX_NAMES;
        }

        private void elem_ButtonQtyMax_Click(object sender, EventArgs e)
        {
            elem_NumberInputQuantity.Value = currentMaxNames;
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized || Size.Width == 0 || Size.Height == 0) return;

            if (window_TabControl.SelectedTab == tab_Main)
            {
                main_Names.Rows.Clear();
                main_Names.Columns.Clear();

                if (sortedSet.Count == 0 || generatedSet.Count == 0) return;

                CreateRows(main_PanelRight, main_Names,
                    (int)main_NumberInputQuantity.Value,
                    trackBarNameLength.Value,
                    0, 0);

                FillFromSet(isSorted ? sortedSet : generatedSet, main_Names);

                main_Names.Refresh();
            }
            else if (window_TabControl.SelectedTab == tab_ElementalNames)
            {
                elem_Names.Rows.Clear();
                elem_Names.Columns.Clear();

                if (elementalSet.Count == 0) return;

                CreateRows(elem_PanelRight, elem_Names,
                    elementalSet.Count,
                    3,
                    0, 0);

                FillFromSet(elementalSet, elem_Names);

                elem_Names.Refresh();
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

        private void window_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            main = window_TabControl.SelectedTab == tab_Main;
        }

        private void FormWindow_KeyPress(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;

            NumericUpDown inputQuantity = main ? main_NumberInputQuantity : elem_NumberInputQuantity;

            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Space:
                    if (main) main_ButtonRandom_Click(sender, null);
                    else elem_ButtonRandom_Click(sender, null);
                    break;

                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Up:
                    if (inputQuantity.Value < inputQuantity.Maximum) inputQuantity.Value++;
                    break;

                case Keys.Down:
                    if (inputQuantity.Value > inputQuantity.Minimum) inputQuantity.Value--;
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

                case Keys.F5:
                    window_menu_Reload_Click(sender, e);
                    break;
                case Keys.F6:
                    openWordlistDirectoryToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F7:
                    updateWordlistsToolStripMenuItem_Click(sender, e);
                    break;

                default:
                    e.Handled = false;
                    e.SuppressKeyPress = false;
                    break;
            }
        }

        private void window_menu_Reload_Click(object sender, EventArgs e)
        {
            Awake(sender, e);
        }

        private void updateWordlistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameGenerator.Initialize();
        }

        private void openWordlistDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string relativePath = ConfigurationManager.AppSettings["wordListFileName"];
            FileIO.OpenFile(new FileInfo(relativePath).DirectoryName);
        }
    }
}