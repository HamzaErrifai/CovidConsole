using CovidConsole.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CovidConsole.View
{
    public partial class VaccinationView : Form
    {
        private Panel NavBar;
        private Label label2;
        private Panel panel1;
        private TextBox typeTxt;
        private Label label6;
        private Label label4;
        private Label label7;
        private ComboBox idTestBox;
        private Button EnregistrerBtn;
        private Button SupprimerBtn;
        private Button ModifierBtn;
        private Button AjouterBtn;
        private Button AnnulerBtn;
        private string currentAction = "";
        private List<Button> lCtrlBtns;
        private List<TextBox> textBoxes;
        private List<Vaccination> vaccinations;
        private ComboBox typeBox;
        private Label msglbl;
        private DateTimePicker datePick;
        private Vaccination currentVaccination;
        private Button BackBtn;
        private Label label8;
        private Label patientLbl;
        private string cinC = "";

        public VaccinationView(string cinC)
        {
            InitializeComponent();
            try
            {
                this.cinC = cinC;
                lCtrlBtns = new List<Button> { AjouterBtn, ModifierBtn, SupprimerBtn };
                textBoxes = new List<TextBox> { typeTxt };
                //to initate Vaccination
                fillHistVaccination();
                setAllOptBtnsTo(false);
            }
            catch (Exception e)
            {
                ShowError(e.Message);
            }
        }

        private void InitializeComponent()
        {
            this.NavBar = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.patientLbl = new System.Windows.Forms.Label();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.msglbl = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.AnnulerBtn = new System.Windows.Forms.Button();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.idTestBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.NavBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(201)))));
            this.NavBar.Controls.Add(this.BackBtn);
            this.NavBar.Controls.Add(this.label2);
            this.NavBar.Location = new System.Drawing.Point(0, 1);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1107, 70);
            this.NavBar.TabIndex = 1;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(22, 11);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(129, 41);
            this.BackBtn.TabIndex = 24;
            this.BackBtn.Text = "Revenir";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Historique de vaccination";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.patientLbl);
            this.panel1.Controls.Add(this.datePick);
            this.panel1.Controls.Add(this.msglbl);
            this.panel1.Controls.Add(this.typeBox);
            this.panel1.Controls.Add(this.AnnulerBtn);
            this.panel1.Controls.Add(this.EnregistrerBtn);
            this.panel1.Controls.Add(this.SupprimerBtn);
            this.panel1.Controls.Add(this.ModifierBtn);
            this.panel1.Controls.Add(this.AjouterBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.idTestBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.typeTxt);
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 503);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Patient :";
            // 
            // patientLbl
            // 
            this.patientLbl.AutoSize = true;
            this.patientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLbl.Location = new System.Drawing.Point(418, 59);
            this.patientLbl.Name = "patientLbl";
            this.patientLbl.Size = new System.Drawing.Size(35, 24);
            this.patientLbl.TabIndex = 24;
            this.patientLbl.Text = "cin";
            // 
            // datePick
            // 
            this.datePick.Enabled = false;
            this.datePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick.Location = new System.Drawing.Point(421, 264);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(258, 27);
            this.datePick.TabIndex = 22;
            // 
            // msglbl
            // 
            this.msglbl.AutoSize = true;
            this.msglbl.BackColor = System.Drawing.SystemColors.Control;
            this.msglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msglbl.ForeColor = System.Drawing.Color.Red;
            this.msglbl.Location = new System.Drawing.Point(59, 328);
            this.msglbl.Name = "msglbl";
            this.msglbl.Size = new System.Drawing.Size(0, 24);
            this.msglbl.TabIndex = 21;
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(421, 182);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(258, 32);
            this.typeBox.TabIndex = 20;
            this.typeBox.Visible = false;
            // 
            // AnnulerBtn
            // 
            this.AnnulerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AnnulerBtn.Location = new System.Drawing.Point(663, 400);
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
            this.EnregistrerBtn.Location = new System.Drawing.Point(497, 400);
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
            this.SupprimerBtn.Location = new System.Drawing.Point(314, 400);
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
            this.ModifierBtn.Location = new System.Drawing.Point(168, 400);
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
            this.AjouterBtn.Location = new System.Drawing.Point(22, 400);
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
            this.label7.Location = new System.Drawing.Point(147, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Id Vaccination :";
            // 
            // idTestBox
            // 
            this.idTestBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idTestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.idTestBox.FormattingEnabled = true;
            this.idTestBox.Location = new System.Drawing.Point(421, 112);
            this.idTestBox.Name = "idTestBox";
            this.idTestBox.Size = new System.Drawing.Size(258, 32);
            this.idTestBox.TabIndex = 11;
            this.idTestBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(147, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date de vaccination :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type :";
            // 
            // typeTxt
            // 
            this.typeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTxt.Location = new System.Drawing.Point(421, 182);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.ReadOnly = true;
            this.typeTxt.Size = new System.Drawing.Size(258, 29);
            this.typeTxt.TabIndex = 2;
            // 
            // VaccinationView
            // 
            this.ClientSize = new System.Drawing.Size(815, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "VaccinationView";
            this.Text = "Historique de vaccinations";
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private bool textBoxesAreEmpty()
        {
            return typeBox.Text.Trim() == "";
        }

        private void fillIdBox(bool yes)
        {
            //to fill or unFill the cinbox
            if (yes)
            {
                idTestBox.DataSource = vaccinations;
                idTestBox.DisplayMember = "_idTest";
                idTestBox.Enabled = true;
            }
            else
            {
                idTestBox.DataSource = null;
                if (currentAction == "modifier")
                    idTestBox.Text = currentVaccination.getId().ToString();
                idTestBox.Enabled = false;
            }
        }

        private void fillHistVaccination()
        {
            vaccinations = Vaccination.getAll(cinC);
            patientLbl.Text = cinC;
            // at the start the selected citoyen is the first from the list
            if (vaccinations.Count > 0)
                currentVaccination = vaccinations[0];
            else
            {
                disableAllCtrlBtns();
                setAllOptBtnsTo(false);
                AjouterBtn.Enabled = true;
            }
            fillIdBox(vaccinations.Count > 0);
        }

        private void clearTextBoxes()
        {
            foreach (var txtbx in textBoxes)
                txtbx.Text = "";
            idTestBox.Text = "";
        }

        private void showComboboxes(bool yes)
        {
            if (yes)
            {
                //typeBox
                typeBox.DataSource = Vaccination.possibleTypes;
                typeBox.DisplayMember = "possibleTypes";
                typeBox.Visible = true;
                typeTxt.Visible = false;
            }
            else
            {
                //typeBox
                typeBox.Visible = false;
                typeTxt.Visible = true;
            }
        }

        private void ShowError(string msg)
        {
            Timer timer1 = new Timer
            {
                Interval = 5000 // 5 seconds
            };
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
            msglbl.Text = msg;

        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            msglbl.Text = "";
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
                nowBtn.Enabled = false;
            AnnulerBtn.Enabled = true;
            EnregistrerBtn.Enabled = true;
        }

        private void changeReadOnlyTxtBoxsTo(bool yes)
        {
            foreach (TextBox textBox in textBoxes)
                textBox.ReadOnly = yes;
        }

        private void setTextBoxes(int i)
        {
            if (idTestBox.SelectedIndex > -1)
            {
                currentVaccination = vaccinations[i];
                datePick.Value = currentVaccination.getDate();
                typeTxt.Text = currentVaccination.getType();

            }
        }

        private void deleteCitoyen()
        {
            DialogResult result1 = MessageBox.Show("Test Number: " + 
                currentVaccination.getId().ToString(), "Vous êtes sure de suprimer cette élément ?", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                currentVaccination.delete();
            }
        }

        private void modifyCitoyen() => currentVaccination.updateAll(typeBox.Text.Trim());

        private void addCitoyen()
        {
            if (currentVaccination == null)
            {
                Vaccination tempTest = new Vaccination(cinC, typeBox.Text.Trim());
                currentVaccination = tempTest;
            }
            else
                currentVaccination.add(cinC, typeBox.Text.Trim());
        }

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            switch (currentAction.ToLower())
            {
                case "ajouter":
                    if (!textBoxesAreEmpty())
                    {
                        addCitoyen();
                        activateAllCtrlButtons();
                    }
                    else
                    {
                        ShowError("Il faut remplir tous les champs");
                    }
                    break;
                case "modifier":
                    if (!textBoxesAreEmpty())
                    {
                        modifyCitoyen();
                        activateAllCtrlButtons();
                    }
                    else
                    {
                        ShowError("Il faut remplir tous les champs");
                    }
                    break;
                case "supprimer":
                    deleteCitoyen();
                    activateAllCtrlButtons();
                    break;
                default:
                    break;

            }

            fillHistVaccination();
            currentAction = "";
            changeReadOnlyTxtBoxsTo(true);
            setTextBoxes(idTestBox.SelectedIndex);
            setAllOptBtnsTo(false);
            activateAllCtrlButtons();
            AjouterBtn.Enabled = true;
            fillIdBox(true);
            showComboboxes(false);

        }

        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            currentAction = "";
            changeReadOnlyTxtBoxsTo(true);
            setTextBoxes(idTestBox.SelectedIndex);
            setAllOptBtnsTo(false);
            activateAllCtrlButtons();
            AjouterBtn.Enabled = true;
            fillIdBox(true);
            showComboboxes(false);
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {

            disableAllCtrlBtns();
            changeReadOnlyTxtBoxsTo(false);
            clearTextBoxes();
            currentAction = "Ajouter";
            fillIdBox(false);
            showComboboxes(true);
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            disableAllCtrlBtns();
            changeReadOnlyTxtBoxsTo(false);
            currentAction = "Modifier";
            fillIdBox(false);
            showComboboxes(true);
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
                switch (MessageBox.Show(this, "Vous êtes sùr de quiter le programme ?",
                    "Vous allez perdre les données non sauvgardées", MessageBoxButtons.YesNo))
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
            setTextBoxes(idTestBox.SelectedIndex);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Accueil().ShowDialog();
            this.Close();
        }
    }
}
