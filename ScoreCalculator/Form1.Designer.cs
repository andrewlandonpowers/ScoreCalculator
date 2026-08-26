namespace ScoreCalculator
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
            lblScore = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnClear = new Button();
            btnExit = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(45, 56);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(56, 25);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 108);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Score total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 160);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 2;
            label3.Text = "Score Count:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 212);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 3;
            label4.Text = "Average:";
            label4.Click += label4_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(46, 273);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(238, 273);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 31);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 108);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(83, 31);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 160);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(83, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 212);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(83, 31);
            textBox4.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(267, 51);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 34);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button3_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(375, 331);
            Controls.Add(btnAdd);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblScore);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnClear;
        private Button btnExit;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnAdd;
    }
}
