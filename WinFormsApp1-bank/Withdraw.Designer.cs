﻿namespace WinFormsApp1_bank
{
    partial class Withdraw
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
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 233);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 11;
            label3.Text = "Amount";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(369, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 179);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 9;
            label2.Text = "Account No";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(369, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 71);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 7;
            label1.Text = "Withdraw Money";
            // 
            // button1
            // 
            button1.Location = new Point(328, 349);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 6;
            button1.Text = "Withdraw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Withdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Withdraw";
            Text = "Withdraw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}