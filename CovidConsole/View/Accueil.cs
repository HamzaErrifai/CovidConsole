using CovidConsole.Controller;
using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CovidConsole
{
    //TODO: Make it responsive
    //TODO: Know more about OsmSharp to use maps
    public partial class Accueil : Form
    {
        private Panel NavBar;
        private Label label2;
        private Admin admin = new Admin();

        public Accueil()
        {
            InitializeComponent();
            try
            {
                //https://www.google.com/maps/search/?api=1&query=47.5951518,-122.3316393
                //StringBuilder location = new StringBuilder("https://www.openstreetmap.org/#map=6/32.278/-4.878");
                //string urlStr = location.ToString();
                //webBrowser1.Navigate(urlStr);
                loadMap();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void loadMap()
        {
            gMapControl1.MapProvider = GMapProviders.OpenStreetMap;
            double lat = 47.5951518;
            double lon = -122.3316393;
            gMapControl1.Position = new PointLatLng(lat, lon);

        }

        private void InitializeComponent()
        {
            this.NavBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(201)))));
            this.NavBar.Controls.Add(this.label2);
            this.NavBar.Location = new System.Drawing.Point(0, 1);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1257, 70);
            this.NavBar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(291, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(672, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestion des patients Covid";
            // 
            // Accueil
            // 
            this.ClientSize = new System.Drawing.Size(1257, 759);
            this.Controls.Add(this.NavBar);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.ResumeLayout(false);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
