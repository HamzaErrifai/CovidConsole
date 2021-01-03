using CovidConsole.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CovidConsole
{
    //TODO: Zoom at the map
    //TODO: Show a cursor on the map

    public partial class MapView : Form
    {
        private Panel NavBar;
        private Label label2;
        private Button button1;
        private Panel panel1;

        public MapView()
        {
            InitializeComponent();
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            geoMap.Source = $"C:\\testCsharp\\World.xml";
            panel1.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;

        }

        private void InitializeComponent()
        {
            this.NavBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(201)))));
            this.NavBar.Controls.Add(this.button1);
            this.NavBar.Controls.Add(this.label2);
            this.NavBar.Location = new System.Drawing.Point(0, 1);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1107, 70);
            this.NavBar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestion des patients Covid";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 682);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Revenir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MapView
            // 
            this.ClientSize = new System.Drawing.Size(1107, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MapView";
            this.Text = "MapView";
            this.Load += new System.EventHandler(this.MapView_Load);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.ResumeLayout(false);

        }

        private void MapView_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            geoMap.Source = $"C:\\testCsharp\\World.xml";
            panel1.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Accueil().ShowDialog();
            this.Close();
        }
    }
}
