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


namespace GroundStation_Mahsa
{
    public partial class GroundStation_Form : Form
    {
        public GroundStation_Form()
        {
            InitializeComponent();
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
        }

        private void CONNECT_btn_Click(object sender, EventArgs e)
        {
            PointLatLng pos1 = new PointLatLng(35.971684, 51.589759);

            GMapOverlay points_ = new GMapOverlay(GMap1,"pointCollection");
            GMapMarker marker = new GMapMarkerGoogleRed(pos1);
            points_.Markers.Add(marker);

            GMap1.Overlays.Add(points_);
        }
    }
}
