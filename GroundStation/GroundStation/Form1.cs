using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
//Related to port:
using System.IO;
using System.IO.Ports;


namespace GroundStation_Mahsa
{
    public partial class GroundStation_Form : Form
    {
        // global parameters:
        private int baud;

        private string prt;

        public GroundStation_Form()
        {
            InitializeComponent();
            //initialize global variables:
            baud = 9600;
            prt = "";
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroundStation_Form_Load(object sender, EventArgs e)
        {
            GMap1.MapProvider = GMap.NET.MapProviders.GMapProviders.BingSatelliteMap;
            // save map
            GMap1.Manager.Mode = GMap.NET.AccessMode.ServerAndCache;
            //position (Tehran):
            GMap1.Position = new PointLatLng(35.971684, 51.589759);

            GMap1.Zoom = 16;

            BaudRate_ComboBox.Items.Add("9600");
            BaudRate_ComboBox.Items.Add("19200");
            BaudRate_ComboBox.Items.Add("38400");
            BaudRate_ComboBox.Items.Add("57600");
            BaudRate_ComboBox.Items.Add("74880");
            BaudRate_ComboBox.Items.Add("115200");
            BaudRate_ComboBox.Items.Add("230400");
            BaudRate_ComboBox.Items.Add("250000");
            BaudRate_ComboBox.Items.Add("500000");
            BaudRate_ComboBox.SelectedIndex = 0;


            RefreshPorts();
        }

        private void CONNECT_btn_Click(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)
            {
                serialPort1.BaudRate = baud;
                if(prt=="")
                {
                    MessageBox.Show("Port Not Selected");
                    return;
                }
                serialPort1.PortName = prt;

                serialPort1.Open();
                CONNECT_btn.Text = "Disconnect";
                CONNECT_btn.Image = GroundStation_Mahsa.Properties.Resources.connect;

            }
            else
            {
                this.Invoke((MethodInvoker)delegate()
                { 
                    serialPort1.Close();
                    CONNECT_btn.Text = "Connect";
                    CONNECT_btn.Image = GroundStation_Mahsa.Properties.Resources.disconnect;
                });
               
            }
            // marker for map:
            //PointLatLng pos1 = new PointLatLng(35.971684, 51.589759);

            //GMapOverlay points_ = new GMapOverlay(GMap1,"pointCollection");
            //GMapMarker marker = new GMapMarkerGoogleRed(pos1);
            //points_.Markers.Add(marker);

            //GMap1.Overlays.Add(points_);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                ConnectionStatus_lbl.Text = "Connection Status\n\nData Recieved";
            });

        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            ConnectionStatus_lbl.Text = "Connection Status\n\nError occured";
        }

        private void serialPort1_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            // Refreshports is a function:
            RefreshPorts();
        }

        //Define a function that shows port names when called.
        private void RefreshPorts()
        {
            string[] ports = new string[100];
            ports = SerialPort.GetPortNames();
            Port_ComboBox.Items.Clear();
            foreach (string port in ports)
            {
                Port_ComboBox.Items.Add(port);
            }


        }

        private void Port_ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            prt = Port_ComboBox.SelectedItem.ToString();
 
        }

        private void Port_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BaudRate_ComboBox.SelectedIndex)
            {
                case 0:
                    baud = 9600;
                    break;
                case 1:
                    baud = 19200;
                    break;
                case 2:
                    baud = 38400;
                    break;
                case 3:
                    baud = 57600;
                    break;
                case 4:
                    baud = 74880;
                    break;
                case 5:
                    baud = 115200;
                    break;
                case 6:
                    baud = 230400;
                    break;
                case 7:
                    baud = 250000;
                    break;
                case 8:
                    baud = 500000;
                    break;
                default:
                    baud = 9600;
                    break;
            }
        }
    }
}
