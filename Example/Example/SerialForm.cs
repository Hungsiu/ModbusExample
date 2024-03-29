using NModbus;
using System.IO.Ports;

namespace Example
{
    public partial class SerialForm : Form
    {
        private IModbusMaster master;
        private byte slaveId = 0x01;
        private SerialPort port;

        public SerialForm()
        {
            InitializeComponent();
        }
    }
}
