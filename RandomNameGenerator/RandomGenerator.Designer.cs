namespace RandomNameGenerator
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dataGridNames = new System.Windows.Forms.DataGridView();
            this.nameQuantityNumberInput = new System.Windows.Forms.NumericUpDown();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.tableLayoutPanelLeftTop = new System.Windows.Forms.TableLayoutPanel();
            this.checkRandomLastLetters = new System.Windows.Forms.CheckBox();
            this.panelLastLetters = new System.Windows.Forms.Panel();
            this.textSuffixFilter = new System.Windows.Forms.TextBox();
            this.labelSuffixFilterInput = new System.Windows.Forms.Label();
            this.labelSuffixDescription = new System.Windows.Forms.Label();
            this.labelSuffixInput = new System.Windows.Forms.Label();
            this.textSuffixInput = new System.Windows.Forms.TextBox();
            this.panelFirstLetters = new System.Windows.Forms.Panel();
            this.textPrefixFilter = new System.Windows.Forms.TextBox();
            this.labelPrefixFilterInput = new System.Windows.Forms.Label();
            this.labelPrefixDescription = new System.Windows.Forms.Label();
            this.labelPrefixInput = new System.Windows.Forms.Label();
            this.textPrefixInput = new System.Windows.Forms.TextBox();
            this.panelNameLength = new System.Windows.Forms.Panel();
            this.labelNameLengthDescription = new System.Windows.Forms.Label();
            this.labelTrackBarSize = new System.Windows.Forms.Label();
            this.labelNameLength = new System.Windows.Forms.Label();
            this.trackBarNameLength = new System.Windows.Forms.TrackBar();
            this.checkRandomLength = new System.Windows.Forms.CheckBox();
            this.panelNameQuantity = new System.Windows.Forms.Panel();
            this.nameQuantityMaxButton = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelQuantityDescription = new System.Windows.Forms.Label();
            this.checkRandomFirstLetters = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.panelRightMain = new System.Windows.Forms.Panel();
            this.progressBarGenerating = new System.Windows.Forms.ProgressBar();
            this.toolTipFirstLetters = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLastLetters = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLength = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipQuantity = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRandomize = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSort = new System.Windows.Forms.Button();
            this.tableLayoutPanelSort = new System.Windows.Forms.TableLayoutPanel();
            this.alwaysSortCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameQuantityNumberInput)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelLeftTop.SuspendLayout();
            this.panelLastLetters.SuspendLayout();
            this.panelFirstLetters.SuspendLayout();
            this.panelNameLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNameLength)).BeginInit();
            this.panelNameQuantity.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.panelRightMain.SuspendLayout();
            this.tableLayoutPanelSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridNames
            // 
            this.dataGridNames.AllowUserToAddRows = false;
            this.dataGridNames.AllowUserToDeleteRows = false;
            this.dataGridNames.AllowUserToResizeColumns = false;
            this.dataGridNames.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridNames.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridNames.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridNames.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridNames.ColumnHeadersVisible = false;
            this.dataGridNames.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridNames.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridNames.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridNames.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridNames.Location = new System.Drawing.Point(0, 0);
            this.dataGridNames.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridNames.Name = "dataGridNames";
            this.dataGridNames.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNames.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridNames.RowHeadersVisible = false;
            this.dataGridNames.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridNames.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridNames.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridNames.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridNames.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridNames.RowTemplate.ReadOnly = true;
            this.dataGridNames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridNames.ShowCellErrors = false;
            this.dataGridNames.ShowCellToolTips = false;
            this.dataGridNames.ShowEditingIcon = false;
            this.dataGridNames.ShowRowErrors = false;
            this.dataGridNames.Size = new System.Drawing.Size(488, 513);
            this.dataGridNames.TabIndex = 9;
            this.dataGridNames.TabStop = false;
            // 
            // nameQuantityNumberInput
            // 
            this.nameQuantityNumberInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameQuantityNumberInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameQuantityNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameQuantityNumberInput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameQuantityNumberInput.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nameQuantityNumberInput.Location = new System.Drawing.Point(138, 58);
            this.nameQuantityNumberInput.Margin = new System.Windows.Forms.Padding(0);
            this.nameQuantityNumberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nameQuantityNumberInput.Name = "nameQuantityNumberInput";
            this.nameQuantityNumberInput.Size = new System.Drawing.Size(75, 27);
            this.nameQuantityNumberInput.TabIndex = 5;
            this.nameQuantityNumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipQuantity.SetToolTip(this.nameQuantityNumberInput, "Hotkey: Up Arrow, Down Arrow, Scroll Wheel\r\n\r\nNumber of Names:\r\n\r\nUse this contro" +
        "l to change the number of random names\r\ngenerated to anywhere between 1 and  nam" +
        "es at a time.\r\n\r\n");
            this.nameQuantityNumberInput.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nameQuantityNumberInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonCopy
            // 
            this.buttonCopy.AutoSize = true;
            this.buttonCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCopy.Location = new System.Drawing.Point(3, 38);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(165, 29);
            this.buttonCopy.TabIndex = 11;
            this.buttonCopy.Text = "&Copy Results";
            this.toolTipButton.SetToolTip(this.buttonCopy, resources.GetString("buttonCopy.ToolTip"));
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Location = new System.Drawing.Point(3, 73);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(165, 29);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "&Save Results";
            this.toolTipButton.SetToolTip(this.buttonSave, "Save Results:\r\n\r\nClick this button to export the entire table of generated names\r" +
        "\nto a brand new text (.txt) file, and Save As to a location somewhere\r\non your c" +
        "omputer.");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelLeft, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelRightMain, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(944, 519);
            this.tableLayoutPanelMain.TabIndex = 24;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.Controls.Add(this.buttonRandom, 0, 1);
            this.tableLayoutPanelLeft.Controls.Add(this.tableLayoutPanelLeftTop, 0, 0);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 2;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(450, 519);
            this.tableLayoutPanelLeft.TabIndex = 25;
            // 
            // buttonRandom
            // 
            this.buttonRandom.BackColor = System.Drawing.Color.Transparent;
            this.buttonRandom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRandom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRandom.FlatAppearance.BorderSize = 20;
            this.buttonRandom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonRandom.Location = new System.Drawing.Point(0, 419);
            this.buttonRandom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(450, 100);
            this.buttonRandom.TabIndex = 6;
            this.buttonRandom.TabStop = false;
            this.buttonRandom.Text = "Randomize!";
            this.toolTipRandomize.SetToolTip(this.buttonRandom, resources.GetString("buttonRandom.ToolTip"));
            this.buttonRandom.UseVisualStyleBackColor = false;
            this.buttonRandom.UseWaitCursor = true;
            this.buttonRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // tableLayoutPanelLeftTop
            // 
            this.tableLayoutPanelLeftTop.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelLeftTop.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelLeftTop.ColumnCount = 2;
            this.tableLayoutPanelLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanelLeftTop.Controls.Add(this.checkRandomLastLetters, 1, 1);
            this.tableLayoutPanelLeftTop.Controls.Add(this.panelLastLetters, 0, 1);
            this.tableLayoutPanelLeftTop.Controls.Add(this.panelFirstLetters, 0, 0);
            this.tableLayoutPanelLeftTop.Controls.Add(this.panelNameLength, 0, 2);
            this.tableLayoutPanelLeftTop.Controls.Add(this.checkRandomLength, 1, 2);
            this.tableLayoutPanelLeftTop.Controls.Add(this.panelNameQuantity, 0, 3);
            this.tableLayoutPanelLeftTop.Controls.Add(this.checkRandomFirstLetters, 1, 0);
            this.tableLayoutPanelLeftTop.Controls.Add(this.tableLayoutPanelButtons, 1, 3);
            this.tableLayoutPanelLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftTop.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLeftTop.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelLeftTop.Name = "tableLayoutPanelLeftTop";
            this.tableLayoutPanelLeftTop.RowCount = 4;
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLeftTop.Size = new System.Drawing.Size(450, 419);
            this.tableLayoutPanelLeftTop.TabIndex = 10;
            // 
            // checkRandomLastLetters
            // 
            this.checkRandomLastLetters.AutoSize = true;
            this.checkRandomLastLetters.BackColor = System.Drawing.Color.Transparent;
            this.checkRandomLastLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkRandomLastLetters.Location = new System.Drawing.Point(281, 108);
            this.checkRandomLastLetters.Name = "checkRandomLastLetters";
            this.checkRandomLastLetters.Padding = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.checkRandomLastLetters.Size = new System.Drawing.Size(165, 97);
            this.checkRandomLastLetters.TabIndex = 8;
            this.checkRandomLastLetters.Text = "Random Last Letter(s)";
            this.checkRandomLastLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLastLetters.SetToolTip(this.checkRandomLastLetters, resources.GetString("checkRandomLastLetters.ToolTip"));
            this.checkRandomLastLetters.UseVisualStyleBackColor = false;
            this.checkRandomLastLetters.CheckedChanged += new System.EventHandler(this.checkRandomLastLetters_CheckedChanged);
            // 
            // panelLastLetters
            // 
            this.panelLastLetters.BackColor = System.Drawing.Color.Transparent;
            this.panelLastLetters.Controls.Add(this.textSuffixFilter);
            this.panelLastLetters.Controls.Add(this.labelSuffixFilterInput);
            this.panelLastLetters.Controls.Add(this.labelSuffixDescription);
            this.panelLastLetters.Controls.Add(this.labelSuffixInput);
            this.panelLastLetters.Controls.Add(this.textSuffixInput);
            this.panelLastLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLastLetters.Location = new System.Drawing.Point(1, 105);
            this.panelLastLetters.Margin = new System.Windows.Forms.Padding(0);
            this.panelLastLetters.Name = "panelLastLetters";
            this.panelLastLetters.Size = new System.Drawing.Size(276, 103);
            this.panelLastLetters.TabIndex = 2;
            this.toolTipLastLetters.SetToolTip(this.panelLastLetters, resources.GetString("panelLastLetters.ToolTip"));
            // 
            // textSuffixFilter
            // 
            this.textSuffixFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textSuffixFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textSuffixFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSuffixFilter.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.textSuffixFilter.ForeColor = System.Drawing.Color.White;
            this.textSuffixFilter.Location = new System.Drawing.Point(143, 64);
            this.textSuffixFilter.Margin = new System.Windows.Forms.Padding(0);
            this.textSuffixFilter.Name = "textSuffixFilter";
            this.textSuffixFilter.Size = new System.Drawing.Size(100, 22);
            this.textSuffixFilter.TabIndex = 3;
            this.toolTipLastLetters.SetToolTip(this.textSuffixFilter, resources.GetString("textSuffixFilter.ToolTip"));
            // 
            // labelSuffixFilterInput
            // 
            this.labelSuffixFilterInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSuffixFilterInput.AutoSize = true;
            this.labelSuffixFilterInput.Location = new System.Drawing.Point(12, 66);
            this.labelSuffixFilterInput.Margin = new System.Windows.Forms.Padding(0);
            this.labelSuffixFilterInput.Name = "labelSuffixFilterInput";
            this.labelSuffixFilterInput.Size = new System.Drawing.Size(124, 13);
            this.labelSuffixFilterInput.TabIndex = 7;
            this.labelSuffixFilterInput.Text = "Last Letter(s) Generated:";
            this.toolTipLastLetters.SetToolTip(this.labelSuffixFilterInput, resources.GetString("labelSuffixFilterInput.ToolTip"));
            // 
            // labelSuffixDescription
            // 
            this.labelSuffixDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSuffixDescription.AutoSize = true;
            this.labelSuffixDescription.Location = new System.Drawing.Point(7, 12);
            this.labelSuffixDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelSuffixDescription.Name = "labelSuffixDescription";
            this.labelSuffixDescription.Size = new System.Drawing.Size(250, 13);
            this.labelSuffixDescription.TabIndex = 6;
            this.labelSuffixDescription.Text = "What letter(s) do you want the name(s) to end with?\r\n";
            this.labelSuffixDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLastLetters.SetToolTip(this.labelSuffixDescription, resources.GetString("labelSuffixDescription.ToolTip"));
            // 
            // labelSuffixInput
            // 
            this.labelSuffixInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSuffixInput.AutoSize = true;
            this.labelSuffixInput.Location = new System.Drawing.Point(42, 40);
            this.labelSuffixInput.Margin = new System.Windows.Forms.Padding(0);
            this.labelSuffixInput.Name = "labelSuffixInput";
            this.labelSuffixInput.Size = new System.Drawing.Size(93, 13);
            this.labelSuffixInput.TabIndex = 2;
            this.labelSuffixInput.Text = "Static name suffix:";
            this.toolTipLastLetters.SetToolTip(this.labelSuffixInput, "\r\nStatic Name Suffix:\r\n\r\nUse this form to add exact letters to the end of the wor" +
        "ds you generate.\r\nThese letters will not change or disappear unless you delete t" +
        "hem from the box.");
            // 
            // textSuffixInput
            // 
            this.textSuffixInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textSuffixInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textSuffixInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSuffixInput.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.textSuffixInput.ForeColor = System.Drawing.Color.White;
            this.textSuffixInput.Location = new System.Drawing.Point(143, 36);
            this.textSuffixInput.Margin = new System.Windows.Forms.Padding(0);
            this.textSuffixInput.Name = "textSuffixInput";
            this.textSuffixInput.Size = new System.Drawing.Size(100, 22);
            this.textSuffixInput.TabIndex = 2;
            this.toolTipLastLetters.SetToolTip(this.textSuffixInput, "\r\nStatic Name Suffix:\r\n\r\nUse this form to add exact letters to the end of the wor" +
        "ds you generate.\r\nThese letters will not change or disappear unless you delete t" +
        "hem from the box.");
            // 
            // panelFirstLetters
            // 
            this.panelFirstLetters.BackColor = System.Drawing.Color.Transparent;
            this.panelFirstLetters.Controls.Add(this.textPrefixFilter);
            this.panelFirstLetters.Controls.Add(this.labelPrefixFilterInput);
            this.panelFirstLetters.Controls.Add(this.labelPrefixDescription);
            this.panelFirstLetters.Controls.Add(this.labelPrefixInput);
            this.panelFirstLetters.Controls.Add(this.textPrefixInput);
            this.panelFirstLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFirstLetters.Location = new System.Drawing.Point(1, 1);
            this.panelFirstLetters.Margin = new System.Windows.Forms.Padding(0);
            this.panelFirstLetters.Name = "panelFirstLetters";
            this.panelFirstLetters.Size = new System.Drawing.Size(276, 103);
            this.panelFirstLetters.TabIndex = 1;
            this.toolTipFirstLetters.SetToolTip(this.panelFirstLetters, resources.GetString("panelFirstLetters.ToolTip"));
            // 
            // textPrefixFilter
            // 
            this.textPrefixFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textPrefixFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPrefixFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrefixFilter.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.textPrefixFilter.ForeColor = System.Drawing.Color.White;
            this.textPrefixFilter.Location = new System.Drawing.Point(143, 64);
            this.textPrefixFilter.Margin = new System.Windows.Forms.Padding(0);
            this.textPrefixFilter.Name = "textPrefixFilter";
            this.textPrefixFilter.Size = new System.Drawing.Size(100, 22);
            this.textPrefixFilter.TabIndex = 1;
            this.toolTipFirstLetters.SetToolTip(this.textPrefixFilter, resources.GetString("textPrefixFilter.ToolTip"));
            // 
            // labelPrefixFilterInput
            // 
            this.labelPrefixFilterInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrefixFilterInput.AutoSize = true;
            this.labelPrefixFilterInput.Location = new System.Drawing.Point(12, 66);
            this.labelPrefixFilterInput.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrefixFilterInput.Name = "labelPrefixFilterInput";
            this.labelPrefixFilterInput.Size = new System.Drawing.Size(123, 13);
            this.labelPrefixFilterInput.TabIndex = 7;
            this.labelPrefixFilterInput.Text = "First Letter(s) Generated:";
            this.toolTipFirstLetters.SetToolTip(this.labelPrefixFilterInput, resources.GetString("labelPrefixFilterInput.ToolTip"));
            // 
            // labelPrefixDescription
            // 
            this.labelPrefixDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPrefixDescription.AutoSize = true;
            this.labelPrefixDescription.Location = new System.Drawing.Point(7, 12);
            this.labelPrefixDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrefixDescription.Name = "labelPrefixDescription";
            this.labelPrefixDescription.Size = new System.Drawing.Size(252, 13);
            this.labelPrefixDescription.TabIndex = 6;
            this.labelPrefixDescription.Text = "What letter(s) do you want the name(s) to start with?\r\n";
            this.labelPrefixDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipFirstLetters.SetToolTip(this.labelPrefixDescription, resources.GetString("labelPrefixDescription.ToolTip"));
            // 
            // labelPrefixInput
            // 
            this.labelPrefixInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrefixInput.AutoSize = true;
            this.labelPrefixInput.Location = new System.Drawing.Point(41, 40);
            this.labelPrefixInput.Margin = new System.Windows.Forms.Padding(0);
            this.labelPrefixInput.Name = "labelPrefixInput";
            this.labelPrefixInput.Size = new System.Drawing.Size(94, 13);
            this.labelPrefixInput.TabIndex = 2;
            this.labelPrefixInput.Text = "Static name prefix:";
            this.toolTipFirstLetters.SetToolTip(this.labelPrefixInput, "\r\nStatic Name Prefix:\r\n\r\nUse this form to add exact letters to the start of the w" +
        "ords you generate.\r\nThese letters will not change or disappear unless you delete" +
        " them from the box.\r\n");
            // 
            // textPrefixInput
            // 
            this.textPrefixInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textPrefixInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPrefixInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrefixInput.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.textPrefixInput.ForeColor = System.Drawing.Color.White;
            this.textPrefixInput.Location = new System.Drawing.Point(143, 36);
            this.textPrefixInput.Margin = new System.Windows.Forms.Padding(0);
            this.textPrefixInput.Name = "textPrefixInput";
            this.textPrefixInput.Size = new System.Drawing.Size(100, 22);
            this.textPrefixInput.TabIndex = 0;
            this.toolTipFirstLetters.SetToolTip(this.textPrefixInput, "\r\nStatic Name Prefix:\r\n\r\nUse this form to add exact letters to the start of the w" +
        "ords you generate.\r\nThese letters will not change or disappear unless you delete" +
        " them from the box.\r\n");
            // 
            // panelNameLength
            // 
            this.panelNameLength.BackColor = System.Drawing.Color.Transparent;
            this.panelNameLength.Controls.Add(this.labelNameLengthDescription);
            this.panelNameLength.Controls.Add(this.labelTrackBarSize);
            this.panelNameLength.Controls.Add(this.labelNameLength);
            this.panelNameLength.Controls.Add(this.trackBarNameLength);
            this.panelNameLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNameLength.Location = new System.Drawing.Point(1, 209);
            this.panelNameLength.Margin = new System.Windows.Forms.Padding(0);
            this.panelNameLength.Name = "panelNameLength";
            this.panelNameLength.Size = new System.Drawing.Size(276, 103);
            this.panelNameLength.TabIndex = 2;
            this.toolTipLength.SetToolTip(this.panelNameLength, resources.GetString("panelNameLength.ToolTip"));
            // 
            // labelNameLengthDescription
            // 
            this.labelNameLengthDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNameLengthDescription.AutoSize = true;
            this.labelNameLengthDescription.Location = new System.Drawing.Point(35, 12);
            this.labelNameLengthDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelNameLengthDescription.Name = "labelNameLengthDescription";
            this.labelNameLengthDescription.Size = new System.Drawing.Size(204, 13);
            this.labelNameLengthDescription.TabIndex = 14;
            this.labelNameLengthDescription.Text = "How long do you want the name(s) to be?\r\n";
            this.labelNameLengthDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLength.SetToolTip(this.labelNameLengthDescription, resources.GetString("labelNameLengthDescription.ToolTip"));
            // 
            // labelTrackBarSize
            // 
            this.labelTrackBarSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTrackBarSize.AutoSize = true;
            this.labelTrackBarSize.BackColor = System.Drawing.Color.Transparent;
            this.labelTrackBarSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackBarSize.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTrackBarSize.Location = new System.Drawing.Point(234, 53);
            this.labelTrackBarSize.Margin = new System.Windows.Forms.Padding(0);
            this.labelTrackBarSize.Name = "labelTrackBarSize";
            this.labelTrackBarSize.Size = new System.Drawing.Size(13, 20);
            this.labelTrackBarSize.TabIndex = 15;
            this.labelTrackBarSize.Text = " ";
            this.labelTrackBarSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNameLength
            // 
            this.labelNameLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNameLength.AutoSize = true;
            this.labelNameLength.BackColor = System.Drawing.Color.Transparent;
            this.labelNameLength.Location = new System.Drawing.Point(61, 53);
            this.labelNameLength.Margin = new System.Windows.Forms.Padding(0);
            this.labelNameLength.Name = "labelNameLength";
            this.labelNameLength.Size = new System.Drawing.Size(74, 13);
            this.labelNameLength.TabIndex = 13;
            this.labelNameLength.Text = "Name Length:";
            this.toolTipLength.SetToolTip(this.labelNameLength, resources.GetString("labelNameLength.ToolTip"));
            // 
            // trackBarNameLength
            // 
            this.trackBarNameLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBarNameLength.AutoSize = false;
            this.trackBarNameLength.BackColor = System.Drawing.Color.Black;
            this.trackBarNameLength.LargeChange = 1;
            this.trackBarNameLength.Location = new System.Drawing.Point(133, 41);
            this.trackBarNameLength.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarNameLength.Maximum = 5;
            this.trackBarNameLength.Minimum = 1;
            this.trackBarNameLength.Name = "trackBarNameLength";
            this.trackBarNameLength.Size = new System.Drawing.Size(100, 40);
            this.trackBarNameLength.TabIndex = 4;
            this.trackBarNameLength.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.toolTipLength.SetToolTip(this.trackBarNameLength, resources.GetString("trackBarNameLength.ToolTip"));
            this.trackBarNameLength.Value = 1;
            this.trackBarNameLength.Scroll += new System.EventHandler(this.trackBarNameLength_Scroll);
            // 
            // checkRandomLength
            // 
            this.checkRandomLength.AutoSize = true;
            this.checkRandomLength.BackColor = System.Drawing.Color.Transparent;
            this.checkRandomLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkRandomLength.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkRandomLength.Location = new System.Drawing.Point(281, 212);
            this.checkRandomLength.Name = "checkRandomLength";
            this.checkRandomLength.Padding = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.checkRandomLength.Size = new System.Drawing.Size(165, 97);
            this.checkRandomLength.TabIndex = 9;
            this.checkRandomLength.Text = "Random Length";
            this.checkRandomLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipLength.SetToolTip(this.checkRandomLength, resources.GetString("checkRandomLength.ToolTip"));
            this.checkRandomLength.UseVisualStyleBackColor = false;
            this.checkRandomLength.CheckedChanged += new System.EventHandler(this.checkRandomLength_CheckedChanged);
            // 
            // panelNameQuantity
            // 
            this.panelNameQuantity.BackColor = System.Drawing.Color.Transparent;
            this.panelNameQuantity.Controls.Add(this.nameQuantityMaxButton);
            this.panelNameQuantity.Controls.Add(this.labelQuantity);
            this.panelNameQuantity.Controls.Add(this.nameQuantityNumberInput);
            this.panelNameQuantity.Controls.Add(this.labelQuantityDescription);
            this.panelNameQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNameQuantity.Location = new System.Drawing.Point(1, 313);
            this.panelNameQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.panelNameQuantity.Name = "panelNameQuantity";
            this.panelNameQuantity.Size = new System.Drawing.Size(276, 105);
            this.panelNameQuantity.TabIndex = 3;
            this.toolTipQuantity.SetToolTip(this.panelNameQuantity, "Hotkey: Up Arrow, Down Arrow, Scroll Wheel\r\n\r\nNumber of Names:\r\n\r\nUse this contro" +
        "l to change the number of random names\r\ngenerated to anywhere between 1 and  nam" +
        "es at a time.\r\n\r\n");
            // 
            // nameQuantityMaxButton
            // 
            this.nameQuantityMaxButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameQuantityMaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nameQuantityMaxButton.Location = new System.Drawing.Point(220, 61);
            this.nameQuantityMaxButton.Name = "nameQuantityMaxButton";
            this.nameQuantityMaxButton.Size = new System.Drawing.Size(40, 20);
            this.nameQuantityMaxButton.TabIndex = 8;
            this.nameQuantityMaxButton.Text = "&Max!";
            this.nameQuantityMaxButton.UseVisualStyleBackColor = true;
            this.nameQuantityMaxButton.Click += new System.EventHandler(this.nameQuantityMaxButton_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(40, 65);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(95, 13);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Number of Names:";
            this.toolTipQuantity.SetToolTip(this.labelQuantity, "Hotkey: Up Arrow, Down Arrow, Scroll Wheel\r\n\r\nNumber of Names:\r\n\r\nUse this contro" +
        "l to change the number of random names\r\ngenerated to anywhere between 1 and  nam" +
        "es at a time.\r\n\r\n");
            // 
            // labelQuantityDescription
            // 
            this.labelQuantityDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelQuantityDescription.AutoSize = true;
            this.labelQuantityDescription.Location = new System.Drawing.Point(7, 12);
            this.labelQuantityDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelQuantityDescription.Name = "labelQuantityDescription";
            this.labelQuantityDescription.Size = new System.Drawing.Size(263, 26);
            this.labelQuantityDescription.TabIndex = 7;
            this.labelQuantityDescription.Text = "How many names would you like to generate at once?\r\nThe maximum at one time is 10" +
    "0.";
            this.labelQuantityDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipQuantity.SetToolTip(this.labelQuantityDescription, "Hotkey: Up Arrow, Down Arrow, Scroll Wheel\r\n\r\nNumber of Names:\r\n\r\nUse this contro" +
        "l to change the number of random names\r\ngenerated to anywhere between 1 and  nam" +
        "es at a time.\r\n\r\n");
            // 
            // checkRandomFirstLetters
            // 
            this.checkRandomFirstLetters.AutoSize = true;
            this.checkRandomFirstLetters.BackColor = System.Drawing.Color.Transparent;
            this.checkRandomFirstLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkRandomFirstLetters.Location = new System.Drawing.Point(281, 4);
            this.checkRandomFirstLetters.Name = "checkRandomFirstLetters";
            this.checkRandomFirstLetters.Padding = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.checkRandomFirstLetters.Size = new System.Drawing.Size(165, 97);
            this.checkRandomFirstLetters.TabIndex = 7;
            this.checkRandomFirstLetters.Text = "Random First Letter(s)";
            this.checkRandomFirstLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipFirstLetters.SetToolTip(this.checkRandomFirstLetters, resources.GetString("checkRandomFirstLetters.ToolTip"));
            this.checkRandomFirstLetters.UseVisualStyleBackColor = false;
            this.checkRandomFirstLetters.CheckedChanged += new System.EventHandler(this.checkRandomFirstLetters_CheckedChanged);
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.AutoSize = true;
            this.tableLayoutPanelButtons.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Controls.Add(this.tableLayoutPanelSort, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonCopy, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonSave, 0, 2);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(278, 313);
            this.tableLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 3;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(171, 105);
            this.tableLayoutPanelButtons.TabIndex = 10;
            // 
            // panelRightMain
            // 
            this.panelRightMain.Controls.Add(this.progressBarGenerating);
            this.panelRightMain.Controls.Add(this.dataGridNames);
            this.panelRightMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightMain.Location = new System.Drawing.Point(453, 3);
            this.panelRightMain.Name = "panelRightMain";
            this.panelRightMain.Size = new System.Drawing.Size(488, 513);
            this.panelRightMain.TabIndex = 26;
            // 
            // progressBarGenerating
            // 
            this.progressBarGenerating.BackColor = System.Drawing.Color.Fuchsia;
            this.progressBarGenerating.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarGenerating.Location = new System.Drawing.Point(0, 490);
            this.progressBarGenerating.Name = "progressBarGenerating";
            this.progressBarGenerating.Size = new System.Drawing.Size(488, 23);
            this.progressBarGenerating.Step = 1;
            this.progressBarGenerating.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarGenerating.TabIndex = 25;
            // 
            // toolTipFirstLetters
            // 
            this.toolTipFirstLetters.AutomaticDelay = 550;
            this.toolTipFirstLetters.AutoPopDelay = 350000;
            this.toolTipFirstLetters.InitialDelay = 550;
            this.toolTipFirstLetters.IsBalloon = true;
            this.toolTipFirstLetters.ReshowDelay = 110;
            this.toolTipFirstLetters.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipFirstLetters.ToolTipTitle = "About Prefix Generation";
            // 
            // toolTipLastLetters
            // 
            this.toolTipLastLetters.AutomaticDelay = 550;
            this.toolTipLastLetters.AutoPopDelay = 350000;
            this.toolTipLastLetters.InitialDelay = 550;
            this.toolTipLastLetters.IsBalloon = true;
            this.toolTipLastLetters.ReshowDelay = 110;
            this.toolTipLastLetters.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipLastLetters.ToolTipTitle = "About Suffix Generation";
            // 
            // toolTipLength
            // 
            this.toolTipLength.AutomaticDelay = 550;
            this.toolTipLength.AutoPopDelay = 350000;
            this.toolTipLength.InitialDelay = 550;
            this.toolTipLength.IsBalloon = true;
            this.toolTipLength.ReshowDelay = 110;
            this.toolTipLength.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipLength.ToolTipTitle = "About Generated Word Length";
            // 
            // toolTipButton
            // 
            this.toolTipButton.AutomaticDelay = 550;
            this.toolTipButton.AutoPopDelay = 350000;
            this.toolTipButton.InitialDelay = 550;
            this.toolTipButton.IsBalloon = true;
            this.toolTipButton.ReshowDelay = 110;
            // 
            // toolTipQuantity
            // 
            this.toolTipQuantity.AutomaticDelay = 550;
            this.toolTipQuantity.AutoPopDelay = 350000;
            this.toolTipQuantity.InitialDelay = 550;
            this.toolTipQuantity.IsBalloon = true;
            this.toolTipQuantity.ReshowDelay = 110;
            this.toolTipQuantity.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipQuantity.ToolTipTitle = "About Name Quantity";
            // 
            // toolTipRandomize
            // 
            this.toolTipRandomize.AutomaticDelay = 550;
            this.toolTipRandomize.AutoPopDelay = 350000;
            this.toolTipRandomize.InitialDelay = 550;
            this.toolTipRandomize.IsBalloon = true;
            this.toolTipRandomize.ReshowDelay = 110;
            this.toolTipRandomize.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipRandomize.ToolTipTitle = "RANDOMIZE!";
            // 
            // buttonSort
            // 
            this.buttonSort.AutoSize = true;
            this.buttonSort.BackColor = System.Drawing.Color.Transparent;
            this.buttonSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSort.Location = new System.Drawing.Point(0, 0);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(100, 29);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "S&ort Results";
            this.toolTipButton.SetToolTip(this.buttonSort, "Sort Results:\r\n\r\nClick this button to alphabetize the generated words in columns." +
        "\r\n\r\nUnsort Results:\r\n\r\nClick this button to de-alphabetize the list and return i" +
        "t to its initial\r\nunsorted order.\r\n");
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // tableLayoutPanelSort
            // 
            this.tableLayoutPanelSort.ColumnCount = 2;
            this.tableLayoutPanelSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSort.Controls.Add(this.buttonSort, 0, 0);
            this.tableLayoutPanelSort.Controls.Add(this.alwaysSortCheckBox, 1, 0);
            this.tableLayoutPanelSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSort.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelSort.Name = "tableLayoutPanelSort";
            this.tableLayoutPanelSort.RowCount = 1;
            this.tableLayoutPanelSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSort.Size = new System.Drawing.Size(165, 29);
            this.tableLayoutPanelSort.TabIndex = 13;
            // 
            // alwaysSortCheckBox
            // 
            this.alwaysSortCheckBox.AutoSize = true;
            this.alwaysSortCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alwaysSortCheckBox.Location = new System.Drawing.Point(103, 3);
            this.alwaysSortCheckBox.Name = "alwaysSortCheckBox";
            this.alwaysSortCheckBox.Size = new System.Drawing.Size(59, 23);
            this.alwaysSortCheckBox.TabIndex = 11;
            this.alwaysSortCheckBox.Text = "Always";
            this.alwaysSortCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alwaysSortCheckBox.UseVisualStyleBackColor = true;
            this.alwaysSortCheckBox.CheckedChanged += new System.EventHandler(this.alwaysSortCheckBox_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(944, 519);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 535);
            this.Name = "MainWindow";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Name Generator";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.RandomGenerator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormWindow_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameQuantityNumberInput)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.tableLayoutPanelLeftTop.ResumeLayout(false);
            this.tableLayoutPanelLeftTop.PerformLayout();
            this.panelLastLetters.ResumeLayout(false);
            this.panelLastLetters.PerformLayout();
            this.panelFirstLetters.ResumeLayout(false);
            this.panelFirstLetters.PerformLayout();
            this.panelNameLength.ResumeLayout(false);
            this.panelNameLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNameLength)).EndInit();
            this.panelNameQuantity.ResumeLayout(false);
            this.panelNameQuantity.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelButtons.PerformLayout();
            this.panelRightMain.ResumeLayout(false);
            this.tableLayoutPanelSort.ResumeLayout(false);
            this.tableLayoutPanelSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridNames;
        private System.Windows.Forms.NumericUpDown nameQuantityNumberInput;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftTop;
        private System.Windows.Forms.Panel panelFirstLetters;
        private System.Windows.Forms.Label labelPrefixDescription;
        private System.Windows.Forms.Label labelPrefixInput;
        private System.Windows.Forms.TextBox textPrefixInput;
        private System.Windows.Forms.Panel panelNameLength;
        private System.Windows.Forms.Panel panelNameQuantity;
        private System.Windows.Forms.TrackBar trackBarNameLength;
        private System.Windows.Forms.Label labelTrackBarSize;
        private System.Windows.Forms.Label labelQuantityDescription;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelNameLength;
        private System.Windows.Forms.Label labelNameLengthDescription;
        private System.Windows.Forms.CheckBox checkRandomFirstLetters;
        private System.Windows.Forms.CheckBox checkRandomLength;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.TextBox textPrefixFilter;
        private System.Windows.Forms.Label labelPrefixFilterInput;
        private System.Windows.Forms.Panel panelLastLetters;
        private System.Windows.Forms.TextBox textSuffixFilter;
        private System.Windows.Forms.Label labelSuffixFilterInput;
        private System.Windows.Forms.Label labelSuffixDescription;
        private System.Windows.Forms.Label labelSuffixInput;
        private System.Windows.Forms.TextBox textSuffixInput;
        private System.Windows.Forms.CheckBox checkRandomLastLetters;
        private System.Windows.Forms.ToolTip toolTipFirstLetters;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.ToolTip toolTipLastLetters;
        private System.Windows.Forms.ToolTip toolTipLength;
        private System.Windows.Forms.ToolTip toolTipQuantity;
        private System.Windows.Forms.ToolTip toolTipRandomize;
        private System.Windows.Forms.Panel panelRightMain;
        private System.Windows.Forms.ProgressBar progressBarGenerating;
        private System.Windows.Forms.Button nameQuantityMaxButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSort;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.CheckBox alwaysSortCheckBox;
    }
}

