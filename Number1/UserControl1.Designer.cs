﻿namespace Number1
{
    partial class UserControl1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Num1 = new Label();
            Num2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            Result = new Label();
            compare = new Button();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.AutoSize = true;
            Num1.Location = new Point(335, 105);
            Num1.Name = "Num1";
            Num1.Size = new Size(49, 20);
            Num1.TabIndex = 0;
            Num1.Text = "Num1";
            // 
            // Num2
            // 
            Num2.AutoSize = true;
            Num2.Location = new Point(731, 105);
            Num2.Name = "Num2";
            Num2.Size = new Size(49, 20);
            Num2.TabIndex = 1;
            Num2.Text = "Num2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(335, 148);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter the first value";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(731, 148);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter the second value";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(499, 35);
            label3.Name = "label3";
            label3.Size = new Size(265, 37);
            label3.TabIndex = 4;
            label3.Text = "Number Comparison";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(0, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Result.ForeColor = Color.Red;
            Result.Location = new Point(584, 206);
            Result.Name = "Result";
            Result.Size = new Size(68, 28);
            Result.TabIndex = 6;
            Result.Text = "Result:";
            Result.Click += Result_Click;
            // 
            // compare
            // 
            compare.Location = new Point(557, 307);
            compare.Name = "compare";
            compare.Size = new Size(155, 53);
            compare.TabIndex = 7;
            compare.Text = "compare";
            compare.UseVisualStyleBackColor = true;
            compare.Click += compare_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(compare);
            Controls.Add(Result);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Name = "UserControl1";
            Size = new Size(1225, 467);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Num1;
        private Label Num2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label Result;
        private Button compare;
    }
}
