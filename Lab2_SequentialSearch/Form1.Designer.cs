namespace Lab2_SequentialSearch
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
            panelUnsorted = new Panel();
            lblUnsortedHeader = new Label();
            lblKeyU = new Label();
            nudKeyU = new NumericUpDown();
            btnRandomU = new Button();
            panelAU = new Panel();
            lblAUHeader = new Label();
            lblTimeAU = new Label();
            txtTimeAU = new TextBox();
            lblIndexAU = new Label();
            txtIndexAU = new TextBox();
            panelBU = new Panel();
            lblBUHeader = new Label();
            lblTimeBU = new Label();
            txtTimeBU = new TextBox();
            lblIndexBU = new Label();
            txtIndexBU = new TextBox();
            btnFindU = new Button();
            panelSorted = new Panel();
            lblSortedHeader = new Label();
            lblKeyS = new Label();
            nudKeyS = new NumericUpDown();
            btnRandomS = new Button();
            panelBS = new Panel();
            lblBSHeader = new Label();
            lblTimeBS = new Label();
            txtTimeBS = new TextBox();
            lblIndexBS = new Label();
            txtIndexBS = new TextBox();
            panelCS = new Panel();
            lblCSHeader = new Label();
            lblTimeCS = new Label();
            txtTimeCS = new TextBox();
            lblIndexCS = new Label();
            txtIndexCS = new TextBox();
            btnFindS = new Button();
            panelSettings = new Panel();
            lblSettingsHeader = new Label();
            lblSize = new Label();
            nudSize = new NumericUpDown();
            lblRepeats = new Label();
            nudRepeats = new NumericUpDown();
            btnGenerate = new Button();
            lblStatus = new Label();
            btnExit = new Button();
            panelUnsorted.SuspendLayout();
            panelAU.SuspendLayout();
            panelBU.SuspendLayout();
            panelSorted.SuspendLayout();
            panelBS.SuspendLayout();
            panelCS.SuspendLayout();
            panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudKeyU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKeyS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRepeats).BeginInit();
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
            lblTitle.Text = "Лабораторная работа № 2";
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.Font = new Font("Segoe UI", 11F);
            lblTopic.ForeColor = Color.FromArgb(0, 51, 102);
            lblTopic.Location = new Point(20, 48);
            lblTopic.Name = "lblTopic";
            lblTopic.TabIndex = 1;
            lblTopic.Text = "Последовательный поиск в неупорядоченном и упорядоченном массивах";
            // 
            // panelUnsorted
            // 
            panelUnsorted.BackColor = Color.FromArgb(204, 228, 247);
            panelUnsorted.BorderStyle = BorderStyle.FixedSingle;
            panelUnsorted.Controls.Add(btnFindU);
            panelUnsorted.Controls.Add(panelBU);
            panelUnsorted.Controls.Add(panelAU);
            panelUnsorted.Controls.Add(btnRandomU);
            panelUnsorted.Controls.Add(nudKeyU);
            panelUnsorted.Controls.Add(lblKeyU);
            panelUnsorted.Controls.Add(lblUnsortedHeader);
            panelUnsorted.Location = new Point(20, 85);
            panelUnsorted.Name = "panelUnsorted";
            panelUnsorted.Size = new Size(420, 302);
            panelUnsorted.TabIndex = 2;
            // 
            // lblUnsortedHeader
            // 
            lblUnsortedHeader.AutoSize = true;
            lblUnsortedHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUnsortedHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblUnsortedHeader.Location = new Point(10, 8);
            lblUnsortedHeader.Name = "lblUnsortedHeader";
            lblUnsortedHeader.TabIndex = 0;
            lblUnsortedHeader.Text = "Неупорядоченный массив";
            // 
            // lblKeyU
            // 
            lblKeyU.AutoSize = true;
            lblKeyU.Font = new Font("Segoe UI", 10F);
            lblKeyU.Location = new Point(14, 46);
            lblKeyU.Name = "lblKeyU";
            lblKeyU.TabIndex = 1;
            lblKeyU.Text = "Ключ:";
            // 
            // nudKeyU
            // 
            nudKeyU.Font = new Font("Segoe UI", 10F);
            nudKeyU.Location = new Point(70, 43);
            nudKeyU.Maximum = new decimal(new int[] { 2147483646, 0, 0, 0 });
            nudKeyU.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudKeyU.Name = "nudKeyU";
            nudKeyU.Size = new Size(150, 25);
            nudKeyU.TabIndex = 2;
            nudKeyU.TextAlign = HorizontalAlignment.Right;
            nudKeyU.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // btnRandomU
            // 
            btnRandomU.BackColor = Color.FromArgb(204, 228, 247);
            btnRandomU.Font = new Font("Segoe UI", 9F);
            btnRandomU.Location = new Point(232, 41);
            btnRandomU.Name = "btnRandomU";
            btnRandomU.Size = new Size(174, 29);
            btnRandomU.TabIndex = 3;
            btnRandomU.Text = "Случайный из массива";
            btnRandomU.UseVisualStyleBackColor = false;
            btnRandomU.Click += btnRandomU_Click;
            // 
            // panelAU
            // 
            panelAU.BackColor = Color.FromArgb(204, 228, 247);
            panelAU.BorderStyle = BorderStyle.FixedSingle;
            panelAU.Controls.Add(txtIndexAU);
            panelAU.Controls.Add(lblIndexAU);
            panelAU.Controls.Add(txtTimeAU);
            panelAU.Controls.Add(lblTimeAU);
            panelAU.Controls.Add(lblAUHeader);
            panelAU.Location = new Point(14, 82);
            panelAU.Name = "panelAU";
            panelAU.Size = new Size(392, 78);
            panelAU.TabIndex = 4;
            // 
            // lblAUHeader
            // 
            lblAUHeader.AutoSize = true;
            lblAUHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAUHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblAUHeader.Location = new Point(8, 6);
            lblAUHeader.Name = "lblAUHeader";
            lblAUHeader.TabIndex = 0;
            lblAUHeader.Text = "Неоптимальный поиск (A)";
            // 
            // lblTimeAU
            // 
            lblTimeAU.AutoSize = true;
            lblTimeAU.Font = new Font("Segoe UI", 10F);
            lblTimeAU.Location = new Point(10, 42);
            lblTimeAU.Name = "lblTimeAU";
            lblTimeAU.TabIndex = 1;
            lblTimeAU.Text = "Время, тики:";
            // 
            // txtTimeAU
            // 
            txtTimeAU.BackColor = Color.White;
            txtTimeAU.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimeAU.Location = new Point(105, 39);
            txtTimeAU.Name = "txtTimeAU";
            txtTimeAU.ReadOnly = true;
            txtTimeAU.Size = new Size(85, 25);
            txtTimeAU.TabIndex = 2;
            txtTimeAU.TabStop = false;
            txtTimeAU.TextAlign = HorizontalAlignment.Right;
            // 
            // lblIndexAU
            // 
            lblIndexAU.AutoSize = true;
            lblIndexAU.Font = new Font("Segoe UI", 10F);
            lblIndexAU.Location = new Point(205, 42);
            lblIndexAU.Name = "lblIndexAU";
            lblIndexAU.TabIndex = 3;
            lblIndexAU.Text = "Индекс:";
            // 
            // txtIndexAU
            // 
            txtIndexAU.BackColor = Color.White;
            txtIndexAU.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtIndexAU.Location = new Point(265, 39);
            txtIndexAU.Name = "txtIndexAU";
            txtIndexAU.ReadOnly = true;
            txtIndexAU.Size = new Size(113, 25);
            txtIndexAU.TabIndex = 4;
            txtIndexAU.TabStop = false;
            txtIndexAU.TextAlign = HorizontalAlignment.Right;
            // 
            // panelBU
            // 
            panelBU.BackColor = Color.FromArgb(204, 228, 247);
            panelBU.BorderStyle = BorderStyle.FixedSingle;
            panelBU.Controls.Add(txtIndexBU);
            panelBU.Controls.Add(lblIndexBU);
            panelBU.Controls.Add(txtTimeBU);
            panelBU.Controls.Add(lblTimeBU);
            panelBU.Controls.Add(lblBUHeader);
            panelBU.Location = new Point(14, 168);
            panelBU.Name = "panelBU";
            panelBU.Size = new Size(392, 78);
            panelBU.TabIndex = 5;
            // 
            // lblBUHeader
            // 
            lblBUHeader.AutoSize = true;
            lblBUHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBUHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblBUHeader.Location = new Point(8, 6);
            lblBUHeader.Name = "lblBUHeader";
            lblBUHeader.TabIndex = 0;
            lblBUHeader.Text = "Оптимальный поиск (B)";
            // 
            // lblTimeBU
            // 
            lblTimeBU.AutoSize = true;
            lblTimeBU.Font = new Font("Segoe UI", 10F);
            lblTimeBU.Location = new Point(10, 42);
            lblTimeBU.Name = "lblTimeBU";
            lblTimeBU.TabIndex = 1;
            lblTimeBU.Text = "Время, тики:";
            // 
            // txtTimeBU
            // 
            txtTimeBU.BackColor = Color.White;
            txtTimeBU.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimeBU.Location = new Point(105, 39);
            txtTimeBU.Name = "txtTimeBU";
            txtTimeBU.ReadOnly = true;
            txtTimeBU.Size = new Size(85, 25);
            txtTimeBU.TabIndex = 2;
            txtTimeBU.TabStop = false;
            txtTimeBU.TextAlign = HorizontalAlignment.Right;
            // 
            // lblIndexBU
            // 
            lblIndexBU.AutoSize = true;
            lblIndexBU.Font = new Font("Segoe UI", 10F);
            lblIndexBU.Location = new Point(205, 42);
            lblIndexBU.Name = "lblIndexBU";
            lblIndexBU.TabIndex = 3;
            lblIndexBU.Text = "Индекс:";
            // 
            // txtIndexBU
            // 
            txtIndexBU.BackColor = Color.White;
            txtIndexBU.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtIndexBU.Location = new Point(265, 39);
            txtIndexBU.Name = "txtIndexBU";
            txtIndexBU.ReadOnly = true;
            txtIndexBU.Size = new Size(113, 25);
            txtIndexBU.TabIndex = 4;
            txtIndexBU.TabStop = false;
            txtIndexBU.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFindU
            // 
            btnFindU.BackColor = Color.FromArgb(204, 228, 247);
            btnFindU.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFindU.Location = new Point(14, 256);
            btnFindU.Name = "btnFindU";
            btnFindU.Size = new Size(392, 34);
            btnFindU.TabIndex = 6;
            btnFindU.Text = "Найти";
            btnFindU.UseVisualStyleBackColor = false;
            btnFindU.Click += btnFindU_Click;
            // 
            // panelSorted
            // 
            panelSorted.BackColor = Color.FromArgb(204, 228, 247);
            panelSorted.BorderStyle = BorderStyle.FixedSingle;
            panelSorted.Controls.Add(btnFindS);
            panelSorted.Controls.Add(panelCS);
            panelSorted.Controls.Add(panelBS);
            panelSorted.Controls.Add(btnRandomS);
            panelSorted.Controls.Add(nudKeyS);
            panelSorted.Controls.Add(lblKeyS);
            panelSorted.Controls.Add(lblSortedHeader);
            panelSorted.Location = new Point(460, 85);
            panelSorted.Name = "panelSorted";
            panelSorted.Size = new Size(420, 302);
            panelSorted.TabIndex = 3;
            // 
            // lblSortedHeader
            // 
            lblSortedHeader.AutoSize = true;
            lblSortedHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSortedHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblSortedHeader.Location = new Point(10, 8);
            lblSortedHeader.Name = "lblSortedHeader";
            lblSortedHeader.TabIndex = 0;
            lblSortedHeader.Text = "Упорядоченный массив";
            // 
            // lblKeyS
            // 
            lblKeyS.AutoSize = true;
            lblKeyS.Font = new Font("Segoe UI", 10F);
            lblKeyS.Location = new Point(14, 46);
            lblKeyS.Name = "lblKeyS";
            lblKeyS.TabIndex = 1;
            lblKeyS.Text = "Ключ:";
            // 
            // nudKeyS
            // 
            nudKeyS.Font = new Font("Segoe UI", 10F);
            nudKeyS.Location = new Point(70, 43);
            nudKeyS.Maximum = new decimal(new int[] { 2147483646, 0, 0, 0 });
            nudKeyS.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudKeyS.Name = "nudKeyS";
            nudKeyS.Size = new Size(150, 25);
            nudKeyS.TabIndex = 2;
            nudKeyS.TextAlign = HorizontalAlignment.Right;
            nudKeyS.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // btnRandomS
            // 
            btnRandomS.BackColor = Color.FromArgb(204, 228, 247);
            btnRandomS.Font = new Font("Segoe UI", 9F);
            btnRandomS.Location = new Point(232, 41);
            btnRandomS.Name = "btnRandomS";
            btnRandomS.Size = new Size(174, 29);
            btnRandomS.TabIndex = 3;
            btnRandomS.Text = "Случайный из массива";
            btnRandomS.UseVisualStyleBackColor = false;
            btnRandomS.Click += btnRandomS_Click;
            // 
            // panelBS
            // 
            panelBS.BackColor = Color.FromArgb(204, 228, 247);
            panelBS.BorderStyle = BorderStyle.FixedSingle;
            panelBS.Controls.Add(txtIndexBS);
            panelBS.Controls.Add(lblIndexBS);
            panelBS.Controls.Add(txtTimeBS);
            panelBS.Controls.Add(lblTimeBS);
            panelBS.Controls.Add(lblBSHeader);
            panelBS.Location = new Point(14, 82);
            panelBS.Name = "panelBS";
            panelBS.Size = new Size(392, 78);
            panelBS.TabIndex = 4;
            // 
            // lblBSHeader
            // 
            lblBSHeader.AutoSize = true;
            lblBSHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBSHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblBSHeader.Location = new Point(8, 6);
            lblBSHeader.Name = "lblBSHeader";
            lblBSHeader.TabIndex = 0;
            lblBSHeader.Text = "Как в неупорядоченном (B)";
            // 
            // lblTimeBS
            // 
            lblTimeBS.AutoSize = true;
            lblTimeBS.Font = new Font("Segoe UI", 10F);
            lblTimeBS.Location = new Point(10, 42);
            lblTimeBS.Name = "lblTimeBS";
            lblTimeBS.TabIndex = 1;
            lblTimeBS.Text = "Время, тики:";
            // 
            // txtTimeBS
            // 
            txtTimeBS.BackColor = Color.White;
            txtTimeBS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimeBS.Location = new Point(105, 39);
            txtTimeBS.Name = "txtTimeBS";
            txtTimeBS.ReadOnly = true;
            txtTimeBS.Size = new Size(85, 25);
            txtTimeBS.TabIndex = 2;
            txtTimeBS.TabStop = false;
            txtTimeBS.TextAlign = HorizontalAlignment.Right;
            // 
            // lblIndexBS
            // 
            lblIndexBS.AutoSize = true;
            lblIndexBS.Font = new Font("Segoe UI", 10F);
            lblIndexBS.Location = new Point(205, 42);
            lblIndexBS.Name = "lblIndexBS";
            lblIndexBS.TabIndex = 3;
            lblIndexBS.Text = "Индекс:";
            // 
            // txtIndexBS
            // 
            txtIndexBS.BackColor = Color.White;
            txtIndexBS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtIndexBS.Location = new Point(265, 39);
            txtIndexBS.Name = "txtIndexBS";
            txtIndexBS.ReadOnly = true;
            txtIndexBS.Size = new Size(113, 25);
            txtIndexBS.TabIndex = 4;
            txtIndexBS.TabStop = false;
            txtIndexBS.TextAlign = HorizontalAlignment.Right;
            // 
            // panelCS
            // 
            panelCS.BackColor = Color.FromArgb(204, 228, 247);
            panelCS.BorderStyle = BorderStyle.FixedSingle;
            panelCS.Controls.Add(txtIndexCS);
            panelCS.Controls.Add(lblIndexCS);
            panelCS.Controls.Add(txtTimeCS);
            panelCS.Controls.Add(lblTimeCS);
            panelCS.Controls.Add(lblCSHeader);
            panelCS.Location = new Point(14, 168);
            panelCS.Name = "panelCS";
            panelCS.Size = new Size(392, 78);
            panelCS.TabIndex = 5;
            // 
            // lblCSHeader
            // 
            lblCSHeader.AutoSize = true;
            lblCSHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCSHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblCSHeader.Location = new Point(8, 6);
            lblCSHeader.Name = "lblCSHeader";
            lblCSHeader.TabIndex = 0;
            lblCSHeader.Text = "Как в упорядоченном (C)";
            // 
            // lblTimeCS
            // 
            lblTimeCS.AutoSize = true;
            lblTimeCS.Font = new Font("Segoe UI", 10F);
            lblTimeCS.Location = new Point(10, 42);
            lblTimeCS.Name = "lblTimeCS";
            lblTimeCS.TabIndex = 1;
            lblTimeCS.Text = "Время, тики:";
            // 
            // txtTimeCS
            // 
            txtTimeCS.BackColor = Color.White;
            txtTimeCS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimeCS.Location = new Point(105, 39);
            txtTimeCS.Name = "txtTimeCS";
            txtTimeCS.ReadOnly = true;
            txtTimeCS.Size = new Size(85, 25);
            txtTimeCS.TabIndex = 2;
            txtTimeCS.TabStop = false;
            txtTimeCS.TextAlign = HorizontalAlignment.Right;
            // 
            // lblIndexCS
            // 
            lblIndexCS.AutoSize = true;
            lblIndexCS.Font = new Font("Segoe UI", 10F);
            lblIndexCS.Location = new Point(205, 42);
            lblIndexCS.Name = "lblIndexCS";
            lblIndexCS.TabIndex = 3;
            lblIndexCS.Text = "Индекс:";
            // 
            // txtIndexCS
            // 
            txtIndexCS.BackColor = Color.White;
            txtIndexCS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtIndexCS.Location = new Point(265, 39);
            txtIndexCS.Name = "txtIndexCS";
            txtIndexCS.ReadOnly = true;
            txtIndexCS.Size = new Size(113, 25);
            txtIndexCS.TabIndex = 4;
            txtIndexCS.TabStop = false;
            txtIndexCS.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFindS
            // 
            btnFindS.BackColor = Color.FromArgb(204, 228, 247);
            btnFindS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFindS.Location = new Point(14, 256);
            btnFindS.Name = "btnFindS";
            btnFindS.Size = new Size(392, 34);
            btnFindS.TabIndex = 6;
            btnFindS.Text = "Найти";
            btnFindS.UseVisualStyleBackColor = false;
            btnFindS.Click += btnFindS_Click;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.FromArgb(204, 228, 247);
            panelSettings.BorderStyle = BorderStyle.FixedSingle;
            panelSettings.Controls.Add(lblStatus);
            panelSettings.Controls.Add(btnGenerate);
            panelSettings.Controls.Add(nudRepeats);
            panelSettings.Controls.Add(lblRepeats);
            panelSettings.Controls.Add(nudSize);
            panelSettings.Controls.Add(lblSize);
            panelSettings.Controls.Add(lblSettingsHeader);
            panelSettings.Location = new Point(20, 400);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(860, 100);
            panelSettings.TabIndex = 4;
            // 
            // lblSettingsHeader
            // 
            lblSettingsHeader.AutoSize = true;
            lblSettingsHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSettingsHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblSettingsHeader.Location = new Point(10, 8);
            lblSettingsHeader.Name = "lblSettingsHeader";
            lblSettingsHeader.TabIndex = 0;
            lblSettingsHeader.Text = "Параметры массивов";
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
            nudSize.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            nudSize.Minimum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(130, 25);
            nudSize.TabIndex = 2;
            nudSize.TextAlign = HorizontalAlignment.Right;
            nudSize.ThousandsSeparator = true;
            nudSize.Value = new decimal(new int[] { 10000000, 0, 0, 0 });
            // 
            // lblRepeats
            // 
            lblRepeats.AutoSize = true;
            lblRepeats.Font = new Font("Segoe UI", 10F);
            lblRepeats.Location = new Point(285, 46);
            lblRepeats.Name = "lblRepeats";
            lblRepeats.TabIndex = 3;
            lblRepeats.Text = "Повторов поиска:";
            // 
            // nudRepeats
            // 
            nudRepeats.Font = new Font("Segoe UI", 10F);
            nudRepeats.Location = new Point(410, 43);
            nudRepeats.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudRepeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRepeats.Name = "nudRepeats";
            nudRepeats.Size = new Size(90, 25);
            nudRepeats.TabIndex = 4;
            nudRepeats.TextAlign = HorizontalAlignment.Right;
            nudRepeats.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(204, 228, 247);
            btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerate.Location = new Point(520, 40);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(210, 31);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Сгенерировать массивы";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.Location = new Point(14, 74);
            lblStatus.Name = "lblStatus";
            lblStatus.TabIndex = 6;
            lblStatus.Text = "";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(204, 228, 247);
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(720, 512);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 36);
            btnExit.TabIndex = 5;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 244, 252);
            CancelButton = btnExit;
            ClientSize = new Size(900, 560);
            Controls.Add(btnExit);
            Controls.Add(panelSettings);
            Controls.Add(panelSorted);
            Controls.Add(panelUnsorted);
            Controls.Add(lblTopic);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ЛР 2 - Мельников А.А., ИТз-441";
            Load += Form1_Load;
            panelUnsorted.ResumeLayout(false);
            panelUnsorted.PerformLayout();
            panelAU.ResumeLayout(false);
            panelAU.PerformLayout();
            panelBU.ResumeLayout(false);
            panelBU.PerformLayout();
            panelSorted.ResumeLayout(false);
            panelSorted.PerformLayout();
            panelBS.ResumeLayout(false);
            panelBS.PerformLayout();
            panelCS.ResumeLayout(false);
            panelCS.PerformLayout();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudKeyU).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKeyS).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRepeats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTopic;
        private Panel panelUnsorted;
        private Label lblUnsortedHeader;
        private Label lblKeyU;
        private NumericUpDown nudKeyU;
        private Button btnRandomU;
        private Panel panelAU;
        private Label lblAUHeader;
        private Label lblTimeAU;
        private TextBox txtTimeAU;
        private Label lblIndexAU;
        private TextBox txtIndexAU;
        private Panel panelBU;
        private Label lblBUHeader;
        private Label lblTimeBU;
        private TextBox txtTimeBU;
        private Label lblIndexBU;
        private TextBox txtIndexBU;
        private Button btnFindU;
        private Panel panelSorted;
        private Label lblSortedHeader;
        private Label lblKeyS;
        private NumericUpDown nudKeyS;
        private Button btnRandomS;
        private Panel panelBS;
        private Label lblBSHeader;
        private Label lblTimeBS;
        private TextBox txtTimeBS;
        private Label lblIndexBS;
        private TextBox txtIndexBS;
        private Panel panelCS;
        private Label lblCSHeader;
        private Label lblTimeCS;
        private TextBox txtTimeCS;
        private Label lblIndexCS;
        private TextBox txtIndexCS;
        private Button btnFindS;
        private Panel panelSettings;
        private Label lblSettingsHeader;
        private Label lblSize;
        private NumericUpDown nudSize;
        private Label lblRepeats;
        private NumericUpDown nudRepeats;
        private Button btnGenerate;
        private Label lblStatus;
        private Button btnExit;
    }
}
