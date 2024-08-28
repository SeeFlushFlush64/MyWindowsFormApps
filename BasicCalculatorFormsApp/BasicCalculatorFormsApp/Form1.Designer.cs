namespace BasicCalculatorFormsApp
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
            textDisplay = new TextBox();
            numberSeven = new Button();
            numberEight = new Button();
            numberNine = new Button();
            numberSix = new Button();
            numberFive = new Button();
            numberFour = new Button();
            equalButton = new Button();
            decimalPoint = new Button();
            numberZero = new Button();
            numberThree = new Button();
            numberTwo = new Button();
            numberOne = new Button();
            divideButton = new Button();
            timesButton = new Button();
            minusButton = new Button();
            plusButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // textDisplay
            // 
            textDisplay.BackColor = Color.FromArgb(51, 51, 51);
            textDisplay.Enabled = false;
            textDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDisplay.ForeColor = Color.White;
            textDisplay.Location = new Point(29, 27);
            textDisplay.Name = "textDisplay";
            textDisplay.ReadOnly = true;
            textDisplay.Size = new Size(269, 50);
            textDisplay.TabIndex = 0;
            textDisplay.TextAlign = HorizontalAlignment.Right;
            textDisplay.TextChanged += textDisplay_TextChanged;
            // 
            // numberSeven
            // 
            numberSeven.BackColor = Color.FromArgb(102, 102, 102);
            numberSeven.Cursor = Cursors.Hand;
            numberSeven.FlatAppearance.BorderSize = 0;
            numberSeven.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            numberSeven.ForeColor = Color.White;
            numberSeven.Location = new Point(102, 112);
            numberSeven.Name = "numberSeven";
            numberSeven.Size = new Size(55, 46);
            numberSeven.TabIndex = 1;
            numberSeven.Text = "7";
            numberSeven.UseVisualStyleBackColor = false;
            numberSeven.Click += numberSeven_Click;
            // 
            // numberEight
            // 
            numberEight.BackColor = Color.FromArgb(102, 102, 102);
            numberEight.Cursor = Cursors.Hand;
            numberEight.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            numberEight.ForeColor = Color.White;
            numberEight.Location = new Point(172, 112);
            numberEight.Name = "numberEight";
            numberEight.Size = new Size(55, 46);
            numberEight.TabIndex = 2;
            numberEight.Text = "8";
            numberEight.UseVisualStyleBackColor = false;
            numberEight.Click += numberEight_Click;
            // 
            // numberNine
            // 
            numberNine.BackColor = Color.FromArgb(102, 102, 102);
            numberNine.Cursor = Cursors.Hand;
            numberNine.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            numberNine.ForeColor = Color.White;
            numberNine.Location = new Point(243, 112);
            numberNine.Name = "numberNine";
            numberNine.Size = new Size(55, 46);
            numberNine.TabIndex = 3;
            numberNine.Text = "9";
            numberNine.UseVisualStyleBackColor = false;
            numberNine.Click += numberNine_Click;
            // 
            // numberSix
            // 
            numberSix.BackColor = Color.FromArgb(102, 102, 102);
            numberSix.Cursor = Cursors.Hand;
            numberSix.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            numberSix.ForeColor = Color.White;
            numberSix.Location = new Point(243, 174);
            numberSix.Name = "numberSix";
            numberSix.Size = new Size(55, 46);
            numberSix.TabIndex = 6;
            numberSix.Text = "6";
            numberSix.UseVisualStyleBackColor = false;
            numberSix.Click += numberSix_Click;
            // 
            // numberFive
            // 
            numberFive.BackColor = Color.FromArgb(102, 102, 102);
            numberFive.Cursor = Cursors.Hand;
            numberFive.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            numberFive.ForeColor = Color.White;
            numberFive.Location = new Point(172, 174);
            numberFive.Name = "numberFive";
            numberFive.Size = new Size(55, 46);
            numberFive.TabIndex = 5;
            numberFive.Text = "5";
            numberFive.UseVisualStyleBackColor = false;
            numberFive.Click += numberFive_Click;
            // 
            // numberFour
            // 
            numberFour.BackColor = Color.FromArgb(102, 102, 102);
            numberFour.Cursor = Cursors.Hand;
            numberFour.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            numberFour.ForeColor = Color.White;
            numberFour.Location = new Point(102, 174);
            numberFour.Name = "numberFour";
            numberFour.Size = new Size(55, 46);
            numberFour.TabIndex = 4;
            numberFour.Text = "4";
            numberFour.UseVisualStyleBackColor = false;
            numberFour.Click += numberFour_Click;
            // 
            // equalButton
            // 
            equalButton.BackColor = Color.FromArgb(102, 102, 102);
            equalButton.Cursor = Cursors.Hand;
            equalButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            equalButton.ForeColor = Color.White;
            equalButton.Location = new Point(243, 300);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(55, 46);
            equalButton.TabIndex = 12;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = false;
            equalButton.Click += equalButton_Click;
            // 
            // decimalPoint
            // 
            decimalPoint.BackColor = Color.FromArgb(102, 102, 102);
            decimalPoint.Cursor = Cursors.Hand;
            decimalPoint.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            decimalPoint.ForeColor = Color.White;
            decimalPoint.Location = new Point(172, 300);
            decimalPoint.Name = "decimalPoint";
            decimalPoint.Size = new Size(55, 46);
            decimalPoint.TabIndex = 11;
            decimalPoint.Text = ".";
            decimalPoint.UseVisualStyleBackColor = false;
            decimalPoint.Click += decimalPoint_Click;
            // 
            // numberZero
            // 
            numberZero.BackColor = Color.FromArgb(102, 102, 102);
            numberZero.Cursor = Cursors.Hand;
            numberZero.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            numberZero.ForeColor = Color.White;
            numberZero.Location = new Point(102, 300);
            numberZero.Name = "numberZero";
            numberZero.Size = new Size(55, 46);
            numberZero.TabIndex = 10;
            numberZero.Text = "0";
            numberZero.UseVisualStyleBackColor = false;
            numberZero.Click += numberZero_Click;
            // 
            // numberThree
            // 
            numberThree.BackColor = Color.FromArgb(102, 102, 102);
            numberThree.Cursor = Cursors.Hand;
            numberThree.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            numberThree.ForeColor = Color.White;
            numberThree.Location = new Point(243, 238);
            numberThree.Name = "numberThree";
            numberThree.Size = new Size(55, 46);
            numberThree.TabIndex = 9;
            numberThree.Text = "3";
            numberThree.UseVisualStyleBackColor = false;
            numberThree.Click += numberThree_Click;
            // 
            // numberTwo
            // 
            numberTwo.BackColor = Color.FromArgb(102, 102, 102);
            numberTwo.Cursor = Cursors.Hand;
            numberTwo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            numberTwo.ForeColor = Color.White;
            numberTwo.Location = new Point(172, 238);
            numberTwo.Name = "numberTwo";
            numberTwo.Size = new Size(55, 46);
            numberTwo.TabIndex = 8;
            numberTwo.Text = "2";
            numberTwo.UseVisualStyleBackColor = false;
            numberTwo.Click += numberTwo_Click;
            // 
            // numberOne
            // 
            numberOne.BackColor = Color.FromArgb(102, 102, 102);
            numberOne.Cursor = Cursors.Hand;
            numberOne.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            numberOne.ForeColor = Color.White;
            numberOne.Location = new Point(102, 238);
            numberOne.Name = "numberOne";
            numberOne.Size = new Size(55, 46);
            numberOne.TabIndex = 7;
            numberOne.Text = "1";
            numberOne.UseVisualStyleBackColor = false;
            numberOne.Click += numberOne_Click;
            // 
            // divideButton
            // 
            divideButton.BackColor = Color.FromArgb(230, 149, 0);
            divideButton.Cursor = Cursors.Hand;
            divideButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            divideButton.ForeColor = Color.White;
            divideButton.Location = new Point(29, 300);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(55, 46);
            divideButton.TabIndex = 16;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += divideButton_Click;
            // 
            // timesButton
            // 
            timesButton.BackColor = Color.FromArgb(230, 149, 0);
            timesButton.Cursor = Cursors.Hand;
            timesButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            timesButton.ForeColor = Color.White;
            timesButton.Location = new Point(29, 238);
            timesButton.Name = "timesButton";
            timesButton.Size = new Size(55, 46);
            timesButton.TabIndex = 15;
            timesButton.Text = "*";
            timesButton.UseVisualStyleBackColor = false;
            timesButton.Click += timesButton_Click;
            // 
            // minusButton
            // 
            minusButton.BackColor = Color.FromArgb(230, 149, 0);
            minusButton.Cursor = Cursors.Hand;
            minusButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            minusButton.ForeColor = Color.White;
            minusButton.Location = new Point(29, 174);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(55, 46);
            minusButton.TabIndex = 14;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = false;
            minusButton.Click += minusButton_Click;
            // 
            // plusButton
            // 
            plusButton.BackColor = Color.FromArgb(230, 149, 0);
            plusButton.Cursor = Cursors.Hand;
            plusButton.FlatAppearance.BorderSize = 0;
            plusButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            plusButton.ForeColor = Color.White;
            plusButton.Location = new Point(29, 112);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(55, 46);
            plusButton.TabIndex = 13;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = false;
            plusButton.Click += plusButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(230, 149, 0);
            clearButton.Cursor = Cursors.Hand;
            clearButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(29, 362);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(55, 46);
            clearButton.TabIndex = 17;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(329, 450);
            Controls.Add(clearButton);
            Controls.Add(divideButton);
            Controls.Add(timesButton);
            Controls.Add(minusButton);
            Controls.Add(plusButton);
            Controls.Add(equalButton);
            Controls.Add(decimalPoint);
            Controls.Add(numberZero);
            Controls.Add(numberThree);
            Controls.Add(numberTwo);
            Controls.Add(numberOne);
            Controls.Add(numberSix);
            Controls.Add(numberFive);
            Controls.Add(numberFour);
            Controls.Add(numberNine);
            Controls.Add(numberEight);
            Controls.Add(numberSeven);
            Controls.Add(textDisplay);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDisplay;
        private Button numberSeven;
        private Button numberEight;
        private Button numberNine;
        private Button numberSix;
        private Button numberFive;
        private Button numberFour;
        private Button equalButton;
        private Button decimalPoint;
        private Button numberZero;
        private Button numberThree;
        private Button numberTwo;
        private Button numberOne;
        private Button divideButton;
        private Button timesButton;
        private Button minusButton;
        private Button plusButton;
        private Button clearButton;
    }
}
