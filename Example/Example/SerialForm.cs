using NModbus;
using System.IO.Ports;

namespace Example
{
    public partial class SerialForm : Form
    {
        private IModbusMaster master;
        private byte slaveId = 0x01;
        private SerialPort port;


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
        }

        private void comboBoxPort_DropDown(object sender, EventArgs e)
        {
            SearchComport();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPort.SelectedItem == null || comboBoxBaud.SelectedItem == null)
                {
                    SetStatus("Please specify the COM Port and Baudrate first");
                    return;
                }

            }
            catch (Exception ex)
            {
                labelStatus.Text = ex.Message;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void labelResponse_Click(object sender, EventArgs e)
        {

        }

        private void labelReceive_Click(object sender, EventArgs e)
        {

        }

        private void SearchComport()
        {
            comboBoxPort.Items.Clear();

            var PortNames = SerialPort.GetPortNames();
            var status = "COM Port搜尋完畢";

            if (PortNames.Length == 0)
            {
                status += ",\r\n沒有搜尋到可以使用的COM Port";
            }
            else
            {
                comboBoxPort.Text = PortNames.Last();
                comboBoxPort.Items.AddRange(PortNames);
                comboBoxPort.SelectedItem = PortNames.Last();
            }

            SetStatus(status);
        }

        private void Baudrate_Initialize()
        {
            comboBoxBaud.DataSource = new List<int>() { 300, 1200, 2400, 9600, 19200, 38400, 115200 };
            comboBoxBaud.SelectedIndex = 4;
        }
    }
}
