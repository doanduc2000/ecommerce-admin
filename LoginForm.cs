namespace EcommerceAdmin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginClick()
        {
            if (txtPhone.Text == "admin" && txtPassword.Text == "admin")
            {
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your phone or password is incorrect");
                txtPhone.Clear();
                txtPassword.Clear();
                txtPhone.Focus();

            }
        }
        private void login_Click(object sender, EventArgs e)
        {
            this.LoginClick();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPhone_TextChanged(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.LoginClick();
            }
        }

        private void txtPassword_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoginClick();
            }
        }

       
    }
}
