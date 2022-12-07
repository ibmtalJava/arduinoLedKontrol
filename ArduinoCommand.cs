using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace arduinoLedKontrol
{
    public class ArduinoCommand
    {
        public string modul;
        public string action;
        public string data1;
        public string data2;
        public string data3;
        public SerialPort serialPort;
        public ArduinoCommand()
        {
        }
        public ArduinoCommand(string modul, string action, string data1, string data2, string data3)
        {
            this.modul = modul;
            this.action = action;
            this.data1 = data1;
            this.data2 = data2;
            this.data3 = data3;
        }
        public void setSerialPort(int bautRate, string port)
        {

        }

    }

}
