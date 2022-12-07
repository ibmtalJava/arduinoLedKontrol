using System.IO.Ports;
namespace arduinoLedKontrol
{
     public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SerialPort arduino;
        private void button1_Click(object sender, EventArgs e)
        {
            if (arduino.IsOpen == false)
            {
                arduino.BaudRate = 115200;
                arduino.PortName = "COM3";
                arduino.Open();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arduino = new SerialPort();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arduino.IsOpen) {
                arduino.Write("led1yak");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arduino.IsOpen)
            {
                arduino.Write("led1sondur");
            }

        }
    }
}