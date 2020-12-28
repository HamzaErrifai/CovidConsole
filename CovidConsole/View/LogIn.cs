using CovidConsole.Controller;
using System.Windows.Forms;

namespace CovidConsole
{
    public partial class LogIn : Form
    {
        private Panel NavBar;
        private Label loginLbl;
        private TextBox UsernameTxt;
        private Label label1;
        private TextBox PwdTxt;
        private Button connectBtn;
        private Label label2;
        private Label UsernameLbl;
        private Admin admin = new Admin();

        public LogIn()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.NavBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PwdTxt = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(201)))));
            this.NavBar.Controls.Add(this.label2);
            this.NavBar.Location = new System.Drawing.Point(0, 1);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(784, 70);
            this.NavBar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(672, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestion des patients Covid";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.ForeColor = System.Drawing.Color.Black;
            this.loginLbl.Location = new System.Drawing.Point(317, 123);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(176, 63);
            this.loginLbl.TabIndex = 0;
            this.loginLbl.Text = "Log In";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(225, 206);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(442, 39);
            this.UsernameTxt.TabIndex = 2;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.Location = new System.Drawing.Point(43, 206);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(139, 31);
            this.UsernameLbl.TabIndex = 3;
            this.UsernameLbl.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mot de passe";
            // 
            // PwdTxt
            // 
            this.PwdTxt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwdTxt.Location = new System.Drawing.Point(225, 283);
            this.PwdTxt.Name = "PwdTxt";
            this.PwdTxt.PasswordChar = '*';
            this.PwdTxt.Size = new System.Drawing.Size(442, 39);
            this.PwdTxt.TabIndex = 4;
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(482, 349);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(185, 60);
            this.connectBtn.TabIndex = 6;
            this.connectBtn.Text = "Se connecter";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // LogIn
            // 
            this.ClientSize = new System.Drawing.Size(784, 480);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PwdTxt);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.NavBar);
            this.Name = "LogIn";
            this.Text = "Login";
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
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
