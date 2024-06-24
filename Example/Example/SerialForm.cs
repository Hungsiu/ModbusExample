using NModbus;
using NModbus.Serial;
using System.Diagnostics;
using System.IO.Ports;

namespace Example
{
    public partial class SerialForm : Form
    {
        private IModbusMaster master;
        private byte slaveId = 0x01;
        private SerialPort serialPort;

        private int Register => int.TryParse(textBoxRegister.Text, out var register) ? Convert.ToInt32(textBoxRegister.Text) : 0;

        private int Value => int.TryParse(textBoxValue.Text, out var register) ? Convert.ToInt32(textBoxValue.Text) : 0;

        private void SetStatus(string value) => BeginInvoke(() => { labelStatus.Text = value; });

        public SerialForm()
        {
            InitializeComponent();
            MaximizeBox = false;


            Load += (s, e) =>
            {
                SearchComport();
                Baudrate_Initialize();

                SetStatus("Boost initialize");
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
            OpenSerialPort();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            CloseSerialPort();
        }

        private void buttonResponse_Click(object sender, EventArgs e)
        {
            if (serialPort is null || !serialPort.IsOpen)
            {
                return;
            }

            master.WriteSingleRegister(slaveId, (ushort)Register, (ushort)Value);
        }

        private void labelReceive_Click(object sender, EventArgs e)
        {

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
            comboBoxBaudrate.SelectedIndex = 4;
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
                serialPort.PortName = (string)comboBoxSerialPortName.SelectedItem;
                serialPort.BaudRate = int.Parse((string)comboBoxBaudrate.SelectedItem);
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.None;
                serialPort.Open();

                var factory = new ModbusFactory();
                master = factory.CreateRtuMaster(new SerialPortAdapter(serialPort));

                SetStatus("SerialPort is opened");
            }
            catch (Exception ex)
            {
                SetStatus(ex.ToString());
            }
        }

        private void CloseSerialPort()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
