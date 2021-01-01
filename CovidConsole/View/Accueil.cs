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
        private Label label1;
        private Label CcLbl;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private ComboBox comboBox1;
        private Button EnregistrerBtn;
        private Button SupprimerBtn;
        private Button ModifierBtn;
        private Button AjouterBtn;
        private Button AnnulerBtn;
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
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CcLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DobTxt = new System.Windows.Forms.TextBox();
            this.StatusTxt = new System.Windows.Forms.TextBox();
            this.SexeTxt = new System.Windows.Forms.TextBox();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.AnnulerBtn = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.AnnulerBtn);
            this.panel1.Controls.Add(this.EnregistrerBtn);
            this.panel1.Controls.Add(this.SupprimerBtn);
            this.panel1.Controls.Add(this.ModifierBtn);
            this.panel1.Controls.Add(this.AjouterBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CcLbl);
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
            // EnregistrerBtn
            // 
            this.EnregistrerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.EnregistrerBtn.Location = new System.Drawing.Point(684, 554);
            this.EnregistrerBtn.Name = "EnregistrerBtn";
            this.EnregistrerBtn.Size = new System.Drawing.Size(140, 51);
            this.EnregistrerBtn.TabIndex = 16;
            this.EnregistrerBtn.Text = "Enregistrer";
            this.EnregistrerBtn.UseVisualStyleBackColor = true;
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SupprimerBtn.Location = new System.Drawing.Point(394, 554);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(140, 51);
            this.SupprimerBtn.TabIndex = 15;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = true;
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ModifierBtn.Location = new System.Drawing.Point(232, 554);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(140, 51);
            this.ModifierBtn.TabIndex = 14;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = true;
            // 
            // AjouterBtn
            // 
            this.AjouterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AjouterBtn.Location = new System.Drawing.Point(70, 554);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(140, 51);
            this.AjouterBtn.TabIndex = 13;
            this.AjouterBtn.Text = "Ajouter";
            this.AjouterBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "CIN :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(338, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 37);
            this.comboBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date de naissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sexe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prenom :";
            // 
            // CcLbl
            // 
            this.CcLbl.AutoSize = true;
            this.CcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CcLbl.Location = new System.Drawing.Point(695, 98);
            this.CcLbl.Name = "CcLbl";
            this.CcLbl.Size = new System.Drawing.Size(183, 31);
            this.CcLbl.TabIndex = 0;
            this.CcLbl.Text = "Code couleur:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(701, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 254);
            this.panel2.TabIndex = 5;
            // 
            // DobTxt
            // 
            this.DobTxt.Enabled = false;
            this.DobTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DobTxt.Location = new System.Drawing.Point(338, 408);
            this.DobTxt.Name = "DobTxt";
            this.DobTxt.Size = new System.Drawing.Size(258, 34);
            this.DobTxt.TabIndex = 4;
            // 
            // StatusTxt
            // 
            this.StatusTxt.Enabled = false;
            this.StatusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTxt.Location = new System.Drawing.Point(338, 339);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(258, 34);
            this.StatusTxt.TabIndex = 3;
            // 
            // SexeTxt
            // 
            this.SexeTxt.Enabled = false;
            this.SexeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexeTxt.Location = new System.Drawing.Point(338, 270);
            this.SexeTxt.Name = "SexeTxt";
            this.SexeTxt.Size = new System.Drawing.Size(258, 34);
            this.SexeTxt.TabIndex = 2;
            // 
            // LnameTxt
            // 
            this.LnameTxt.Enabled = false;
            this.LnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameTxt.Location = new System.Drawing.Point(338, 201);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.Size = new System.Drawing.Size(258, 34);
            this.LnameTxt.TabIndex = 1;
            // 
            // NameTxt
            // 
            this.NameTxt.Enabled = false;
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(338, 132);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(258, 34);
            this.NameTxt.TabIndex = 0;
            // 
            // AnnulerBtn
            // 
            this.AnnulerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AnnulerBtn.Location = new System.Drawing.Point(850, 554);
            this.AnnulerBtn.Name = "AnnulerBtn";
            this.AnnulerBtn.Size = new System.Drawing.Size(140, 51);
            this.AnnulerBtn.TabIndex = 17;
            this.AnnulerBtn.Text = "Annuler";
            this.AnnulerBtn.UseVisualStyleBackColor = true;
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
