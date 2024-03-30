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
            comboBoxSerialPortName = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxBaudrate = new ComboBox();
            buttonOpen = new Button();
            buttonClose = new Button();
            textBoxReceive = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxResponse = new TextBox();
            labelStatus = new Label();
            labelReceive = new Label();
            labelResponse = new Label();
            SuspendLayout();
            // 
            // comboBoxSerialPortName
            // 
            comboBoxSerialPortName.FormattingEnabled = true;
            comboBoxSerialPortName.Location = new Point(12, 27);
            comboBoxSerialPortName.Name = "comboBoxSerialPortName";
            comboBoxSerialPortName.Size = new Size(121, 23);
            comboBoxSerialPortName.TabIndex = 1;
            comboBoxSerialPortName.DropDown += comboBoxPort_DropDown;
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
            // comboBoxBaudrate
            // 
            comboBoxBaudrate.FormattingEnabled = true;
            comboBoxBaudrate.Location = new Point(139, 27);
            comboBoxBaudrate.Name = "comboBoxBaudrate";
            comboBoxBaudrate.Size = new Size(88, 23);
            comboBoxBaudrate.TabIndex = 3;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(233, 26);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(75, 23);
            buttonOpen.TabIndex = 4;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(314, 26);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxReceive
            // 
            textBoxReceive.Location = new Point(12, 71);
            textBoxReceive.Multiline = true;
            textBoxReceive.Name = "textBoxReceive";
            textBoxReceive.Size = new Size(215, 106);
            textBoxReceive.TabIndex = 6;
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
            // textBoxResponse
            // 
            textBoxResponse.Location = new Point(12, 198);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.ReadOnly = true;
            textBoxResponse.Size = new Size(215, 106);
            textBoxResponse.TabIndex = 8;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(12, 330);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(41, 15);
            labelStatus.TabIndex = 10;
            labelStatus.Text = "Status";
            // 
            // labelReceive
            // 
            labelReceive.AutoSize = true;
            labelReceive.Location = new Point(233, 198);
            labelReceive.Name = "labelReceive";
            labelReceive.Size = new Size(67, 15);
            labelReceive.TabIndex = 11;
            labelReceive.Text = "　　　　　";
            labelReceive.Click += labelReceive_Click;
            // 
            // labelResponse
            // 
            labelResponse.AutoSize = true;
            labelResponse.Location = new Point(233, 71);
            labelResponse.Name = "labelResponse";
            labelResponse.Size = new Size(67, 15);
            labelResponse.TabIndex = 12;
            labelResponse.Text = "　　　　　";
            labelResponse.Click += labelResponse_Click;
            // 
            // SerialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 386);
            Controls.Add(labelResponse);
            Controls.Add(labelReceive);
            Controls.Add(labelStatus);
            Controls.Add(label4);
            Controls.Add(textBoxResponse);
            Controls.Add(label3);
            Controls.Add(textBoxReceive);
            Controls.Add(buttonClose);
            Controls.Add(buttonOpen);
            Controls.Add(label2);
            Controls.Add(comboBoxBaudrate);
            Controls.Add(label1);
            Controls.Add(comboBoxSerialPortName);
            Name = "SerialForm";
            Text = "ModbusRTU Serial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSerialPortName;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxBaudrate;
        private Button buttonOpen;
        private Button buttonClose;
        private TextBox textBoxReceive;
        private Label label3;
        private Label label4;
        private TextBox textBoxResponse;
        private Label labelStatus;
        private Label labelReceive;
        private Label labelResponse;
    }
}
