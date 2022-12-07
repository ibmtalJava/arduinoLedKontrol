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
            serialPort = new SerialPort();  
        }
        public ArduinoCommand(string modul, string action, string data1, string data2, string data3)
        {
            this.modul = modul;
            this.action = action;
            this.data1 = data1;
            this.data2 = data2;
            this.data3 = data3;
            serialPort=new SerialPort();    
        }
        public void setSerialPort(int bautRate, string port)
        {
            if (this.serialPort.IsOpen) { 
                this.serialPort.Close();    
            }
            if (this.serialPort.IsOpen == false) { 
                this.serialPort.BaudRate = bautRate;    
                this.serialPort.PortName = port;    
                this.serialPort.Open(); 
            }

        }
        public void send(string modul, string action, string data1, string data2, string data3) {
            if (this.serialPort.IsOpen) {
                this.serialPort.WriteLine("#"+modul+"*"+action+"*"+data1+"*"+data2+"*"+data3+"&");
            }
        }

    }

}