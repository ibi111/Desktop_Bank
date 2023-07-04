namespace WinFormsApp1_bank
{
    partial class Transfer
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
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 266);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 17;
            label3.Text = "Amount";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(369, 263);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 179);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 15;
            label2.Text = "To Account No";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(369, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 71);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 13;
            label1.Text = "Transfer Money";
            // 
            // button1
            // 
            button1.Location = new Point(338, 346);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 12;
            button1.Text = "Transfer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 219);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 19;
            label4.Text = "From Account No";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(369, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(32, 35);
            label5.TabIndex = 20;
            label5.Text = "<";
            label5.Click += label5_Click;
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Transfer";
            Text = "Transfer";
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
        private Label label4;
        private TextBox textBox3;
        private Label label5;
    }
}