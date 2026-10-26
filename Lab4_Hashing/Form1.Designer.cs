namespace Lab4_Hashing
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
            panelTest = new Panel();
            lblTestHeader = new Label();
            lblTestDivision = new Label();
            txtTestDivision = new TextBox();
            lblTestMidSquare = new Label();
            txtTestMidSquare = new TextBox();
            lblTestFolding = new Label();
            txtTestFolding = new TextBox();
            lblTestMultiplication = new Label();
            txtTestMultiplication = new TextBox();
            btnTest = new Button();
            lblTestNote = new Label();
            panelFunctions = new Panel();
            lblFunctionsHeader = new Label();
            lblIterations = new Label();
            nudIterations = new NumericUpDown();
            btnRun = new Button();
            lblFunctionsNote = new Label();
            lblWinsDivision = new Label();
            txtWinsDivision = new TextBox();
            lblWinsMidSquare = new Label();
            txtWinsMidSquare = new TextBox();
            lblWinsFolding = new Label();
            txtWinsFolding = new TextBox();
            lblWinsMultiplication = new Label();
            txtWinsMultiplication = new TextBox();
            panelMethods = new Panel();
            lblMethodsHeader = new Label();
            lblHashFunction = new Label();
            cmbHashFunction = new ComboBox();
            lblRepeats = new Label();
            nudRepeats = new NumericUpDown();
            btnCompare = new Button();
            panelOA = new Panel();
            lblOAHeader = new Label();
            lblTimeOA = new Label();
            txtTimeOA = new TextBox();
            lblComparisonsOA = new Label();
            txtComparisonsOA = new TextBox();
            lblFoundOA = new Label();
            txtFoundOA = new TextBox();
            panelCh = new Panel();
            lblChHeader = new Label();
            lblTimeCh = new Label();
            txtTimeCh = new TextBox();
            lblComparisonsCh = new Label();
            txtComparisonsCh = new TextBox();
            lblFoundCh = new Label();
            txtFoundCh = new TextBox();
            lblMethodsInfo = new Label();
            btnExit = new Button();
            panelTest.SuspendLayout();
            panelFunctions.SuspendLayout();
            panelMethods.SuspendLayout();
            panelOA.SuspendLayout();
            panelCh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIterations).BeginInit();
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
            lblTitle.Text = "Лабораторная работа № 4";
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.Font = new Font("Segoe UI", 11F);
            lblTopic.ForeColor = Color.FromArgb(0, 51, 102);
            lblTopic.Location = new Point(20, 48);
            lblTopic.Name = "lblTopic";
            lblTopic.TabIndex = 1;
            lblTopic.Text = "Поиск методом хеширования";
            // 
            // panelTest
            // 
            panelTest.BackColor = Color.FromArgb(204, 228, 247);
            panelTest.BorderStyle = BorderStyle.FixedSingle;
            panelTest.Controls.Add(lblTestNote);
            panelTest.Controls.Add(btnTest);
            panelTest.Controls.Add(txtTestMultiplication);
            panelTest.Controls.Add(lblTestMultiplication);
            panelTest.Controls.Add(txtTestFolding);
            panelTest.Controls.Add(lblTestFolding);
            panelTest.Controls.Add(txtTestMidSquare);
            panelTest.Controls.Add(lblTestMidSquare);
            panelTest.Controls.Add(txtTestDivision);
            panelTest.Controls.Add(lblTestDivision);
            panelTest.Controls.Add(lblTestHeader);
            panelTest.Location = new Point(20, 85);
            panelTest.Name = "panelTest";
            panelTest.Size = new Size(860, 102);
            panelTest.TabIndex = 2;
            // 
            // lblTestHeader
            // 
            lblTestHeader.AutoSize = true;
            lblTestHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTestHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblTestHeader.Location = new Point(10, 8);
            lblTestHeader.Name = "lblTestHeader";
            lblTestHeader.TabIndex = 0;
            lblTestHeader.Text = "Тест хеш-функций (K = 45678)";
            // 
            // lblTestDivision
            // 
            lblTestDivision.AutoSize = true;
            lblTestDivision.Font = new Font("Segoe UI", 10F);
            lblTestDivision.Location = new Point(14, 46);
            lblTestDivision.Name = "lblTestDivision";
            lblTestDivision.TabIndex = 1;
            lblTestDivision.Text = "Деление:";
            // 
            // txtTestDivision
            // 
            txtTestDivision.BackColor = Color.White;
            txtTestDivision.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTestDivision.Location = new Point(85, 43);
            txtTestDivision.Name = "txtTestDivision";
            txtTestDivision.ReadOnly = true;
            txtTestDivision.Size = new Size(60, 25);
            txtTestDivision.TabIndex = 2;
            txtTestDivision.TabStop = false;
            txtTestDivision.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTestMidSquare
            // 
            lblTestMidSquare.AutoSize = true;
            lblTestMidSquare.Font = new Font("Segoe UI", 10F);
            lblTestMidSquare.Location = new Point(165, 46);
            lblTestMidSquare.Name = "lblTestMidSquare";
            lblTestMidSquare.TabIndex = 3;
            lblTestMidSquare.Text = "Середина квадрата:";
            // 
            // txtTestMidSquare
            // 
            txtTestMidSquare.BackColor = Color.White;
            txtTestMidSquare.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTestMidSquare.Location = new Point(300, 43);
            txtTestMidSquare.Name = "txtTestMidSquare";
            txtTestMidSquare.ReadOnly = true;
            txtTestMidSquare.Size = new Size(60, 25);
            txtTestMidSquare.TabIndex = 4;
            txtTestMidSquare.TabStop = false;
            txtTestMidSquare.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTestFolding
            // 
            lblTestFolding.AutoSize = true;
            lblTestFolding.Font = new Font("Segoe UI", 10F);
            lblTestFolding.Location = new Point(380, 46);
            lblTestFolding.Name = "lblTestFolding";
            lblTestFolding.TabIndex = 5;
            lblTestFolding.Text = "Свертывание:";
            // 
            // txtTestFolding
            // 
            txtTestFolding.BackColor = Color.White;
            txtTestFolding.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTestFolding.Location = new Point(475, 43);
            txtTestFolding.Name = "txtTestFolding";
            txtTestFolding.ReadOnly = true;
            txtTestFolding.Size = new Size(60, 25);
            txtTestFolding.TabIndex = 6;
            txtTestFolding.TabStop = false;
            txtTestFolding.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTestMultiplication
            // 
            lblTestMultiplication.AutoSize = true;
            lblTestMultiplication.Font = new Font("Segoe UI", 10F);
            lblTestMultiplication.Location = new Point(555, 46);
            lblTestMultiplication.Name = "lblTestMultiplication";
            lblTestMultiplication.TabIndex = 7;
            lblTestMultiplication.Text = "Умножение:";
            // 
            // txtTestMultiplication
            // 
            txtTestMultiplication.BackColor = Color.White;
            txtTestMultiplication.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTestMultiplication.Location = new Point(640, 43);
            txtTestMultiplication.Name = "txtTestMultiplication";
            txtTestMultiplication.ReadOnly = true;
            txtTestMultiplication.Size = new Size(60, 25);
            txtTestMultiplication.TabIndex = 8;
            txtTestMultiplication.TabStop = false;
            txtTestMultiplication.TextAlign = HorizontalAlignment.Right;
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.FromArgb(204, 228, 247);
            btnTest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTest.Location = new Point(724, 40);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(120, 31);
            btnTest.TabIndex = 9;
            btnTest.Text = "Тест";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // lblTestNote
            // 
            lblTestNote.AutoSize = true;
            lblTestNote.Font = new Font("Segoe UI", 9F);
            lblTestNote.ForeColor = Color.DimGray;
            lblTestNote.Location = new Point(14, 76);
            lblTestNote.Name = "lblTestNote";
            lblTestNote.TabIndex = 10;
            lblTestNote.Text = "Ожидается: 813, 479, 723, 556. Эта область не участвует в остальных расчетах.";
            // 
            // panelFunctions
            // 
            panelFunctions.BackColor = Color.FromArgb(204, 228, 247);
            panelFunctions.BorderStyle = BorderStyle.FixedSingle;
            panelFunctions.Controls.Add(txtWinsMultiplication);
            panelFunctions.Controls.Add(lblWinsMultiplication);
            panelFunctions.Controls.Add(txtWinsFolding);
            panelFunctions.Controls.Add(lblWinsFolding);
            panelFunctions.Controls.Add(txtWinsMidSquare);
            panelFunctions.Controls.Add(lblWinsMidSquare);
            panelFunctions.Controls.Add(txtWinsDivision);
            panelFunctions.Controls.Add(lblWinsDivision);
            panelFunctions.Controls.Add(lblFunctionsNote);
            panelFunctions.Controls.Add(btnRun);
            panelFunctions.Controls.Add(nudIterations);
            panelFunctions.Controls.Add(lblIterations);
            panelFunctions.Controls.Add(lblFunctionsHeader);
            panelFunctions.Location = new Point(20, 199);
            panelFunctions.Name = "panelFunctions";
            panelFunctions.Size = new Size(860, 156);
            panelFunctions.TabIndex = 3;
            // 
            // lblFunctionsHeader
            // 
            lblFunctionsHeader.AutoSize = true;
            lblFunctionsHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFunctionsHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblFunctionsHeader.Location = new Point(10, 8);
            lblFunctionsHeader.Name = "lblFunctionsHeader";
            lblFunctionsHeader.TabIndex = 0;
            lblFunctionsHeader.Text = "Сравнение функций хеширования";
            // 
            // lblIterations
            // 
            lblIterations.AutoSize = true;
            lblIterations.Font = new Font("Segoe UI", 10F);
            lblIterations.Location = new Point(14, 46);
            lblIterations.Name = "lblIterations";
            lblIterations.TabIndex = 1;
            lblIterations.Text = "Количество сравнений:";
            // 
            // nudIterations
            // 
            nudIterations.Font = new Font("Segoe UI", 10F);
            nudIterations.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudIterations.Location = new Point(175, 43);
            nudIterations.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudIterations.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudIterations.Name = "nudIterations";
            nudIterations.Size = new Size(100, 25);
            nudIterations.TabIndex = 2;
            nudIterations.TextAlign = HorizontalAlignment.Right;
            nudIterations.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.FromArgb(204, 228, 247);
            btnRun.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRun.Location = new Point(295, 40);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(160, 31);
            btnRun.TabIndex = 3;
            btnRun.Text = "Выполнить";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // lblFunctionsNote
            // 
            lblFunctionsNote.AutoSize = true;
            lblFunctionsNote.Font = new Font("Segoe UI", 9F);
            lblFunctionsNote.ForeColor = Color.DimGray;
            lblFunctionsNote.Location = new Point(470, 48);
            lblFunctionsNote.Name = "lblFunctionsNote";
            lblFunctionsNote.TabIndex = 4;
            lblFunctionsNote.Text = "t - сколько раз функция дала минимум коллизий (метод цепочек)";
            // 
            // lblWinsDivision
            // 
            lblWinsDivision.AutoSize = true;
            lblWinsDivision.Font = new Font("Segoe UI", 10F);
            lblWinsDivision.Location = new Point(14, 88);
            lblWinsDivision.Name = "lblWinsDivision";
            lblWinsDivision.TabIndex = 5;
            lblWinsDivision.Text = "Метод деления:";
            // 
            // txtWinsDivision
            // 
            txtWinsDivision.BackColor = Color.White;
            txtWinsDivision.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtWinsDivision.Location = new Point(215, 85);
            txtWinsDivision.Name = "txtWinsDivision";
            txtWinsDivision.ReadOnly = true;
            txtWinsDivision.Size = new Size(90, 25);
            txtWinsDivision.TabIndex = 6;
            txtWinsDivision.TabStop = false;
            txtWinsDivision.TextAlign = HorizontalAlignment.Right;
            // 
            // lblWinsMidSquare
            // 
            lblWinsMidSquare.AutoSize = true;
            lblWinsMidSquare.Font = new Font("Segoe UI", 10F);
            lblWinsMidSquare.Location = new Point(440, 88);
            lblWinsMidSquare.Name = "lblWinsMidSquare";
            lblWinsMidSquare.TabIndex = 7;
            lblWinsMidSquare.Text = "Метод середины квадрата:";
            // 
            // txtWinsMidSquare
            // 
            txtWinsMidSquare.BackColor = Color.White;
            txtWinsMidSquare.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtWinsMidSquare.Location = new Point(640, 85);
            txtWinsMidSquare.Name = "txtWinsMidSquare";
            txtWinsMidSquare.ReadOnly = true;
            txtWinsMidSquare.Size = new Size(90, 25);
            txtWinsMidSquare.TabIndex = 8;
            txtWinsMidSquare.TabStop = false;
            txtWinsMidSquare.TextAlign = HorizontalAlignment.Right;
            // 
            // lblWinsFolding
            // 
            lblWinsFolding.AutoSize = true;
            lblWinsFolding.Font = new Font("Segoe UI", 10F);
            lblWinsFolding.Location = new Point(14, 120);
            lblWinsFolding.Name = "lblWinsFolding";
            lblWinsFolding.TabIndex = 9;
            lblWinsFolding.Text = "Метод свертывания:";
            // 
            // txtWinsFolding
            // 
            txtWinsFolding.BackColor = Color.White;
            txtWinsFolding.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtWinsFolding.Location = new Point(215, 117);
            txtWinsFolding.Name = "txtWinsFolding";
            txtWinsFolding.ReadOnly = true;
            txtWinsFolding.Size = new Size(90, 25);
            txtWinsFolding.TabIndex = 10;
            txtWinsFolding.TabStop = false;
            txtWinsFolding.TextAlign = HorizontalAlignment.Right;
            // 
            // lblWinsMultiplication
            // 
            lblWinsMultiplication.AutoSize = true;
            lblWinsMultiplication.Font = new Font("Segoe UI", 10F);
            lblWinsMultiplication.Location = new Point(440, 120);
            lblWinsMultiplication.Name = "lblWinsMultiplication";
            lblWinsMultiplication.TabIndex = 11;
            lblWinsMultiplication.Text = "Метод умножения:";
            // 
            // txtWinsMultiplication
            // 
            txtWinsMultiplication.BackColor = Color.White;
            txtWinsMultiplication.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtWinsMultiplication.Location = new Point(640, 117);
            txtWinsMultiplication.Name = "txtWinsMultiplication";
            txtWinsMultiplication.ReadOnly = true;
            txtWinsMultiplication.Size = new Size(90, 25);
            txtWinsMultiplication.TabIndex = 12;
            txtWinsMultiplication.TabStop = false;
            txtWinsMultiplication.TextAlign = HorizontalAlignment.Right;
            // 
            // panelMethods
            // 
            panelMethods.BackColor = Color.FromArgb(204, 228, 247);
            panelMethods.BorderStyle = BorderStyle.FixedSingle;
            panelMethods.Controls.Add(lblMethodsInfo);
            panelMethods.Controls.Add(panelCh);
            panelMethods.Controls.Add(panelOA);
            panelMethods.Controls.Add(btnCompare);
            panelMethods.Controls.Add(nudRepeats);
            panelMethods.Controls.Add(lblRepeats);
            panelMethods.Controls.Add(cmbHashFunction);
            panelMethods.Controls.Add(lblHashFunction);
            panelMethods.Controls.Add(lblMethodsHeader);
            panelMethods.Location = new Point(20, 367);
            panelMethods.Name = "panelMethods";
            panelMethods.Size = new Size(860, 270);
            panelMethods.TabIndex = 4;
            // 
            // lblMethodsHeader
            // 
            lblMethodsHeader.AutoSize = true;
            lblMethodsHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMethodsHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblMethodsHeader.Location = new Point(10, 8);
            lblMethodsHeader.Name = "lblMethodsHeader";
            lblMethodsHeader.TabIndex = 0;
            lblMethodsHeader.Text = "Сравнение методов разрешения коллизий";
            // 
            // lblHashFunction
            // 
            lblHashFunction.AutoSize = true;
            lblHashFunction.Font = new Font("Segoe UI", 10F);
            lblHashFunction.Location = new Point(14, 46);
            lblHashFunction.Name = "lblHashFunction";
            lblHashFunction.TabIndex = 1;
            lblHashFunction.Text = "Хеш-функция для сравнения методов:";
            // 
            // cmbHashFunction
            // 
            cmbHashFunction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHashFunction.Font = new Font("Segoe UI", 10F);
            cmbHashFunction.FormattingEnabled = true;
            cmbHashFunction.Items.AddRange(new object[] { "Метод деления", "Метод середины квадрата", "Метод свертывания", "Метод умножения" });
            cmbHashFunction.Location = new Point(268, 43);
            cmbHashFunction.Name = "cmbHashFunction";
            cmbHashFunction.Size = new Size(220, 25);
            cmbHashFunction.TabIndex = 2;
            // 
            // lblRepeats
            // 
            lblRepeats.AutoSize = true;
            lblRepeats.Font = new Font("Segoe UI", 10F);
            lblRepeats.Location = new Point(505, 46);
            lblRepeats.Name = "lblRepeats";
            lblRepeats.TabIndex = 3;
            lblRepeats.Text = "Повторов:";
            // 
            // nudRepeats
            // 
            nudRepeats.Font = new Font("Segoe UI", 10F);
            nudRepeats.Location = new Point(580, 43);
            nudRepeats.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudRepeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRepeats.Name = "nudRepeats";
            nudRepeats.Size = new Size(90, 25);
            nudRepeats.TabIndex = 4;
            nudRepeats.TextAlign = HorizontalAlignment.Right;
            nudRepeats.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btnCompare
            // 
            btnCompare.BackColor = Color.FromArgb(204, 228, 247);
            btnCompare.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCompare.Location = new Point(690, 40);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(154, 31);
            btnCompare.TabIndex = 5;
            btnCompare.Text = "Сравнить";
            btnCompare.UseVisualStyleBackColor = false;
            btnCompare.Click += btnCompare_Click;
            // 
            // panelOA
            // 
            panelOA.BackColor = Color.FromArgb(204, 228, 247);
            panelOA.BorderStyle = BorderStyle.FixedSingle;
            panelOA.Controls.Add(txtFoundOA);
            panelOA.Controls.Add(lblFoundOA);
            panelOA.Controls.Add(txtComparisonsOA);
            panelOA.Controls.Add(lblComparisonsOA);
            panelOA.Controls.Add(txtTimeOA);
            panelOA.Controls.Add(lblTimeOA);
            panelOA.Controls.Add(lblOAHeader);
            panelOA.Location = new Point(14, 84);
            panelOA.Name = "panelOA";
            panelOA.Size = new Size(410, 150);
            panelOA.TabIndex = 6;
            // 
            // lblOAHeader
            // 
            lblOAHeader.AutoSize = true;
            lblOAHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOAHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblOAHeader.Location = new Point(8, 6);
            lblOAHeader.Name = "lblOAHeader";
            lblOAHeader.TabIndex = 0;
            lblOAHeader.Text = "Метод открытой адресации";
            // 
            // lblTimeOA
            // 
            lblTimeOA.AutoSize = true;
            lblTimeOA.Font = new Font("Segoe UI", 10F);
            lblTimeOA.Location = new Point(10, 42);
            lblTimeOA.Name = "lblTimeOA";
            lblTimeOA.TabIndex = 1;
            lblTimeOA.Text = "Время, тики:";
            // 
            // txtTimeOA
            // 
            txtTimeOA.BackColor = Color.White;
            txtTimeOA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimeOA.Location = new Point(230, 39);
            txtTimeOA.Name = "txtTimeOA";
            txtTimeOA.ReadOnly = true;
            txtTimeOA.Size = new Size(165, 25);
            txtTimeOA.TabIndex = 2;
            txtTimeOA.TabStop = false;
            txtTimeOA.TextAlign = HorizontalAlignment.Right;
            // 
            // lblComparisonsOA
            // 
            lblComparisonsOA.AutoSize = true;
            lblComparisonsOA.Font = new Font("Segoe UI", 10F);
            lblComparisonsOA.Location = new Point(10, 74);
            lblComparisonsOA.Name = "lblComparisonsOA";
            lblComparisonsOA.TabIndex = 3;
            lblComparisonsOA.Text = "Среднее число сравнений:";
            // 
            // txtComparisonsOA
            // 
            txtComparisonsOA.BackColor = Color.White;
            txtComparisonsOA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtComparisonsOA.Location = new Point(230, 71);
            txtComparisonsOA.Name = "txtComparisonsOA";
            txtComparisonsOA.ReadOnly = true;
            txtComparisonsOA.Size = new Size(165, 25);
            txtComparisonsOA.TabIndex = 4;
            txtComparisonsOA.TabStop = false;
            txtComparisonsOA.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFoundOA
            // 
            lblFoundOA.AutoSize = true;
            lblFoundOA.Font = new Font("Segoe UI", 10F);
            lblFoundOA.Location = new Point(10, 106);
            lblFoundOA.Name = "lblFoundOA";
            lblFoundOA.TabIndex = 5;
            lblFoundOA.Text = "Найдено ключей:";
            // 
            // txtFoundOA
            // 
            txtFoundOA.BackColor = Color.White;
            txtFoundOA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtFoundOA.Location = new Point(230, 103);
            txtFoundOA.Name = "txtFoundOA";
            txtFoundOA.ReadOnly = true;
            txtFoundOA.Size = new Size(165, 25);
            txtFoundOA.TabIndex = 6;
            txtFoundOA.TabStop = false;
            txtFoundOA.TextAlign = HorizontalAlignment.Right;
            // 
            // panelCh
            // 
            panelCh.BackColor = Color.FromArgb(204, 228, 247);
            panelCh.BorderStyle = BorderStyle.FixedSingle;
            panelCh.Controls.Add(txtFoundCh);
            panelCh.Controls.Add(lblFoundCh);
            panelCh.Controls.Add(txtComparisonsCh);
            panelCh.Controls.Add(lblComparisonsCh);
            panelCh.Controls.Add(txtTimeCh);
            panelCh.Controls.Add(lblTimeCh);
            panelCh.Controls.Add(lblChHeader);
            panelCh.Location = new Point(436, 84);
            panelCh.Name = "panelCh";
            panelCh.Size = new Size(410, 150);
            panelCh.TabIndex = 7;
            // 
            // lblChHeader
            // 
            lblChHeader.AutoSize = true;
            lblChHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblChHeader.Location = new Point(8, 6);
            lblChHeader.Name = "lblChHeader";
            lblChHeader.TabIndex = 0;
            lblChHeader.Text = "Метод цепочек";
            // 
            // lblTimeCh
            // 
            lblTimeCh.AutoSize = true;
            lblTimeCh.Font = new Font("Segoe UI", 10F);
            lblTimeCh.Location = new Point(10, 42);
            lblTimeCh.Name = "lblTimeCh";
            lblTimeCh.TabIndex = 1;
            lblTimeCh.Text = "Время, тики:";
            // 
            // txtTimeCh
            // 
            txtTimeCh.BackColor = Color.White;
            txtTimeCh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTimeCh.Location = new Point(230, 39);
            txtTimeCh.Name = "txtTimeCh";
            txtTimeCh.ReadOnly = true;
            txtTimeCh.Size = new Size(165, 25);
            txtTimeCh.TabIndex = 2;
            txtTimeCh.TabStop = false;
            txtTimeCh.TextAlign = HorizontalAlignment.Right;
            // 
            // lblComparisonsCh
            // 
            lblComparisonsCh.AutoSize = true;
            lblComparisonsCh.Font = new Font("Segoe UI", 10F);
            lblComparisonsCh.Location = new Point(10, 74);
            lblComparisonsCh.Name = "lblComparisonsCh";
            lblComparisonsCh.TabIndex = 3;
            lblComparisonsCh.Text = "Среднее число сравнений:";
            // 
            // txtComparisonsCh
            // 
            txtComparisonsCh.BackColor = Color.White;
            txtComparisonsCh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtComparisonsCh.Location = new Point(230, 71);
            txtComparisonsCh.Name = "txtComparisonsCh";
            txtComparisonsCh.ReadOnly = true;
            txtComparisonsCh.Size = new Size(165, 25);
            txtComparisonsCh.TabIndex = 4;
            txtComparisonsCh.TabStop = false;
            txtComparisonsCh.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFoundCh
            // 
            lblFoundCh.AutoSize = true;
            lblFoundCh.Font = new Font("Segoe UI", 10F);
            lblFoundCh.Location = new Point(10, 106);
            lblFoundCh.Name = "lblFoundCh";
            lblFoundCh.TabIndex = 5;
            lblFoundCh.Text = "Найдено ключей:";
            // 
            // txtFoundCh
            // 
            txtFoundCh.BackColor = Color.White;
            txtFoundCh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtFoundCh.Location = new Point(230, 103);
            txtFoundCh.Name = "txtFoundCh";
            txtFoundCh.ReadOnly = true;
            txtFoundCh.Size = new Size(165, 25);
            txtFoundCh.TabIndex = 6;
            txtFoundCh.TabStop = false;
            txtFoundCh.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMethodsInfo
            // 
            lblMethodsInfo.AutoSize = true;
            lblMethodsInfo.Font = new Font("Segoe UI", 9F);
            lblMethodsInfo.ForeColor = Color.DimGray;
            lblMethodsInfo.Location = new Point(14, 244);
            lblMethodsInfo.Name = "lblMethodsInfo";
            lblMethodsInfo.TabIndex = 8;
            lblMethodsInfo.Text = "";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(204, 228, 247);
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(720, 646);
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
            ClientSize = new Size(900, 692);
            Controls.Add(btnExit);
            Controls.Add(panelMethods);
            Controls.Add(panelFunctions);
            Controls.Add(panelTest);
            Controls.Add(lblTopic);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ЛР 4 - Мельников А.А., ИТз-441";
            Load += Form1_Load;
            panelTest.ResumeLayout(false);
            panelTest.PerformLayout();
            panelFunctions.ResumeLayout(false);
            panelFunctions.PerformLayout();
            panelMethods.ResumeLayout(false);
            panelMethods.PerformLayout();
            panelOA.ResumeLayout(false);
            panelOA.PerformLayout();
            panelCh.ResumeLayout(false);
            panelCh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIterations).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRepeats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTopic;
        private Panel panelTest;
        private Label lblTestHeader;
        private Label lblTestDivision;
        private TextBox txtTestDivision;
        private Label lblTestMidSquare;
        private TextBox txtTestMidSquare;
        private Label lblTestFolding;
        private TextBox txtTestFolding;
        private Label lblTestMultiplication;
        private TextBox txtTestMultiplication;
        private Button btnTest;
        private Label lblTestNote;
        private Panel panelFunctions;
        private Label lblFunctionsHeader;
        private Label lblIterations;
        private NumericUpDown nudIterations;
        private Button btnRun;
        private Label lblFunctionsNote;
        private Label lblWinsDivision;
        private TextBox txtWinsDivision;
        private Label lblWinsMidSquare;
        private TextBox txtWinsMidSquare;
        private Label lblWinsFolding;
        private TextBox txtWinsFolding;
        private Label lblWinsMultiplication;
        private TextBox txtWinsMultiplication;
        private Panel panelMethods;
        private Label lblMethodsHeader;
        private Label lblHashFunction;
        private ComboBox cmbHashFunction;
        private Label lblRepeats;
        private NumericUpDown nudRepeats;
        private Button btnCompare;
        private Panel panelOA;
        private Label lblOAHeader;
        private Label lblTimeOA;
        private TextBox txtTimeOA;
        private Label lblComparisonsOA;
        private TextBox txtComparisonsOA;
        private Label lblFoundOA;
        private TextBox txtFoundOA;
        private Panel panelCh;
        private Label lblChHeader;
        private Label lblTimeCh;
        private TextBox txtTimeCh;
        private Label lblComparisonsCh;
        private TextBox txtComparisonsCh;
        private Label lblFoundCh;
        private TextBox txtFoundCh;
        private Label lblMethodsInfo;
        private Button btnExit;
    }
}
