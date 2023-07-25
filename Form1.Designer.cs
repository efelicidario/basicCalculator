namespace my_calc
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
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonEquals = new Button();
            panel1 = new Panel();
            textBoxResult = new TextBox();
            buttonClear = new Button();
            buttonClearEntry = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button0
            // 
            button0.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(78, 342);
            button0.Name = "button0";
            button0.Size = new Size(60, 60);
            button0.TabIndex = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += buttonNum_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 276);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonNum_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(78, 276);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonNum_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(144, 276);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonNum_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 210);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonNum_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(78, 210);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonNum_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(144, 210);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonNum_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(12, 144);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonNum_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(78, 144);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonNum_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(144, 144);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonNum_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonAdd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(210, 276);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(60, 60);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonOp_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.BackColor = SystemColors.ControlLight;
            buttonSubtract.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubtract.Location = new Point(210, 210);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(60, 60);
            buttonSubtract.TabIndex = 11;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = false;
            buttonSubtract.Click += buttonOp_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = SystemColors.ControlLight;
            buttonMultiply.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiply.Location = new Point(210, 144);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(60, 60);
            buttonMultiply.TabIndex = 12;
            buttonMultiply.Text = "×";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonOp_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = SystemColors.ControlLight;
            buttonDivide.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivide.Location = new Point(210, 78);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(60, 60);
            buttonDivide.TabIndex = 13;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonOp_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = Color.DarkCyan;
            buttonEquals.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEquals.Location = new Point(210, 342);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(60, 60);
            buttonEquals.TabIndex = 14;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBoxResult);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 60);
            panel1.TabIndex = 15;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = Color.White;
            textBoxResult.BorderStyle = BorderStyle.None;
            textBoxResult.Enabled = false;
            textBoxResult.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxResult.ForeColor = Color.Black;
            textBoxResult.Location = new Point(3, 17);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(252, 40);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextAlign = HorizontalAlignment.Right;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ControlLight;
            buttonClear.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(144, 78);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(60, 60);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonClearEntry
            // 
            buttonClearEntry.BackColor = SystemColors.ControlLight;
            buttonClearEntry.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClearEntry.Location = new Point(78, 78);
            buttonClearEntry.Name = "buttonClearEntry";
            buttonClearEntry.Size = new Size(60, 60);
            buttonClearEntry.TabIndex = 17;
            buttonClearEntry.Text = "CE";
            buttonClearEntry.UseVisualStyleBackColor = false;
            buttonClearEntry.Click += buttonClearEntry_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(311, 422);
            Controls.Add(buttonClearEntry);
            Controls.Add(buttonClear);
            Controls.Add(panel1);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonEquals;
        private Panel panel1;
        private TextBox textBoxResult;
        private Button buttonClear;
        private Button buttonClearEntry;
    }
}