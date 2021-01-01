using CovidConsole.Controller;
using System;
using System.Windows.Forms;

namespace CovidConsole
{
    //TODO: Make it responsive
    //TODO: Know more about OsmSharp to use maps
    //TODO: https://www.youtube.com/watch?v=fzgKmHzBWic
    public partial class Accueil : Form
    {
        private Panel NavBar;
        private Label label2;
        private Panel panel1;
        private TextBox SexeTxt;
        private TextBox LnameTxt;
        private TextBox NameTxt;
        private TextBox StatusTxt;
        private Panel panel2;
        private TextBox DobTxt;
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
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void InitializeComponent()
        {
            this.NavBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.SexeTxt = new System.Windows.Forms.TextBox();
            this.StatusTxt = new System.Windows.Forms.TextBox();
            this.DobTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NavBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(201)))));
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
            this.label2.Location = new System.Drawing.Point(164, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(736, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestion des patients Covid";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DobTxt);
            this.panel1.Controls.Add(this.StatusTxt);
            this.panel1.Controls.Add(this.SexeTxt);
            this.panel1.Controls.Add(this.LnameTxt);
            this.panel1.Controls.Add(this.NameTxt);
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 682);
            this.panel1.TabIndex = 2;
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(106, 112);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(215, 34);
            this.NameTxt.TabIndex = 0;
            // 
            // LnameTxt
            // 
            this.LnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameTxt.Location = new System.Drawing.Point(106, 180);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.Size = new System.Drawing.Size(215, 34);
            this.LnameTxt.TabIndex = 1;
            // 
            // SexeTxt
            // 
            this.SexeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexeTxt.Location = new System.Drawing.Point(106, 255);
            this.SexeTxt.Name = "SexeTxt";
            this.SexeTxt.Size = new System.Drawing.Size(215, 34);
            this.SexeTxt.TabIndex = 2;
            // 
            // StatusTxt
            // 
            this.StatusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTxt.Location = new System.Drawing.Point(106, 328);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(215, 34);
            this.StatusTxt.TabIndex = 3;
            // 
            // DobTxt
            // 
            this.DobTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DobTxt.Location = new System.Drawing.Point(106, 401);
            this.DobTxt.Name = "DobTxt";
            this.DobTxt.Size = new System.Drawing.Size(215, 34);
            this.DobTxt.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(687, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 254);
            this.panel2.TabIndex = 5;
            // 
            // Accueil
            // 
            this.ClientSize = new System.Drawing.Size(1107, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavBar);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
