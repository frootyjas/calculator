namespace windows_forms_calculator
{
    partial class MainForm
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
            tlpNumberPad = new TableLayoutPanel();
            btnDecimal = new Button();
            btnZero = new Button();
            btnClear = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            tlpOperators = new TableLayoutPanel();
            equalsBtn = new Button();
            divideBtn = new Button();
            multiplyBtn = new Button();
            subtractBtn = new Button();
            addBtn = new Button();
            txtDisplay = new TextBox();
            mainPanel = new Panel();
            label1 = new Label();
            lstHistory = new ListBox();
            tlpNumberPad.SuspendLayout();
            tlpOperators.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tlpNumberPad
            // 
            tlpNumberPad.ColumnCount = 3;
            tlpNumberPad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNumberPad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNumberPad.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tlpNumberPad.Controls.Add(btnDecimal, 2, 3);
            tlpNumberPad.Controls.Add(btnZero, 1, 3);
            tlpNumberPad.Controls.Add(btnClear, 0, 3);
            tlpNumberPad.Controls.Add(btnNine, 2, 2);
            tlpNumberPad.Controls.Add(btnEight, 1, 2);
            tlpNumberPad.Controls.Add(btnSeven, 0, 2);
            tlpNumberPad.Controls.Add(btnSix, 2, 1);
            tlpNumberPad.Controls.Add(btnFive, 1, 1);
            tlpNumberPad.Controls.Add(btnFour, 0, 1);
            tlpNumberPad.Controls.Add(btnThree, 2, 0);
            tlpNumberPad.Controls.Add(btnTwo, 1, 0);
            tlpNumberPad.Controls.Add(btnOne, 0, 0);
            tlpNumberPad.Location = new Point(12, 99);
            tlpNumberPad.Margin = new Padding(5);
            tlpNumberPad.Name = "tlpNumberPad";
            tlpNumberPad.RowCount = 4;
            tlpNumberPad.RowStyles.Add(new RowStyle(SizeType.Percent, 48.5549126F));
            tlpNumberPad.RowStyles.Add(new RowStyle(SizeType.Percent, 51.4450874F));
            tlpNumberPad.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tlpNumberPad.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tlpNumberPad.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpNumberPad.Size = new Size(298, 378);
            tlpNumberPad.TabIndex = 0;
            // 
            // btnDecimal
            // 
            btnDecimal.AutoSize = true;
            btnDecimal.BackColor = Color.FromArgb(184, 185, 181);
            btnDecimal.Dock = DockStyle.Fill;
            btnDecimal.FlatStyle = FlatStyle.Flat;
            btnDecimal.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnDecimal.Location = new Point(211, 291);
            btnDecimal.Margin = new Padding(5);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(82, 82);
            btnDecimal.TabIndex = 14;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            btnZero.AutoSize = true;
            btnZero.BackColor = Color.FromArgb(184, 185, 181);
            btnZero.Dock = DockStyle.Fill;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnZero.Location = new Point(108, 291);
            btnZero.Margin = new Padding(5);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(93, 82);
            btnZero.TabIndex = 13;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.BackColor = Color.FromArgb(184, 185, 181);
            btnClear.Dock = DockStyle.Fill;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnClear.Location = new Point(5, 291);
            btnClear.Margin = new Padding(5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 82);
            btnClear.TabIndex = 12;
            btnClear.Text = "c";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnNine
            // 
            btnNine.AutoSize = true;
            btnNine.BackColor = Color.FromArgb(184, 185, 181);
            btnNine.Dock = DockStyle.Fill;
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnNine.Location = new Point(211, 200);
            btnNine.Margin = new Padding(5);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(82, 81);
            btnNine.TabIndex = 10;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            // 
            // btnEight
            // 
            btnEight.AutoSize = true;
            btnEight.BackColor = Color.FromArgb(184, 185, 181);
            btnEight.Dock = DockStyle.Fill;
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnEight.Location = new Point(108, 200);
            btnEight.Margin = new Padding(5);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(93, 81);
            btnEight.TabIndex = 9;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            // 
            // btnSeven
            // 
            btnSeven.AutoSize = true;
            btnSeven.BackColor = Color.FromArgb(184, 185, 181);
            btnSeven.Dock = DockStyle.Fill;
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnSeven.Location = new Point(5, 200);
            btnSeven.Margin = new Padding(5);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(93, 81);
            btnSeven.TabIndex = 8;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            // 
            // btnSix
            // 
            btnSix.AutoSize = true;
            btnSix.BackColor = Color.FromArgb(184, 185, 181);
            btnSix.Dock = DockStyle.Fill;
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnSix.Location = new Point(211, 100);
            btnSix.Margin = new Padding(5);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(82, 90);
            btnSix.TabIndex = 6;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            // 
            // btnFive
            // 
            btnFive.AutoSize = true;
            btnFive.BackColor = Color.FromArgb(184, 185, 181);
            btnFive.Dock = DockStyle.Fill;
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnFive.Location = new Point(108, 100);
            btnFive.Margin = new Padding(5);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(93, 90);
            btnFive.TabIndex = 3;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            // 
            // btnFour
            // 
            btnFour.AutoSize = true;
            btnFour.BackColor = Color.FromArgb(184, 185, 181);
            btnFour.Dock = DockStyle.Fill;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnFour.Location = new Point(5, 100);
            btnFour.Margin = new Padding(5);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(93, 90);
            btnFour.TabIndex = 2;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            // 
            // btnThree
            // 
            btnThree.AutoSize = true;
            btnThree.BackColor = Color.FromArgb(184, 185, 181);
            btnThree.Dock = DockStyle.Fill;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnThree.Location = new Point(211, 5);
            btnThree.Margin = new Padding(5);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(82, 85);
            btnThree.TabIndex = 4;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            // 
            // btnTwo
            // 
            btnTwo.AutoSize = true;
            btnTwo.BackColor = Color.FromArgb(184, 185, 181);
            btnTwo.Dock = DockStyle.Fill;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnTwo.Location = new Point(108, 5);
            btnTwo.Margin = new Padding(5);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(93, 85);
            btnTwo.TabIndex = 1;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            // 
            // btnOne
            // 
            btnOne.AutoSize = true;
            btnOne.BackColor = Color.FromArgb(184, 185, 181);
            btnOne.Dock = DockStyle.Fill;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("Courier New", 25.8000011F, FontStyle.Bold);
            btnOne.Location = new Point(3, 3);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(97, 89);
            btnOne.TabIndex = 0;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            // 
            // tlpOperators
            // 
            tlpOperators.ColumnCount = 1;
            tlpOperators.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpOperators.Controls.Add(equalsBtn, 0, 4);
            tlpOperators.Controls.Add(divideBtn, 0, 3);
            tlpOperators.Controls.Add(multiplyBtn, 0, 2);
            tlpOperators.Controls.Add(subtractBtn, 0, 1);
            tlpOperators.Controls.Add(addBtn, 0, 0);
            tlpOperators.Location = new Point(313, 99);
            tlpOperators.Name = "tlpOperators";
            tlpOperators.Padding = new Padding(5);
            tlpOperators.RowCount = 5;
            tlpOperators.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tlpOperators.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpOperators.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tlpOperators.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tlpOperators.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tlpOperators.Size = new Size(101, 378);
            tlpOperators.TabIndex = 1;
            // 
            // equalsBtn
            // 
            equalsBtn.AutoSize = true;
            equalsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            equalsBtn.BackColor = Color.FromArgb(184, 185, 181);
            equalsBtn.Dock = DockStyle.Fill;
            equalsBtn.FlatStyle = FlatStyle.Flat;
            equalsBtn.Font = new Font("Courier New", 22.2F);
            equalsBtn.Location = new Point(10, 309);
            equalsBtn.Margin = new Padding(5);
            equalsBtn.Name = "equalsBtn";
            equalsBtn.Size = new Size(81, 59);
            equalsBtn.TabIndex = 13;
            equalsBtn.Text = "=";
            equalsBtn.UseVisualStyleBackColor = false;
            // 
            // divideBtn
            // 
            divideBtn.AutoSize = true;
            divideBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            divideBtn.BackColor = Color.FromArgb(184, 185, 181);
            divideBtn.Dock = DockStyle.Fill;
            divideBtn.FlatStyle = FlatStyle.Flat;
            divideBtn.Font = new Font("Courier New", 22.2F);
            divideBtn.Location = new Point(10, 232);
            divideBtn.Margin = new Padding(5);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(81, 67);
            divideBtn.TabIndex = 12;
            divideBtn.Text = "÷";
            divideBtn.UseVisualStyleBackColor = false;
            // 
            // multiplyBtn
            // 
            multiplyBtn.AutoSize = true;
            multiplyBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            multiplyBtn.BackColor = Color.FromArgb(184, 185, 181);
            multiplyBtn.Dock = DockStyle.Fill;
            multiplyBtn.FlatStyle = FlatStyle.Flat;
            multiplyBtn.Font = new Font("Courier New", 22.2F);
            multiplyBtn.Location = new Point(10, 159);
            multiplyBtn.Margin = new Padding(5);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(81, 63);
            multiplyBtn.TabIndex = 8;
            multiplyBtn.Text = "×";
            multiplyBtn.UseVisualStyleBackColor = false;
            // 
            // subtractBtn
            // 
            subtractBtn.AutoSize = true;
            subtractBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            subtractBtn.BackColor = Color.FromArgb(184, 185, 181);
            subtractBtn.Dock = DockStyle.Fill;
            subtractBtn.FlatStyle = FlatStyle.Flat;
            subtractBtn.Font = new Font("Courier New", 22.2F);
            subtractBtn.Location = new Point(10, 86);
            subtractBtn.Margin = new Padding(5);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(81, 63);
            subtractBtn.TabIndex = 2;
            subtractBtn.Text = "-";
            subtractBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            addBtn.AutoSize = true;
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.BackColor = Color.FromArgb(184, 185, 181);
            addBtn.Dock = DockStyle.Fill;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Courier New", 22.2F);
            addBtn.Location = new Point(10, 10);
            addBtn.Margin = new Padding(5);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(81, 66);
            addBtn.TabIndex = 0;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = false;
            // 
            // txtDisplay
            // 
            txtDisplay.BorderStyle = BorderStyle.FixedSingle;
            txtDisplay.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(402, 81);
            txtDisplay.TabIndex = 2;
            txtDisplay.TabStop = false;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.Info;
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(lstHistory);
            mainPanel.Controls.Add(tlpOperators);
            mainPanel.Controls.Add(tlpNumberPad);
            mainPanel.Controls.Add(txtDisplay);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(641, 492);
            mainPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 66);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(110, 27);
            label1.TabIndex = 4;
            label1.Text = "History";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.ItemHeight = 19;
            lstHistory.Location = new Point(434, 93);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(195, 384);
            lstHistory.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(641, 492);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Window Forms Calculator";
            tlpNumberPad.ResumeLayout(false);
            tlpNumberPad.PerformLayout();
            tlpOperators.ResumeLayout(false);
            tlpOperators.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpNumberPad;
        private Button btnDecimal;
        private Button btnZero;
        private Button btnClear;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnSix;
        private Button btnThree;
        private Button btnFive;
        private Button btnFour;
        private Button btnTwo;
        private Button btnOne;
        private TableLayoutPanel tlpOperators;
        private Button equalsBtn;
        private Button divideBtn;
        private Button multiplyBtn;
        private Button subtractBtn;
        private Button addBtn;
        private TextBox txtDisplay;
        private Panel mainPanel;
        private ListBox lstHistory;
        private Label label1;
    }
}
