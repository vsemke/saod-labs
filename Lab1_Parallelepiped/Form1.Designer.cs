namespace Lab1_Parallelepiped
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
            panelInput = new Panel();
            lblHint = new Label();
            nudC = new NumericUpDown();
            nudB = new NumericUpDown();
            nudA = new NumericUpDown();
            lblC = new Label();
            lblB = new Label();
            lblA = new Label();
            lblInputHeader = new Label();
            panelResult = new Panel();
            txtV = new TextBox();
            txtS = new TextBox();
            lblV = new Label();
            lblS = new Label();
            lblResultHeader = new Label();
            panelPicture = new Panel();
            lblPictureHeader = new Label();
            btnCalc = new Button();
            btnExit = new Button();
            panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudA).BeginInit();
            panelResult.SuspendLayout();
            panelPicture.SuspendLayout();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 51, 102);
            lblTitle.Location = new Point(18, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(313, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Лабораторная работа № 1";
            //
            // lblTopic
            //
            lblTopic.AutoSize = true;
            lblTopic.Font = new Font("Segoe UI", 11F);
            lblTopic.ForeColor = Color.FromArgb(0, 51, 102);
            lblTopic.Location = new Point(20, 48);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(560, 20);
            lblTopic.TabIndex = 1;
            lblTopic.Text = "Среда разработки Visual Studio. Площадь поверхности и объем параллелепипеда";
            //
            // panelInput
            //
            panelInput.BackColor = Color.FromArgb(204, 228, 247);
            panelInput.BorderStyle = BorderStyle.FixedSingle;
            panelInput.Controls.Add(lblHint);
            panelInput.Controls.Add(nudC);
            panelInput.Controls.Add(nudB);
            panelInput.Controls.Add(nudA);
            panelInput.Controls.Add(lblC);
            panelInput.Controls.Add(lblB);
            panelInput.Controls.Add(lblA);
            panelInput.Controls.Add(lblInputHeader);
            panelInput.Location = new Point(20, 85);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(330, 180);
            panelInput.TabIndex = 2;
            //
            // lblHint
            //
            lblHint.AutoSize = true;
            lblHint.Font = new Font("Segoe UI", 8.25F);
            lblHint.ForeColor = Color.DimGray;
            lblHint.Location = new Point(14, 150);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(286, 13);
            lblHint.TabIndex = 7;
            lblHint.Text = "Двойной щелчок по полю - начальные значения";
            //
            // nudC
            //
            nudC.DecimalPlaces = 2;
            nudC.Font = new Font("Segoe UI", 10F);
            nudC.Location = new Point(140, 110);
            nudC.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudC.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudC.Name = "nudC";
            nudC.Size = new Size(170, 25);
            nudC.TabIndex = 6;
            nudC.TextAlign = HorizontalAlignment.Right;
            nudC.Value = new decimal(new int[] { 5, 0, 0, 0 });
            nudC.ValueChanged += nudSide_ValueChanged;
            nudC.DoubleClick += nudSide_DoubleClick;
            //
            // nudB
            //
            nudB.DecimalPlaces = 2;
            nudB.Font = new Font("Segoe UI", 10F);
            nudB.Location = new Point(140, 76);
            nudB.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudB.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudB.Name = "nudB";
            nudB.Size = new Size(170, 25);
            nudB.TabIndex = 4;
            nudB.TextAlign = HorizontalAlignment.Right;
            nudB.Value = new decimal(new int[] { 4, 0, 0, 0 });
            nudB.ValueChanged += nudSide_ValueChanged;
            nudB.DoubleClick += nudSide_DoubleClick;
            //
            // nudA
            //
            nudA.DecimalPlaces = 2;
            nudA.Font = new Font("Segoe UI", 10F);
            nudA.Location = new Point(140, 42);
            nudA.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudA.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudA.Name = "nudA";
            nudA.Size = new Size(170, 25);
            nudA.TabIndex = 2;
            nudA.TextAlign = HorizontalAlignment.Right;
            nudA.Value = new decimal(new int[] { 3, 0, 0, 0 });
            nudA.ValueChanged += nudSide_ValueChanged;
            nudA.DoubleClick += nudSide_DoubleClick;
            //
            // lblC
            //
            lblC.AutoSize = true;
            lblC.Font = new Font("Segoe UI", 10F);
            lblC.Location = new Point(14, 112);
            lblC.Name = "lblC";
            lblC.Size = new Size(77, 19);
            lblC.TabIndex = 5;
            lblC.Text = "Сторона c:";
            //
            // lblB
            //
            lblB.AutoSize = true;
            lblB.Font = new Font("Segoe UI", 10F);
            lblB.Location = new Point(14, 78);
            lblB.Name = "lblB";
            lblB.Size = new Size(78, 19);
            lblB.TabIndex = 3;
            lblB.Text = "Сторона b:";
            //
            // lblA
            //
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 10F);
            lblA.Location = new Point(14, 44);
            lblA.Name = "lblA";
            lblA.Size = new Size(78, 19);
            lblA.TabIndex = 1;
            lblA.Text = "Сторона a:";
            //
            // lblInputHeader
            //
            lblInputHeader.AutoSize = true;
            lblInputHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInputHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblInputHeader.Location = new Point(10, 8);
            lblInputHeader.Name = "lblInputHeader";
            lblInputHeader.Size = new Size(129, 20);
            lblInputHeader.TabIndex = 0;
            lblInputHeader.Text = "Исходные данные";
            //
            // panelResult
            //
            panelResult.BackColor = Color.FromArgb(204, 228, 247);
            panelResult.BorderStyle = BorderStyle.FixedSingle;
            panelResult.Controls.Add(txtV);
            panelResult.Controls.Add(txtS);
            panelResult.Controls.Add(lblV);
            panelResult.Controls.Add(lblS);
            panelResult.Controls.Add(lblResultHeader);
            panelResult.Location = new Point(20, 277);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(330, 120);
            panelResult.TabIndex = 3;
            //
            // txtV
            //
            txtV.BackColor = Color.White;
            txtV.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtV.Location = new Point(140, 76);
            txtV.Name = "txtV";
            txtV.ReadOnly = true;
            txtV.Size = new Size(170, 25);
            txtV.TabIndex = 4;
            txtV.TabStop = false;
            txtV.TextAlign = HorizontalAlignment.Right;
            //
            // txtS
            //
            txtS.BackColor = Color.White;
            txtS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtS.Location = new Point(140, 42);
            txtS.Name = "txtS";
            txtS.ReadOnly = true;
            txtS.Size = new Size(170, 25);
            txtS.TabIndex = 2;
            txtS.TabStop = false;
            txtS.TextAlign = HorizontalAlignment.Right;
            //
            // lblV
            //
            lblV.AutoSize = true;
            lblV.Font = new Font("Segoe UI", 10F);
            lblV.Location = new Point(14, 78);
            lblV.Name = "lblV";
            lblV.Size = new Size(65, 19);
            lblV.TabIndex = 3;
            lblV.Text = "Объем V:";
            //
            // lblS
            //
            lblS.AutoSize = true;
            lblS.Font = new Font("Segoe UI", 10F);
            lblS.Location = new Point(14, 44);
            lblS.Name = "lblS";
            lblS.Size = new Size(118, 19);
            lblS.TabIndex = 1;
            lblS.Text = "Площадь пов. S:";
            //
            // lblResultHeader
            //
            lblResultHeader.AutoSize = true;
            lblResultHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblResultHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblResultHeader.Location = new Point(10, 8);
            lblResultHeader.Name = "lblResultHeader";
            lblResultHeader.Size = new Size(87, 20);
            lblResultHeader.TabIndex = 0;
            lblResultHeader.Text = "Результаты";
            //
            // panelPicture
            //
            panelPicture.BackColor = Color.FromArgb(204, 228, 247);
            panelPicture.BorderStyle = BorderStyle.FixedSingle;
            panelPicture.Controls.Add(lblPictureHeader);
            panelPicture.Location = new Point(365, 85);
            panelPicture.Name = "panelPicture";
            panelPicture.Size = new Size(375, 312);
            panelPicture.TabIndex = 4;
            panelPicture.Paint += panelPicture_Paint;
            //
            // lblPictureHeader
            //
            lblPictureHeader.AutoSize = true;
            lblPictureHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPictureHeader.ForeColor = Color.FromArgb(0, 51, 102);
            lblPictureHeader.Location = new Point(10, 8);
            lblPictureHeader.Name = "lblPictureHeader";
            lblPictureHeader.Size = new Size(225, 20);
            lblPictureHeader.TabIndex = 0;
            lblPictureHeader.Text = "Прямоугольный параллелепипед";
            //
            // btnCalc
            //
            btnCalc.BackColor = Color.FromArgb(204, 228, 247);
            btnCalc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalc.Location = new Point(20, 412);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(160, 36);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "Вычислить";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.FromArgb(204, 228, 247);
            btnExit.DialogResult = DialogResult.Cancel;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(580, 412);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 36);
            btnExit.TabIndex = 6;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // Form1
            //
            AcceptButton = btnCalc;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 244, 252);
            CancelButton = btnExit;
            ClientSize = new Size(760, 462);
            Controls.Add(btnExit);
            Controls.Add(btnCalc);
            Controls.Add(panelPicture);
            Controls.Add(panelResult);
            Controls.Add(panelInput);
            Controls.Add(lblTopic);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ЛР 1 - Мельников А.А., ИТз-441";
            Load += Form1_Load;
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudC).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudB).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudA).EndInit();
            panelResult.ResumeLayout(false);
            panelResult.PerformLayout();
            panelPicture.ResumeLayout(false);
            panelPicture.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTopic;
        private Panel panelInput;
        private Label lblInputHeader;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private NumericUpDown nudA;
        private NumericUpDown nudB;
        private NumericUpDown nudC;
        private Label lblHint;
        private Panel panelResult;
        private Label lblResultHeader;
        private Label lblS;
        private Label lblV;
        private TextBox txtS;
        private TextBox txtV;
        private Panel panelPicture;
        private Label lblPictureHeader;
        private Button btnCalc;
        private Button btnExit;
    }
}
