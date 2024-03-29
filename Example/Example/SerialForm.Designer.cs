namespace Example
{
    partial class SerialForm
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "COM Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 9);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Baud";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(139, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(88, 23);
            comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(233, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(314, 26);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 71);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 106);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Response";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Receive";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 198);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 106);
            textBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 330);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 386);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "ModbusRTU Serial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
    }
}
