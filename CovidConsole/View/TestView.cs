using CovidConsole.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CovidConsole
{
    //TODO: combo box id should be readonly
    public partial class TestView : Form
    {
        private Panel NavBar;
        private Label label2;
        private Panel panel1;
        private TextBox typeTxt;
        private TextBox resultatTxt;
        private TextBox hasSymptomsTxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
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
        private List<Test> tests;
        private ComboBox hasSymptomsBox;
        private ComboBox typeBox;
        private Label msglbl;
        private DateTimePicker datePick;
        private Test currentTest;
        private ComboBox resulatBox;
        private Button BackBtn;
        private Label label8;
        private Label patientLbl;
        private string cinC = "";

        public TestView(string cinC)
        {
            InitializeComponent();
            try
            {
                //to initate citoyens
                this.cinC = cinC;
                lCtrlBtns = new List<Button> { AjouterBtn, ModifierBtn, SupprimerBtn };
                textBoxes = new List<TextBox> { resultatTxt, typeTxt, hasSymptomsTxt };
                fillTests();
                setAllOptBtnsTo(false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void InitializeComponent()
        {
            this.NavBar = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resulatBox = new System.Windows.Forms.ComboBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.msglbl = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.hasSymptomsBox = new System.Windows.Forms.ComboBox();
            this.AnnulerBtn = new System.Windows.Forms.Button();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.idTestBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hasSymptomsTxt = new System.Windows.Forms.TextBox();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.resultatTxt = new System.Windows.Forms.TextBox();
            this.patientLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(367, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Les Test Covid";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.patientLbl);
            this.panel1.Controls.Add(this.resulatBox);
            this.panel1.Controls.Add(this.datePick);
            this.panel1.Controls.Add(this.msglbl);
            this.panel1.Controls.Add(this.typeBox);
            this.panel1.Controls.Add(this.hasSymptomsBox);
            this.panel1.Controls.Add(this.AnnulerBtn);
            this.panel1.Controls.Add(this.EnregistrerBtn);
            this.panel1.Controls.Add(this.SupprimerBtn);
            this.panel1.Controls.Add(this.ModifierBtn);
            this.panel1.Controls.Add(this.AjouterBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.idTestBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.hasSymptomsTxt);
            this.panel1.Controls.Add(this.typeTxt);
            this.panel1.Controls.Add(this.resultatTxt);
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 682);
            this.panel1.TabIndex = 2;
            // 
            // resulatBox
            // 
            this.resulatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulatBox.FormattingEnabled = true;
            this.resulatBox.Location = new System.Drawing.Point(393, 186);
            this.resulatBox.Name = "resulatBox";
            this.resulatBox.Size = new System.Drawing.Size(258, 32);
            this.resulatBox.TabIndex = 23;
            this.resulatBox.Visible = false;
            // 
            // datePick
            // 
            this.datePick.Enabled = false;
            this.datePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick.Location = new System.Drawing.Point(393, 393);
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
            this.msglbl.Location = new System.Drawing.Point(66, 506);
            this.msglbl.Name = "msglbl";
            this.msglbl.Size = new System.Drawing.Size(0, 24);
            this.msglbl.TabIndex = 21;
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(393, 255);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(258, 32);
            this.typeBox.TabIndex = 20;
            this.typeBox.Visible = false;
            // 
            // hasSymptomsBox
            // 
            this.hasSymptomsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasSymptomsBox.FormattingEnabled = true;
            this.hasSymptomsBox.Location = new System.Drawing.Point(393, 321);
            this.hasSymptomsBox.Name = "hasSymptomsBox";
            this.hasSymptomsBox.Size = new System.Drawing.Size(258, 32);
            this.hasSymptomsBox.TabIndex = 19;
            this.hasSymptomsBox.Visible = false;
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
            this.label7.Location = new System.Drawing.Point(119, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Id Test :";
            // 
            // idTestBox
            // 
            this.idTestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.idTestBox.FormattingEnabled = true;
            this.idTestBox.Location = new System.Drawing.Point(393, 108);
            this.idTestBox.Name = "idTestBox";
            this.idTestBox.Size = new System.Drawing.Size(258, 32);
            this.idTestBox.TabIndex = 11;
            this.idTestBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date de naissance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "A des symptoms ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultat :";
            // 
            // hasSymptomsTxt
            // 
            this.hasSymptomsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasSymptomsTxt.Location = new System.Drawing.Point(393, 321);
            this.hasSymptomsTxt.Name = "hasSymptomsTxt";
            this.hasSymptomsTxt.ReadOnly = true;
            this.hasSymptomsTxt.Size = new System.Drawing.Size(258, 29);
            this.hasSymptomsTxt.TabIndex = 3;
            // 
            // typeTxt
            // 
            this.typeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTxt.Location = new System.Drawing.Point(393, 255);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.ReadOnly = true;
            this.typeTxt.Size = new System.Drawing.Size(258, 29);
            this.typeTxt.TabIndex = 2;
            // 
            // resultatTxt
            // 
            this.resultatTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultatTxt.Location = new System.Drawing.Point(393, 186);
            this.resultatTxt.Name = "resultatTxt";
            this.resultatTxt.ReadOnly = true;
            this.resultatTxt.Size = new System.Drawing.Size(258, 29);
            this.resultatTxt.TabIndex = 1;
            // 
            // patientLbl
            // 
            this.patientLbl.AutoSize = true;
            this.patientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLbl.Location = new System.Drawing.Point(390, 55);
            this.patientLbl.Name = "patientLbl";
            this.patientLbl.Size = new System.Drawing.Size(35, 24);
            this.patientLbl.TabIndex = 24;
            this.patientLbl.Text = "cin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(121, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Patient :";
            // 
            // TestView
            // 
            this.ClientSize = new System.Drawing.Size(1107, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TestView";
            this.Text = "TEST";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Accueil_FormClosing);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private bool textBoxesAreEmpty()
        {
            return resulatBox.Text.Trim() == "" || typeBox.Text.Trim() == "" || hasSymptomsBox.Text.Trim() == "";
        }

        private void fillIdBox(bool yes)
        {
            //to fill or unFill the cinbox
            if (yes)
            {
                idTestBox.DataSource = tests;
                idTestBox.DisplayMember = "_idTest";
                idTestBox.Enabled = true;
            }
            else
            {
                idTestBox.DataSource = null;
                if (currentAction == "modifier")
                    idTestBox.Text = currentTest.getIdTest().ToString();
                idTestBox.Enabled = false;
            }
        }

        private void fillTests()
        {
            tests = Test.getAll(cinC);
            patientLbl.Text = cinC;
            // at the start the selected citoyen is the first from the list
            if (tests.Count > 0)
                currentTest = tests[0];
            else
            {
                disableAllCtrlBtns();
                setAllOptBtnsTo(false);
                AjouterBtn.Enabled = true;
            }
            fillIdBox(tests.Count > 0);
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
                //hasSymptomsBox
                hasSymptomsBox.DataSource = Test.possibleSymptoms;
                hasSymptomsBox.DisplayMember = "possibleSymptoms";
                hasSymptomsBox.Visible = true;
                hasSymptomsTxt.Visible = false;
                //typeBox
                typeBox.DataSource = Test.possibleTypes;
                typeBox.DisplayMember = "possibleTypes";
                typeBox.Visible = true;
                typeTxt.Visible = false;
                //resulatBox
                resulatBox.DataSource = Test.possibleResultat;
                resulatBox.DisplayMember = "possibleResultat";
                resulatBox.Visible = true;
                resultatTxt.Visible = false;

            }
            else
            {
                //hasSymptomsBox
                hasSymptomsBox.Visible = false;
                hasSymptomsTxt.Visible = true;
                //typeBox
                typeBox.Visible = false;
                typeTxt.Visible = true;
                //resulatBox
                resulatBox.Visible = false;
                resultatTxt.Visible = true;
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
            datePick.Enabled = !yes;
        }

        private void setTextBoxes(int i)
        {
            if (idTestBox.SelectedIndex > -1)
            {
                currentTest = tests[i];
                resultatTxt.Text = currentTest.getResultat();
                hasSymptomsTxt.Text = (currentTest.getHasSymptoms()) ? "oui" : "non";
                datePick.Value = currentTest.getDate();
                typeTxt.Text = currentTest.getType();

            }
        }

        private void deleteCitoyen()
        {
            DialogResult result1 = MessageBox.Show(currentTest.getIdTest().ToString(), "Vous êtes sure de suprimer cette élément ?", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                currentTest.delete();
            }
        }

        private void modifyCitoyen()
        {
            bool hasSymptoms = (hasSymptomsBox.Text.ToLower().Trim() == "oui") ? true : false;
            currentTest.updateAll(typeBox.Text.Trim(), hasSymptoms, resulatBox.Text);
        }

        private void addCitoyen()
        {
            bool hasSymptoms = (hasSymptomsBox.Text.ToLower().Trim() == "oui") ? true : false;
            Citoyen myCitoyen;
            if (currentTest == null)
            {
                myCitoyen = Citoyen.get(this.cinC);
                myCitoyen.setTest(typeBox.Text.Trim(), hasSymptoms);
            }
            else
                currentTest.add(typeBox.Text.Trim(), datePick.Value, hasSymptoms, resulatBox.Text, cinC);
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
            setAllOptBtnsTo(false);
            fillTests();
            AjouterBtn.Enabled = true;
            currentAction = "";
            changeReadOnlyTxtBoxsTo(true);
            setTextBoxes(0);
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
