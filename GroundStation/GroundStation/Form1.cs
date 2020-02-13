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

        public Server server;

        private GMapOverlay cansat_layer;

        GMapMarker cansat_marker;

        String[] names = {"Altitude (MSL)", "Altitude (Relative)",
                            "Rate of Descend", "Pressure",
                            "Velocity (easting)", "Velocity (northing)",
                            "Current", "Voltage"};

        private DateTime lastTimerTick = DateTime.Now;

        int plotsNum = 8;

        public GroundStation_Form()
        {
            InitializeComponent();
            //initialize global variables:
            server = new Server();
            baud = 9600;
            prt = "";

            cansat_layer = new GMapOverlay(GMap1, "cansat layer");
            cansat_marker = new GMapMarkerImage(new PointLatLng(), GroundStation_Mahsa.Properties.Resources.satImg1);

            cansat_layer.Markers.Add(cansat_marker);

            GMap1.Overlays.Add(cansat_layer);

            configPlots();

            lastTimerTick = DateTime.Now;
        }

        private String RenderXLabels(GraphLib.DataSource s, int idx)
        {
            String label = "";
            if(s.Name == names[3])
            {
                int value = (int)(s.Samples[idx].x/30);
                label = "" + value;
                
            }
            else
            {
                int value = (int)(s.Samples[idx].x / 20);
                label = "" + value + "\"";
            }

            return label;
        }

        private String RenderYLabel(GraphLib.DataSource s, float value)
        {
            return String.Format("{0:0.0}", value);
        }

        public void configPlots()
        {
            plotter.DataSources.Clear();
            plotter.SetDisplayRangeX(0, 400);

            
            for (int j = 0; j < plotsNum; j++)
            {
                plotter.DataSources.Add(new GraphLib.DataSource());
                plotter.DataSources[j].Name = names[j];
                plotter.DataSources[j].OnRenderXAxisLabel += RenderXLabels;

                plotter.PanelLayout = GraphLib.PlotterGraphPaneEx.LayoutMode.TILES_VER;
                plotter.DataSources[j].Length = 10000;
                plotter.DataSources[j].AutoScaleY = true;
                plotter.DataSources[j].SetDisplayRangeY(-300, 300);
                plotter.DataSources[j].SetGridDistanceY(100);
                plotter.DataSources[j].OnRenderYAxisLabel = RenderYLabel;

            }

            Color[] cols = { Color.FromArgb(255,0,0), 
                                         Color.FromArgb(0,255,0),
                                         Color.FromArgb(255,255,0), 
                                         Color.FromArgb(64,64,255), 
                                         Color.FromArgb(0,255,255) ,
                                         Color.FromArgb(255,0,255),                              
                                         Color.FromArgb(255,128,0) };

            for (int j = 0; j < plotsNum; j++)
            {
                plotter.DataSources[j].GraphColor = cols[j % 7];
            }

            plotter.BackgroundColorTop = Color.White;
            plotter.BackgroundColorBot = Color.White;
            plotter.SolidGridColor = Color.DarkGray;
            plotter.DashedGridColor = Color.DarkGray;
            plotter.SolidGridColor = Color.Black;

            plotter.Refresh();
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroundStation_Form_Load(object sender, EventArgs e)
        {

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
            List<byte> received_bytes = new List<byte>();
            if (serialPort1.IsOpen)
            {
                while (serialPort1.IsOpen && received_bytes.Count < serialPort1.BytesToRead)
                {
                    if (serialPort1.IsOpen)
                    {
                        received_bytes.Add((byte)serialPort1.ReadByte());

                    }
                }
            }

            this.Invoke((MethodInvoker)delegate()
            {
                server.make_buffer(received_bytes);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Updating Labels
            ALTMSLValue_lbl.Text = server.location.alt.ToString();
            cansat_marker.Position = new PointLatLng(server.location.lat, server.location.lng);

            // Updating Graphs
            try
            {
                TimeSpan dt = DateTime.Now - lastTimerTick;

                for (int j = 0; j < plotsNum; j++)
                {

                    CalcSinusFunction_3(plotter.DataSources[j], j, (float)dt.TotalMilliseconds);

                }

                //this.Invoke(new MethodInvoker(RefreshGraph));
            }
            catch (ObjectDisposedException ex)
            {
                // we get this on closing of form
            }
            catch (Exception ex)
            {
                Console.Write("exception invoking refreshgraph(): " + ex.Message);
            }

        }

        protected void CalcSinusFunction_3(GraphLib.DataSource ds, int idx, float time)
        {
            GraphLib.cPoint[] src = ds.Samples;
            for (int i = 0; i < src.Length; i++)
            {
                src[i].x = i;
                src[i].y = 200 + (float)((200 * Math.Sin((idx + 1) * (time + i * 100) / 8000.0))) +
                                +(float)((40 * Math.Sin((idx + 1) * (time + i * 200) / 2000.0)));
                /**
                            (float)( 4* Math.Sin( ((time + (i+8) * 100) / 900.0)))+
                            (float)(28 * Math.Sin(((time + (i + 8) * 100) / 290.0))); */
            }

        }

        private void RefreshGraph()
        {
            plotter.Refresh();
        }

        private void GroundStation_Form_Shown(object sender, EventArgs e)
        {
            GMap1.MapProvider = GMap.NET.MapProviders.GMapProviders.BingSatelliteMap;
            // save map
            GMap1.Manager.Mode = GMap.NET.AccessMode.ServerAndCache;
            //position (Tehran):
            GMap1.Position = new PointLatLng(35.971684, 51.589759);

            GMap1.Zoom = 10;

        }

        private void ZoomInBtn_Click(object sender, EventArgs e)
        {
            GMap1.Zoom += 1;
        }

        private void ZoomOutBtn_Click(object sender, EventArgs e)
        {
            GMap1.Zoom -= 1;
        }
    }

    public class GMapMarkerImage : GMapMarker
    {
        public double Heading;
        private Image img;
        private float imageScaleFactor = 1;
        public Image MarkerImage
        {
            get
            {
                return img;
            }
            set
            {
                img = value;
            }
        }

        public float ScaleFactor
        {
            get
            {
                return imageScaleFactor;
            }
            set
            {
                imageScaleFactor = value;
            }
        }

        public GMapMarkerImage(PointLatLng p, Image image)
            : base(p)
        {
            img = image;
            Size = img.Size;
            Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2);
        }

        public override void OnRender(Graphics g)
        {
            Point Aircraft_Position = new Point(LocalPosition.X, LocalPosition.Y);
            Point Center = new Point(Aircraft_Position.X + 25, Aircraft_Position.Y + 25);
            Rotate_Image(g, img, Aircraft_Position, Center, (float)Heading, imageScaleFactor);
        }

        protected void Rotate_Image(Graphics pe, Image img, Point ptImg, Point ptRot, float angle_deg, float scaleFactor)
        {
            double beta = 0;    // Angle between the Horizontal line and the line (Left upper corner - Rotation point)
            double d = 0;       // Distance between Left upper corner and Rotation point)		
            float deltaX = 0;   // X componant of the corrected translation
            float deltaY = 0;   // Y componant of the corrected translation

            double angle_rad = (angle_deg * Math.PI / 180);
            // Compute the correction translation coeff
            if (ptImg != ptRot)
            {
                //
                if (ptRot.X != 0)
                {
                    beta = Math.Atan((double)ptRot.Y / (double)ptRot.X);
                }

                d = Math.Sqrt((ptRot.X * ptRot.X) + (ptRot.Y * ptRot.Y));

                // Computed offset
                deltaX = (float)(d * (Math.Cos(angle_rad - beta) - Math.Cos(angle_rad) * Math.Cos(angle_rad + beta) - Math.Sin(angle_rad) * Math.Sin(angle_rad + beta)));
                deltaY = (float)(d * (Math.Sin(beta - angle_rad) + Math.Sin(angle_rad) * Math.Cos(angle_rad + beta) - Math.Cos(angle_rad) * Math.Sin(angle_rad + beta)));
            }

            // Rotate image support
            pe.RotateTransform(angle_deg);

            // Dispay image
            pe.DrawImage(img, (ptImg.X + deltaX) * scaleFactor, (ptImg.Y + deltaY) * scaleFactor, img.Width * scaleFactor, img.Height * scaleFactor);

            // Put image support as found
            pe.RotateTransform(-angle_deg);
        }
    }
}
