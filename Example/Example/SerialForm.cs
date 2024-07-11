using NModbus;
using NModbus.Serial;
using System.Diagnostics;
using System.IO.Ports;

namespace Example
{
    public partial class SerialForm : Form
    {
        private IModbusMaster master;
        private SerialPort serialPort;

        private string portName => comboBoxSerialPortName.SelectedItem.ToString();
        private int baudrate => int.Parse(comboBoxBaudrate.SelectedItem.ToString());

        private int SlaveID => int.TryParse(textBoxAddress.Text, out var address) ? address : 0;

        private int Register => int.TryParse(textBoxRegister.Text, out var register) ? register : 0;

        private int Value => int.TryParse(textBoxValue.Text, out var value) ? value : 0;

        private void SetStatus(string value) => Invoke(() => { labelStatus.Text = value; });

        public SerialForm()
        {
            InitializeComponent();
            
            Load += (s, e) =>
            {
                SearchComport();
                Baudrate_Initialize();

                SetStatus("開機初始" + Environment.NewLine + DateTime.Now);
            };

            FormClosing += (s, e) =>
            {
                CloseSerialPort();
            };
        }

        private void comboBoxPort_DropDown(object sender, EventArgs e)
        {
            SearchComport();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(portName + ":" + baudrate);
            OpenSerialPort();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            CloseSerialPort();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort is null || !serialPort.IsOpen)
            {
                SetStatus("SerialPort尚未建立或連線，請檢查後再試一次");
                return;
            }

            try
            {
                SetStatus("準備將資料寫入暫存器...");

                //Debug.WriteLine("暫存器:" + ((ushort)Register).ToString());
                //Debug.WriteLine("數值:" + ((ushort)Value).ToString());

                master.WriteSingleRegister((byte)SlaveID, (ushort)Register, (ushort)Value);

                SetStatus("已將資料寫入暫存器");
            }
            catch (Exception ex)
            {
                SetStatus("將資料寫入暫存器時發生錯誤：" + Environment.NewLine + ex.Message);
            }
        }

        private void labelReceive_Click(object sender, EventArgs e)
        {
            var registerValue = master?.ReadInputRegisters((byte)SlaveID, (ushort)Register, (ushort)Value);
        }

        private void SearchComport()
        {
            comboBoxSerialPortName.Items.Clear();

            var PortNames = SerialPort.GetPortNames();
            var status = "COM Port搜尋完畢";

            if (PortNames.Length == 0)
            {
                status += ",\r\n沒有搜尋到可以使用的COM Port";
            }
            else
            {
                comboBoxSerialPortName.Text = PortNames.Last();
                comboBoxSerialPortName.Items.AddRange(PortNames);
                comboBoxSerialPortName.SelectedItem = PortNames.Last();
            }

            SetStatus(status);
        }

        private void Baudrate_Initialize()
        {
            comboBoxBaudrate.DataSource = new List<int>() { 300, 1200, 2400, 9600, 19200, 38400, 115200 };
            comboBoxBaudrate.SelectedIndex = 6;
        }

        private void OpenSerialPort()
        {
            try
            {

                if (comboBoxSerialPortName.SelectedItem == null || comboBoxBaudrate.SelectedItem == null)
                {
                    return;
                }

                serialPort = new SerialPort();
                serialPort.PortName = portName;
                serialPort.BaudRate = baudrate;
                serialPort.Open();

                //serialPort.DataReceived += (s, e) =>
                //{
                //    SerialPort sp = s as SerialPort;
                //    var response = sp.ReadLine();
                //    Debug.WriteLine("From SerialPort" + response);
                //};

                var factory = new ModbusFactory();
                master = factory.CreateRtuMaster(new SerialPortAdapter(serialPort));

                SetStatus("SerialPort已開啟");
            }
            catch (Exception ex)
            {
                SetStatus(ex.ToString());
            }
        }

        private void CloseSerialPort()
        {
            if (serialPort is null)
            {
                return;
            }

            if (serialPort.IsOpen)
            {
                serialPort.Close();
                master.Dispose();
            }
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {
            var label = sender as Label;

            Clipboard.SetText(label.Text);
        }
    }
}
