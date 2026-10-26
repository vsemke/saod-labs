namespace Lab3_BinarySearch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTopic = new Label();
            panelSearch = new Panel();
            lblSearchHeader = new Label();
            lblKey = new Label();
            nudKey = new NumericUpDown();
            btnRandom = new Button();
            btnFind = new Button();
            panelA = new Panel();
            lblAHeader = new Label();
            lblTimeA = new Label();
            txtTimeA = new TextBox();
            lblIndexA = new Label();
            txtIndexA = new TextBox();
            panelB = new Panel();
            lblBHeader = new Label();
            lblTimeB = new Label();
            txtTimeB = new TextBox();
            lblIndexB = new Label();
            txtIndexB = new TextBox();
            panelC = new Panel();
            lblCHeader = new Label();
            lblTimeC = new Label();
            txtTimeC = new TextBox();
            lblIndexC = new Label();
            txtIndexC = new TextBox();
            panelD = new Panel();
            lblDHeader = new Label();
            lblTimeD = new Label();
            txtTimeD = new TextBox();
            lblIndexD = new Label();
            txtIndexD = new TextBox();
            panelSeq = new Panel();
            lblSeqHeader = new Label();
            lblTimeSeq = new Label();
            txtTimeSeq = new TextBox();
            lblIndexSeq = new Label();
            txtIndexSeq = new TextBox();
            lblSeqMeasured = new Label();
            panelSettings = new Panel();
            lblSettingsHeader = new Label();
            lblSize = new Label();
            nudSize = new NumericUpDown();
            btnGenerate = new Button();
            lblBinRepeats = new Label();
            nudBinRepeats = new NumericUpDown();
            lblSeqRepeats = new Label();
            nudSeqRepeats = new NumericUpDown();
            lblNote = new Label();
            lblStatus = new Label();
            btnExit = new Button();
            panelSearch.SuspendLayout();
            panelA.SuspendLayout();
            panelB.SuspendLayout();
            panelC.SuspendLayout();
            panelD.SuspendLayout();
            panelSeq.SuspendLayout();
            panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudKey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBinRepeats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSeqRepeats).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 51, 102);
            lblTitle.Location = new Point(18, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Лабораторная работа № 3";
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.Font = new Font("Segoe UI", 11F);
            lblTopic.ForeColor = Color.FromArgb(0, 51, 102);
            lblTopic.Location = new Point(20, 48);
            lblTopic.Name = "lblTopic";
            lblTopic.TabIndex = 1;
            lblTopic.Text = "Бинарный поиск в упорядоченном массиве и сравнение с последовательным поиском";
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(204, 228, 247);
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(panelSeq);
            panelSearch.Controls.Add(panelD);
            panelSearch.Controls.Add(panelC);
            panelSearch.Controls.Add(panelB);
            panelSearch.Controls.Add(panelA);
            panelSearch.Controls.Add(btnFind);
            panelSearch.Controls.Add(btnRandom);
            panelSearch.Controls.Add(nudKey);
            panelSearch.Controls.Add(lblKey);
            panelSearch.Controls.Add(lblSearchHeader);
            panelSearch.Location = new Point(20, 85);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(860, 350);
            panelSearch.TabIndex = 2;
            // 
            // lblSearchHeader
            // 
            lblSearchHeader.AutoSize = true;
            lblSearchHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSearchHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblSearchHeader.Location = new Point(10, 8);
            lblSearchHeader.Name = "lblSearchHeader";
            lblSearchHeader.TabIndex = 0;
            lblSearchHeader.Text = "Поиск в упорядоченном массиве";
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Font = new Font("Segoe UI", 10F);
            lblKey.Location = new Point(14, 46);
            lblKey.Name = "lblKey";
            lblKey.TabIndex = 1;
            lblKey.Text = "Ключ:";
            // 
            // nudKey
            // 
            nudKey.Font = new Font("Segoe UI", 10F);
            nudKey.Location = new Point(70, 43);
            nudKey.Maximum = new decimal(new int[] { 2147483646, 0, 0, 0 });
            nudKey.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudKey.Name = "nudKey";
            nudKey.Size = new Size(150, 25);
            nudKey.TabIndex = 2;
            nudKey.TextAlign = HorizontalAlignment.Right;
            nudKey.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // btnRandom
            // 
            btnRandom.BackColor = Color.FromArgb(204, 228, 247);
            btnRandom.Font = new Font("Segoe UI", 9F);
            btnRandom.Location = new Point(232, 41);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(174, 29);
            btnRandom.TabIndex = 3;
            btnRandom.Text = "Случайный из массива";
            btnRandom.UseVisualStyleBackColor = false;
            btnRandom.Click += btnRandom_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(204, 228, 247);
            btnFind.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFind.Location = new Point(644, 39);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(200, 33);
            btnFind.TabIndex = 4;
            btnFind.Text = "Найти";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // panelA
            // 
            panelA.BackColor = Color.FromArgb(204, 228, 247);
            panelA.BorderStyle = BorderStyle.FixedSingle;
            panelA.Controls.Add(txtIndexA);
            panelA.Controls.Add(lblIndexA);
            panelA.Controls.Add(txtTimeA);
            panelA.Controls.Add(lblTimeA);
            panelA.Controls.Add(lblAHeader);
            panelA.Location = new Point(14, 84);
            panelA.Name = "panelA";
            panelA.Size = new Size(410, 78);
            panelA.TabIndex = 5;
            // 
            // lblAHeader
            // 
            lblAHeader.AutoSize = true;
            lblAHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblAHeader.Location = new Point(8, 6);
            lblAHeader.Name = "lblAHeader";
            lblAHeader.TabIndex = 0;
            lblAHeader.Text = "Неоптимальный бинарный поиск";
            // 
            // lblTimeA
            // 
            lblTimeA.AutoSize = true;
            lblTimeA.Font = new Font("Segoe UI", 10F);
            lblTimeA.Location = new Point(10, 42);
            lblTimeA.Name = "lblTimeA";
            lblTimeA.TabIndex = 1;
            lblTimeA.Text = "Время, тики:";
            // 
            // txtTimeA
            // 
            txtTimeA.BackColor = Color.White;
            txtTimeA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimeA.Location = new Point(105, 39);
            txtTimeA.Name = "txtTimeA";
            txtTimeA.ReadOnly = true;
            txtTimeA.Size = new Size(110, 25);
            txtTimeA.TabIndex = 2;
            txtTimeA.TabStop = false;
            txtTimeA.TextAlign = HorizontalAlignment.Right;
            // 
            // lblIndexA
            // 
            lblIndexA.AutoSize = true;
            lblIndexA.Font = new Font("Segoe UI", 10F);
            lblIndexA.Location = new Point(230, 42);
            lblIndexA.Name = "lblIndexA";
            lblIndexA.TabIndex = 3;
            lblIndexA.Text = "Индекс:";
            // 
            // txtIndexA
            // 
            txtIndexA.BackColor = Color.White;
            txtIndexA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtIndexA.Location = new Point(290, 39);
            txtIndexA.Name = "txtIndexA";
            txtIndexA.ReadOnly = true;
            txtIndexA.Size = new Size(105, 25);
            txtIndexA.TabIndex = 4;
            txtIndexA.TabStop = false;
            txtIndexA.TextAlign = HorizontalAlignment.Right;
            // 
            // panelB
            // 
            panelB.BackColor = Color.FromArgb(204, 228, 247);
            panelB.BorderStyle = BorderStyle.FixedSingle;
            panelB.Controls.Add(txtIndexB);
            panelB.Controls.Add(lblIndexB);
            panelB.Controls.Add(txtTimeB);
            panelB.Controls.Add(lblTimeB);
            panelB.Controls.Add(lblBHeader);
            panelB.Location = new Point(14, 170);
            panelB.Name = "panelB";
            panelB.Size = new Size(410, 78);
            panelB.TabIndex = 6;
            // 
            // lblBHeader
            // 
            lblBHeader.AutoSize = true;
            lblBHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblBHeader.Location = new Point(8, 6);
            lblBHeader.Name = "lblBHeader";
            lblBHeader.TabIndex = 0;
            lblBHeader.Text = "Оптимальный бинарный поиск";
            // 
            // lblTimeB
            // 
            lblTimeB.AutoSize = true;
            lblTimeB.Font = new Font("Segoe UI", 10F);
            lblTimeB.Location = new Point(10, 42);
            lblTimeB.Name = "lblTimeB";
            lblTimeB.TabIndex = 1;
            lblTimeB.Text = "Время, тики:";
            // 
            // txtTimeB
            // 
            txtTimeB.BackColor = Color.White;
            txtTimeB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimeB.Location = new Point(105, 39);
            txtTimeB.Name = "txtTimeB";
            txtTimeB.ReadOnly = true;
            txtTimeB.Size = new Size(110, 25);
            txtTimeB.TabIndex = 2;
            txtTimeB.TabStop = false;
            txtTimeB.TextAlign = HorizontalAlignment.Right;
            // 
            // lblIndexB
            // 
            lblIndexB.AutoSize = true;
            lblIndexB.Font = new Font("Segoe UI", 10F);
            lblIndexB.Location = new Point(230, 42);
            lblIndexB.Name = "lblIndexB";
            lblIndexB.TabIndex = 3;
            lblIndexB.Text = "Индекс:";
            // 
            // txtIndexB
            // 
            txtIndexB.BackColor = Color.White;
            txtIndexB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtIndexB.Location = new Point(290, 39);
            txtIndexB.Name = "txtIndexB";
            txtIndexB.ReadOnly = true;
            txtIndexB.Size = new Size(105, 25);
            txtIndexB.TabIndex = 4;
            txtIndexB.TabStop = false;
            txtIndexB.TextAlign = HorizontalAlignment.Right;
            // 
            // panelC
            // 
            panelC.BackColor = Color.FromArgb(204, 228, 247);
            panelC.BorderStyle = BorderStyle.FixedSingle;
            panelC.Controls.Add(txtIndexC);
            panelC.Controls.Add(lblIndexC);
            panelC.Controls.Add(txtTimeC);
            panelC.Controls.Add(lblTimeC);
            panelC.Controls.Add(lblCHeader);
            panelC.Location = new Point(14, 256);
            panelC.Name = "panelC";
            panelC.Size = new Size(410, 78);
            panelC.TabIndex = 7;
            // 
            // lblCHeader
            // 
            lblCHeader.AutoSize = true;
            lblCHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblCHeader.Location = new Point(8, 6);
            lblCHeader.Name = "lblCHeader";
            lblCHeader.TabIndex = 0;
            lblCHeader.Text = "Интерполяционный бинарный поиск";
            // 
            // lblTimeC
            // 
            lblTimeC.AutoSize = true;
            lblTimeC.Font = new Font("Segoe UI", 10F);
            lblTimeC.Location = new Point(10, 42);
            lblTimeC.Name = "lblTimeC";
            lblTimeC.TabIndex = 1;
            lblTimeC.Text = "Время, тики:";
            // 
            // txtTimeC
            // 
            txtTimeC.BackColor = Color.White;
            txtTimeC.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimeC.Location = new Point(105, 39);
            txtTimeC.Name = "txtTimeC";
            txtTimeC.ReadOnly = true;
            txtTimeC.Size = new Size(110, 25);
            txtTimeC.TabIndex = 2;
            txtTimeC.TabStop = false;
            txtTimeC.TextAlign = HorizontalAlignment.Right;
            // 
            // lblIndexC
            // 
            lblIndexC.AutoSize = true;
            lblIndexC.Font = new Font("Segoe UI", 10F);
            lblIndexC.Location = new Point(230, 42);
            lblIndexC.Name = "lblIndexC";
            lblIndexC.TabIndex = 3;
            lblIndexC.Text = "Индекс:";
            // 
            // txtIndexC
            // 
            txtIndexC.BackColor = Color.White;
            txtIndexC.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtIndexC.Location = new Point(290, 39);
            txtIndexC.Name = "txtIndexC";
            txtIndexC.ReadOnly = true;
            txtIndexC.Size = new Size(105, 25);
            txtIndexC.TabIndex = 4;
            txtIndexC.TabStop = false;
            txtIndexC.TextAlign = HorizontalAlignment.Right;
            // 
            // panelD
            // 
            panelD.BackColor = Color.FromArgb(204, 228, 247);
            panelD.BorderStyle = BorderStyle.FixedSingle;
            panelD.Controls.Add(txtIndexD);
            panelD.Controls.Add(lblIndexD);
            panelD.Controls.Add(txtTimeD);
            panelD.Controls.Add(lblTimeD);
            panelD.Controls.Add(lblDHeader);
            panelD.Location = new Point(434, 84);
            panelD.Name = "panelD";
            panelD.Size = new Size(410, 78);
            panelD.TabIndex = 8;
            // 
            // lblDHeader
            // 
            lblDHeader.AutoSize = true;
            lblDHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblDHeader.Location = new Point(8, 6);
            lblDHeader.Name = "lblDHeader";
            lblDHeader.TabIndex = 0;
            lblDHeader.Text = "\"Последовательный\" бинарный поиск";
            // 
            // lblTimeD
            // 
            lblTimeD.AutoSize = true;
            lblTimeD.Font = new Font("Segoe UI", 10F);
            lblTimeD.Location = new Point(10, 42);
            lblTimeD.Name = "lblTimeD";
            lblTimeD.TabIndex = 1;
            lblTimeD.Text = "Время, тики:";
            // 
            // txtTimeD
            // 
            txtTimeD.BackColor = Color.White;
            txtTimeD.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimeD.Location = new Point(105, 39);
            txtTimeD.Name = "txtTimeD";
            txtTimeD.ReadOnly = true;
            txtTimeD.Size = new Size(110, 25);
            txtTimeD.TabIndex = 2;
            txtTimeD.TabStop = false;
            txtTimeD.TextAlign = HorizontalAlignment.Right;
            // 
            // lblIndexD
            // 
            lblIndexD.AutoSize = true;
            lblIndexD.Font = new Font("Segoe UI", 10F);
            lblIndexD.Location = new Point(230, 42);
            lblIndexD.Name = "lblIndexD";
            lblIndexD.TabIndex = 3;
            lblIndexD.Text = "Индекс:";
            // 
            // txtIndexD
            // 
            txtIndexD.BackColor = Color.White;
            txtIndexD.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtIndexD.Location = new Point(290, 39);
            txtIndexD.Name = "txtIndexD";
            txtIndexD.ReadOnly = true;
            txtIndexD.Size = new Size(105, 25);
            txtIndexD.TabIndex = 4;
            txtIndexD.TabStop = false;
            txtIndexD.TextAlign = HorizontalAlignment.Right;
            // 
            // panelSeq
            // 
            panelSeq.BackColor = Color.FromArgb(204, 228, 247);
            panelSeq.BorderStyle = BorderStyle.FixedSingle;
            panelSeq.Controls.Add(lblSeqMeasured);
            panelSeq.Controls.Add(txtIndexSeq);
            panelSeq.Controls.Add(lblIndexSeq);
            panelSeq.Controls.Add(txtTimeSeq);
            panelSeq.Controls.Add(lblTimeSeq);
            panelSeq.Controls.Add(lblSeqHeader);
            panelSeq.Location = new Point(434, 170);
            panelSeq.Name = "panelSeq";
            panelSeq.Size = new Size(410, 106);
            panelSeq.TabIndex = 9;
            // 
            // lblSeqHeader
            // 
            lblSeqHeader.AutoSize = true;
            lblSeqHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSeqHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblSeqHeader.Location = new Point(8, 6);
            lblSeqHeader.Name = "lblSeqHeader";
            lblSeqHeader.TabIndex = 0;
            lblSeqHeader.Text = "Последовательный поиск в упорядоченном массиве";
            // 
            // lblTimeSeq
            // 
            lblTimeSeq.AutoSize = true;
            lblTimeSeq.Font = new Font("Segoe UI", 10F);
            lblTimeSeq.Location = new Point(10, 42);
            lblTimeSeq.Name = "lblTimeSeq";
            lblTimeSeq.TabIndex = 1;
            lblTimeSeq.Text = "Время, тики:";
            // 
            // txtTimeSeq
            // 
            txtTimeSeq.BackColor = Color.White;
            txtTimeSeq.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimeSeq.Location = new Point(105, 39);
            txtTimeSeq.Name = "txtTimeSeq";
            txtTimeSeq.ReadOnly = true;
            txtTimeSeq.Size = new Size(110, 25);
            txtTimeSeq.TabIndex = 2;
            txtTimeSeq.TabStop = false;
            txtTimeSeq.TextAlign = HorizontalAlignment.Right;
            // 
            // lblIndexSeq
            // 
            lblIndexSeq.AutoSize = true;
            lblIndexSeq.Font = new Font("Segoe UI", 10F);
            lblIndexSeq.Location = new Point(230, 42);
            lblIndexSeq.Name = "lblIndexSeq";
            lblIndexSeq.TabIndex = 3;
            lblIndexSeq.Text = "Индекс:";
            // 
            // txtIndexSeq
            // 
            txtIndexSeq.BackColor = Color.White;
            txtIndexSeq.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtIndexSeq.Location = new Point(290, 39);
            txtIndexSeq.Name = "txtIndexSeq";
            txtIndexSeq.ReadOnly = true;
            txtIndexSeq.Size = new Size(105, 25);
            txtIndexSeq.TabIndex = 4;
            txtIndexSeq.TabStop = false;
            txtIndexSeq.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSeqMeasured
            // 
            lblSeqMeasured.AutoSize = true;
            lblSeqMeasured.Font = new Font("Segoe UI", 9F);
            lblSeqMeasured.ForeColor = Color.DimGray;
            lblSeqMeasured.Location = new Point(10, 76);
            lblSeqMeasured.Name = "lblSeqMeasured";
            lblSeqMeasured.TabIndex = 5;
            lblSeqMeasured.Text = "";
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.FromArgb(204, 228, 247);
            panelSettings.BorderStyle = BorderStyle.FixedSingle;
            panelSettings.Controls.Add(lblStatus);
            panelSettings.Controls.Add(lblNote);
            panelSettings.Controls.Add(nudSeqRepeats);
            panelSettings.Controls.Add(lblSeqRepeats);
            panelSettings.Controls.Add(nudBinRepeats);
            panelSettings.Controls.Add(lblBinRepeats);
            panelSettings.Controls.Add(btnGenerate);
            panelSettings.Controls.Add(nudSize);
            panelSettings.Controls.Add(lblSize);
            panelSettings.Controls.Add(lblSettingsHeader);
            panelSettings.Location = new Point(20, 447);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(860, 156);
            panelSettings.TabIndex = 3;
            // 
            // lblSettingsHeader
            // 
            lblSettingsHeader.AutoSize = true;
            lblSettingsHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSettingsHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblSettingsHeader.Location = new Point(10, 8);
            lblSettingsHeader.Name = "lblSettingsHeader";
            lblSettingsHeader.TabIndex = 0;
            lblSettingsHeader.Text = "Параметры";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 10F);
            lblSize.Location = new Point(14, 46);
            lblSize.Name = "lblSize";
            lblSize.TabIndex = 1;
            lblSize.Text = "Размер массива:";
            // 
            // nudSize
            // 
            nudSize.Font = new Font("Segoe UI", 10F);
            nudSize.Increment = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSize.Location = new Point(135, 43);
            nudSize.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudSize.Minimum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(130, 25);
            nudSize.TabIndex = 2;
            nudSize.TextAlign = HorizontalAlignment.Right;
            nudSize.ThousandsSeparator = true;
            nudSize.Value = new decimal(new int[] { 50000000, 0, 0, 0 });
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(204, 228, 247);
            btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerate.Location = new Point(290, 40);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(210, 31);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Сгенерировать массив";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblBinRepeats
            // 
            lblBinRepeats.AutoSize = true;
            lblBinRepeats.Font = new Font("Segoe UI", 10F);
            lblBinRepeats.Location = new Point(14, 84);
            lblBinRepeats.Name = "lblBinRepeats";
            lblBinRepeats.TabIndex = 4;
            lblBinRepeats.Text = "Повторов бинарного поиска:";
            // 
            // nudBinRepeats
            // 
            nudBinRepeats.Font = new Font("Segoe UI", 10F);
            nudBinRepeats.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            nudBinRepeats.Location = new Point(210, 81);
            nudBinRepeats.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudBinRepeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudBinRepeats.Name = "nudBinRepeats";
            nudBinRepeats.Size = new Size(120, 25);
            nudBinRepeats.TabIndex = 5;
            nudBinRepeats.TextAlign = HorizontalAlignment.Right;
            nudBinRepeats.ThousandsSeparator = true;
            nudBinRepeats.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // lblSeqRepeats
            // 
            lblSeqRepeats.AutoSize = true;
            lblSeqRepeats.Font = new Font("Segoe UI", 10F);
            lblSeqRepeats.Location = new Point(350, 84);
            lblSeqRepeats.Name = "lblSeqRepeats";
            lblSeqRepeats.TabIndex = 6;
            lblSeqRepeats.Text = "Повторов последовательного поиска:";
            // 
            // nudSeqRepeats
            // 
            nudSeqRepeats.Font = new Font("Segoe UI", 10F);
            nudSeqRepeats.Location = new Point(600, 81);
            nudSeqRepeats.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudSeqRepeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSeqRepeats.Name = "nudSeqRepeats";
            nudSeqRepeats.Size = new Size(90, 25);
            nudSeqRepeats.TabIndex = 7;
            nudSeqRepeats.TextAlign = HorizontalAlignment.Right;
            nudSeqRepeats.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 9F);
            lblNote.ForeColor = Color.DimGray;
            lblNote.Location = new Point(14, 112);
            lblNote.Name = "lblNote";
            lblNote.TabIndex = 8;
            lblNote.Text = "Время последовательного поиска пересчитано: умножено на (повторов бинарного / повторов последовательного).";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.Location = new Point(14, 130);
            lblStatus.Name = "lblStatus";
            lblStatus.TabIndex = 9;
            lblStatus.Text = "";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(204, 228, 247);
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(720, 614);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 36);
            btnExit.TabIndex = 4;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnFind;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 244, 252);
            CancelButton = btnExit;
            ClientSize = new Size(900, 660);
            Controls.Add(btnExit);
            Controls.Add(panelSettings);
            Controls.Add(panelSearch);
            Controls.Add(lblTopic);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ЛР 3 - Мельников А.А., ИТз-441";
            Load += Form1_Load;
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelA.ResumeLayout(false);
            panelA.PerformLayout();
            panelB.ResumeLayout(false);
            panelB.PerformLayout();
            panelC.ResumeLayout(false);
            panelC.PerformLayout();
            panelD.ResumeLayout(false);
            panelD.PerformLayout();
            panelSeq.ResumeLayout(false);
            panelSeq.PerformLayout();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudKey).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBinRepeats).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSeqRepeats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTopic;
        private Panel panelSearch;
        private Label lblSearchHeader;
        private Label lblKey;
        private NumericUpDown nudKey;
        private Button btnRandom;
        private Button btnFind;
        private Panel panelA;
        private Label lblAHeader;
        private Label lblTimeA;
        private TextBox txtTimeA;
        private Label lblIndexA;
        private TextBox txtIndexA;
        private Panel panelB;
        private Label lblBHeader;
        private Label lblTimeB;
        private TextBox txtTimeB;
        private Label lblIndexB;
        private TextBox txtIndexB;
        private Panel panelC;
        private Label lblCHeader;
        private Label lblTimeC;
        private TextBox txtTimeC;
        private Label lblIndexC;
        private TextBox txtIndexC;
        private Panel panelD;
        private Label lblDHeader;
        private Label lblTimeD;
        private TextBox txtTimeD;
        private Label lblIndexD;
        private TextBox txtIndexD;
        private Panel panelSeq;
        private Label lblSeqHeader;
        private Label lblTimeSeq;
        private TextBox txtTimeSeq;
        private Label lblIndexSeq;
        private TextBox txtIndexSeq;
        private Label lblSeqMeasured;
        private Panel panelSettings;
        private Label lblSettingsHeader;
        private Label lblSize;
        private NumericUpDown nudSize;
        private Button btnGenerate;
        private Label lblBinRepeats;
        private NumericUpDown nudBinRepeats;
        private Label lblSeqRepeats;
        private NumericUpDown nudSeqRepeats;
        private Label lblNote;
        private Label lblStatus;
        private Button btnExit;
    }
}
