namespace WinFormsApp1_bank
{
    partial class searchAccount
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
            label7 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(32, 35);
            label7.TabIndex = 25;
            label7.Text = "<";
            label7.Click += label7_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 119);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 17;
            label3.Text = "Account No:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(200, 204);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 14;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 21);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 13;
            label1.Text = "Search Account";
            label1.Click += label1_Click;
            // 
            // searchAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(547, 329);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "searchAccount";
            Text = "searchAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Label label1;
    }
}