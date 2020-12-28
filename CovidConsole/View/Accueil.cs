using CovidConsole.Controller;
using System.Windows.Forms;

namespace CovidConsole
{
    public partial class Accueil : Form
    {
        private Panel NavBar;
        private Label label2;
        private Admin admin = new Admin();

        public Accueil()
        {
            InitializeComponent();
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

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil());
        }

        private void connectBtn_Click(object sender, System.EventArgs e)
        {
            //TODO: ADMIN infos: Admin 12345
            string username = UsernameTxt.Text;
            string pwd = PwdTxt.Text;
            if (pwd.Trim() != "" || username.Trim() != "")
            {
                if (admin.verifyConnection(username.Trim(), pwd.Trim()))
                {
                    MessageBox.Show("Welcome " + admin.username);
                }
            }



        }
    }
}
