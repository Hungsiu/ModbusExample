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
            textBoxRegister = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxResponse = new TextBox();
            labelStatus = new Label();
            labelReceive = new Label();
            buttonSend = new Button();
            label5 = new Label();
            textBoxValue = new TextBox();
            label6 = new Label();
            textBoxAddress = new TextBox();
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
            // textBoxRegister
            // 
            textBoxRegister.Location = new Point(11, 132);
            textBoxRegister.Multiline = true;
            textBoxRegister.Name = "textBoxRegister";
            textBoxRegister.Size = new Size(215, 40);
            textBoxRegister.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 114);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Register";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 248);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Receive";
            // 
            // textBoxResponse
            // 
            textBoxResponse.Location = new Point(12, 266);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.ReadOnly = true;
            textBoxResponse.Size = new Size(215, 40);
            textBoxResponse.TabIndex = 16;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Dock = DockStyle.Bottom;
            labelStatus.Location = new Point(0, 371);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(41, 15);
            labelStatus.TabIndex = 10;
            labelStatus.Text = "Status";
            labelStatus.Click += labelStatus_Click;
            // 
            // labelReceive
            // 
            labelReceive.AutoSize = true;
            labelReceive.Location = new Point(233, 266);
            labelReceive.Name = "labelReceive";
            labelReceive.Size = new Size(67, 15);
            labelReceive.TabIndex = 11;
            labelReceive.Text = "　　　　　";
            labelReceive.Click += labelReceive_Click;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(232, 205);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 15;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 187);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 14;
            label5.Text = "Value";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(12, 205);
            textBoxValue.Multiline = true;
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(215, 40);
            textBoxValue.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 53);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 16;
            label6.Text = "Address";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(12, 71);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(215, 40);
            textBoxAddress.TabIndex = 6;
            // 
            // SerialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 386);
            Controls.Add(label6);
            Controls.Add(textBoxAddress);
            Controls.Add(label5);
            Controls.Add(textBoxValue);
            Controls.Add(buttonSend);
            Controls.Add(labelReceive);
            Controls.Add(labelStatus);
            Controls.Add(label4);
            Controls.Add(textBoxResponse);
            Controls.Add(label3);
            Controls.Add(textBoxRegister);
            Controls.Add(buttonClose);
            Controls.Add(buttonOpen);
            Controls.Add(label2);
            Controls.Add(comboBoxBaudrate);
            Controls.Add(label1);
            Controls.Add(comboBoxSerialPortName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
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
        private TextBox textBoxRegister;
        private Label label3;
        private Label label4;
        private TextBox textBoxResponse;
        private Label labelStatus;
        private Label labelReceive;
        private Button buttonSend;
        private Label label5;
        private TextBox textBoxValue;
        private Label label6;
        private TextBox textBoxAddress;
    }
}
