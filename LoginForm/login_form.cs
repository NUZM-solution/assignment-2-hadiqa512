namespace Assignment_2
{
    public partial class frmLogin : Form
    {
        Double count = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUser.Clear();
            txtUser.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = "Hadiqa_Zahra";
            pass = "22011556-002";

            if ((txtUser.Text == user) && (txtPass.Text == pass))
            {
                MessageBox.Show("Welcome User!");
            }
            else
            {
                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show($"Wrong username or password \t{remain} tries left");
                txtPass.Clear();
                txtUser.Clear();
                txtUser.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Max try exceeded");
                    Application.Exit();
                }
            }
        }
    }
}
