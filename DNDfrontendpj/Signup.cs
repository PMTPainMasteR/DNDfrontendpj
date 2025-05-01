namespace DNDfrontendpj
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ret2loginBT_Click(object sender, EventArgs e)
        {
            infodao infodao = new infodao();
            if (!string.IsNullOrWhiteSpace(Signup_username.Text) && !string.IsNullOrWhiteSpace(Signup_pass.Text)
                && !string.IsNullOrWhiteSpace(Signup_con.Text))
            {
                userInfo newuser = new userInfo()
                {
                    userUID = 1,
                    username = Signup_username.Text,
                    password = Signup_pass.Text,
                    DM = 1,
                    Player = 1
                };
                string password_chk = this.Signup_pass.Text.Trim();
                string passwordcon_chk = this.Signup_con.Text.Trim();
                if (password_chk == passwordcon_chk)
                {
                    if (DM_chkbox.Checked && Player_chkbox.Checked)
                    {
                        int addDM = infodao.signupasdm(newuser);
                        int addPlayer = infodao.signupasplayer(newuser);
                        MessageBox.Show("Signup succesfully", "Sigup", MessageBoxButtons.OK);
                        this.Hide();
                        login login = new login();
                        login.ShowDialog();
                    }
                    else if (DM_chkbox.Checked && !Player_chkbox.Checked)
                    {
                        int addDM = infodao.signupasdm(newuser);
                        MessageBox.Show("Signup as DM succesfully", "Sigup", MessageBoxButtons.OK);
                        this.Hide();
                        login login = new login();
                        login.ShowDialog();
                    }
                    else if (!DM_chkbox.Checked && Player_chkbox.Checked)
                    {
                        int addPlayer = infodao.signupasplayer(newuser);
                        MessageBox.Show("Signup as Player succesfully", "Sigup", MessageBoxButtons.OK);
                        this.Hide();
                        login login = new login();
                        login.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please select who you are (DM, Player)", "Not Selected role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Your passwords do not match", "Passwords do not match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please filled all the blank", "Some Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void return2loginBT_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }
    }
}

