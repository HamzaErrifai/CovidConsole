using CovidConsole.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CovidConsole
{   //TODO: Know more about OsmSharp to use maps
    //todo: 
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
        private Panel colorPanel;
        private Label label1;
        private Label CcLbl;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private ComboBox cinBox;
        private Button EnregistrerBtn;
        private Button SupprimerBtn;
        private Button ModifierBtn;
        private Button AjouterBtn;
        private Button AnnulerBtn;
        private string currentAction = "";
        private TextBox DobTxt;
        private List<Button> lCtrlBtns;
        private List<TextBox> textBoxes;
        private List<Citoyen> citoyens;
        private Label nbPatTxt;
        private Label label8;
        private Citoyen currentCitoyen;

        public Accueil()
        {
            InitializeComponent();
            try
            {
                //https://www.google.com/maps/search/?api=1&query=47.5951518,-122.3316393
                //StringBuilder location = new StringBuilder("https://www.openstreetmap.org/#map=6/32.278/-4.878");
                //string urlStr = location.ToString();
                //webBrowser1.Navigate(urlStr);
                citoyens = Citoyen.getAll();
                currentCitoyen = citoyens[0]; // at the start the selected citoyen is the first from the list
                lCtrlBtns = new List<Button> { AjouterBtn, ModifierBtn, SupprimerBtn };
                textBoxes = new List<TextBox> { NameTxt, LnameTxt, SexeTxt, StatusTxt, DobTxt };
                cinBox.DataSource = citoyens;
                cinBox.DisplayMember = "_cin";

                nbPatTxt.Text = citoyens.Count.ToString();

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
            this.AnnulerBtn = new System.Windows.Forms.Button();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cinBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CcLbl = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.DobTxt = new System.Windows.Forms.TextBox();
            this.StatusTxt = new System.Windows.Forms.TextBox();
            this.SexeTxt = new System.Windows.Forms.TextBox();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nbPatTxt = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(243, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestion des patients Covid";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nbPatTxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.AnnulerBtn);
            this.panel1.Controls.Add(this.EnregistrerBtn);
            this.panel1.Controls.Add(this.SupprimerBtn);
            this.panel1.Controls.Add(this.ModifierBtn);
            this.panel1.Controls.Add(this.AjouterBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cinBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CcLbl);
            this.panel1.Controls.Add(this.colorPanel);
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
            // AnnulerBtn
            // 
            this.AnnulerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AnnulerBtn.Location = new System.Drawing.Point(849, 578);
            this.AnnulerBtn.Name = "AnnulerBtn";
            this.AnnulerBtn.Size = new System.Drawing.Size(140, 44);
            this.AnnulerBtn.TabIndex = 17;
            this.AnnulerBtn.Text = "Annuler";
            this.AnnulerBtn.UseVisualStyleBackColor = true;
            this.AnnulerBtn.Click += new System.EventHandler(this.AnnulerBtn_Click);
            // 
            // EnregistrerBtn
            // 
            this.EnregistrerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.EnregistrerBtn.Location = new System.Drawing.Point(683, 578);
            this.EnregistrerBtn.Name = "EnregistrerBtn";
            this.EnregistrerBtn.Size = new System.Drawing.Size(140, 44);
            this.EnregistrerBtn.TabIndex = 16;
            this.EnregistrerBtn.Text = "Enregistrer";
            this.EnregistrerBtn.UseVisualStyleBackColor = true;
            this.EnregistrerBtn.Click += new System.EventHandler(this.EnregistrerBtn_Click);
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SupprimerBtn.Location = new System.Drawing.Point(393, 578);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(140, 44);
            this.SupprimerBtn.TabIndex = 15;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = true;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ModifierBtn.Location = new System.Drawing.Point(231, 578);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(140, 44);
            this.ModifierBtn.TabIndex = 14;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = true;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // AjouterBtn
            // 
            this.AjouterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AjouterBtn.Location = new System.Drawing.Point(69, 578);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(140, 44);
            this.AjouterBtn.TabIndex = 13;
            this.AjouterBtn.Text = "Ajouter";
            this.AjouterBtn.UseVisualStyleBackColor = true;
            this.AjouterBtn.Click += new System.EventHandler(this.AjouterBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "CIN :";
            // 
            // cinBox
            // 
            this.cinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cinBox.FormattingEnabled = true;
            this.cinBox.Location = new System.Drawing.Point(338, 62);
            this.cinBox.Name = "cinBox";
            this.cinBox.Size = new System.Drawing.Size(258, 32);
            this.cinBox.TabIndex = 11;
            this.cinBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date de naissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sexe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prenom :";
            // 
            // CcLbl
            // 
            this.CcLbl.AutoSize = true;
            this.CcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CcLbl.Location = new System.Drawing.Point(695, 98);
            this.CcLbl.Name = "CcLbl";
            this.CcLbl.Size = new System.Drawing.Size(147, 26);
            this.CcLbl.TabIndex = 0;
            this.CcLbl.Text = "Code couleur:";
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Gray;
            this.colorPanel.Location = new System.Drawing.Point(701, 132);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(269, 254);
            this.colorPanel.TabIndex = 5;
            // 
            // DobTxt
            // 
            this.DobTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DobTxt.Location = new System.Drawing.Point(338, 408);
            this.DobTxt.Name = "DobTxt";
            this.DobTxt.ReadOnly = true;
            this.DobTxt.Size = new System.Drawing.Size(258, 29);
            this.DobTxt.TabIndex = 4;
            // 
            // StatusTxt
            // 
            this.StatusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTxt.Location = new System.Drawing.Point(338, 339);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.ReadOnly = true;
            this.StatusTxt.Size = new System.Drawing.Size(258, 29);
            this.StatusTxt.TabIndex = 3;
            // 
            // SexeTxt
            // 
            this.SexeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexeTxt.Location = new System.Drawing.Point(338, 270);
            this.SexeTxt.Name = "SexeTxt";
            this.SexeTxt.ReadOnly = true;
            this.SexeTxt.Size = new System.Drawing.Size(258, 29);
            this.SexeTxt.TabIndex = 2;
            // 
            // LnameTxt
            // 
            this.LnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameTxt.Location = new System.Drawing.Point(338, 201);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.ReadOnly = true;
            this.LnameTxt.Size = new System.Drawing.Size(258, 29);
            this.LnameTxt.TabIndex = 1;
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(338, 132);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.ReadOnly = true;
            this.NameTxt.Size = new System.Drawing.Size(258, 29);
            this.NameTxt.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre de Patients: ";
            // 
            // nbPatTxt
            // 
            this.nbPatTxt.AutoSize = true;
            this.nbPatTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPatTxt.Location = new System.Drawing.Point(311, 14);
            this.nbPatTxt.Name = "nbPatTxt";
            this.nbPatTxt.Size = new System.Drawing.Size(24, 26);
            this.nbPatTxt.TabIndex = 18;
            this.nbPatTxt.Text = "0";
            // 
            // Accueil
            // 
            this.ClientSize = new System.Drawing.Size(1107, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Accueil_FormClosing);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private bool textBoxesAreEmpty()
        {
            foreach (TextBox txtbx in textBoxes)
            {
                if (txtbx.Text.Trim() != "")
                    return false;
            }
            return true;
        }
        private void clearTextBoxes()
        {
            foreach (var txtbx in textBoxes)
            {
                txtbx.Text = "";
            }
            cinBox.Text = "";
        }


        private void activateAllCtrlButtons()
        {
            foreach (Button nowBtn in lCtrlBtns)
            {
                nowBtn.Enabled = true;
            }
        }

        private void setAllOptBtnsTo(bool yes)
        {
            AnnulerBtn.Enabled = yes;
            EnregistrerBtn.Enabled = yes;
        }

        private void disableAllCtrlBtns()
        {
            foreach (Button nowBtn in lCtrlBtns)
            {
                nowBtn.Enabled = false;
                AnnulerBtn.Enabled = true;
                EnregistrerBtn.Enabled = true;
            }
        }

        private void changeReadOnlyTxtBoxsTo(bool yes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.ReadOnly = yes;
            }
        }

        private void setTextBoxes(int i)
        {
            currentCitoyen = citoyens[i];
            NameTxt.Text = currentCitoyen.getPrenom();
            LnameTxt.Text = currentCitoyen.getNom();
            SexeTxt.Text = currentCitoyen.getSexe();
            StatusTxt.Text = currentCitoyen.getstatus();
            DobTxt.Text = currentCitoyen.getdateDeNaissance().ToString();
            colorPanel.BackColor = Color.FromName(currentCitoyen.getCodeCouleur());
        }

        private void deleteCitoyen()
        {
            DialogResult result1 = MessageBox.Show(currentCitoyen.getFullName(), "Vous êtes sure de suprimer cette élément ?", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                currentCitoyen.delete();
            }
        }

        private void modifyCitoyen()
        {
            currentCitoyen.generateCodeCouleur();
            currentCitoyen.updateAll(cinBox.Text, LnameTxt.Text, NameTxt.Text, SexeTxt.Text, currentCitoyen.getCodeCouleur(), StatusTxt.Text, Convert.ToDateTime(DobTxt));
        }
        private void addCitoyen()
        {
            currentCitoyen.add(cinBox.Text, LnameTxt.Text, NameTxt.Text, SexeTxt.Text, currentCitoyen.getCodeCouleur(), StatusTxt.Text, Convert.ToDateTime(DobTxt.Text));
        }

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            switch (currentAction)
            {
                case "Ajouter":
                    if (!textBoxesAreEmpty())
                    {
                        addCitoyen();
                        activateAllCtrlButtons();
                    }
                    break;
                case "Modifier":
                    if (!textBoxesAreEmpty())
                    {
                        modifyCitoyen();
                        activateAllCtrlButtons();
                    }
                    break;
                case "Supprimer":
                    if (!textBoxesAreEmpty())
                    {
                        deleteCitoyen();
                        activateAllCtrlButtons();
                    }
                    break;
                default:
                    break;

            }
            setAllOptBtnsTo(false);
            AjouterBtn.Enabled = true;
            currentAction = "";
            changeReadOnlyTxtBoxsTo(true);
            setTextBoxes(0);

        }

        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            currentAction = "";
            changeReadOnlyTxtBoxsTo(true);
            setTextBoxes(cinBox.SelectedIndex);
            setAllOptBtnsTo(false);
            activateAllCtrlButtons();
            AjouterBtn.Enabled = true;
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            disableAllCtrlBtns();
            changeReadOnlyTxtBoxsTo(false);
            clearTextBoxes();
            currentAction = "Ajouter";
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            disableAllCtrlBtns();
            changeReadOnlyTxtBoxsTo(false);
            currentAction = "Modifier";
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            disableAllCtrlBtns();
            changeReadOnlyTxtBoxsTo(true);
            currentAction = "Supprimer";
        }

        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentAction != "")
                switch (MessageBox.Show(this, "Vous êtes sùr de quiter le programme ?", "Vous allez perdre les données non sauvgardées", MessageBoxButtons.YesNo))
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            setTextBoxes(cinBox.SelectedIndex);
        }


    }
}
