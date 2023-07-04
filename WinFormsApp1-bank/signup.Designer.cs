namespace WinFormsApp1_bank
{
    partial class signup
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
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            label7 = new Label();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(366, 275);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(366, 212);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(234, 212);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 11;
            label5.Text = "Enter Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(234, 144);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 10;
            label6.Text = "Enter Username:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(366, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(466, 358);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 8;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(366, 47);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 7;
            label7.Text = "Login to System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 275);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 13;
            label1.Text = "Admin?";
            // 
            // button1
            // 
            button1.Location = new Point(345, 358);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 14;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 411);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 15;
            label2.Click += label2_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Name = "signup";
            Text = "signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Button button2;
        private Label label7;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}