using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogTopia
{
    public partial class LoginForm : Form
    {
        public static bool isLoggedIn = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelSignup_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            if (SignUpForm.hasSpecialCharacters(textBoxUsername) == true)
            {
                textBoxUsername.Clear();
                MessageBox.Show("Please introduce an username that has no special characters!", "Special characters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SignUpForm.hasSpecialCharacters(textBoxPassword) == true || SignUpForm.hasSpacesOrDashes(textBoxPassword) == true)
            {
                textBoxPassword.Clear();
                MessageBox.Show("Please introduce a password that has no special characters!", "Special characters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(textBoxUsername.Text.Trim()) || String.IsNullOrEmpty(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("Please complete all the fields!", "Incomplete fields.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string usernameUser = textBoxUsername.Text.Trim();
            string passwordUser = textBoxPassword.Text.Trim();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Atestat-DogTopia\DogTopia\DogTopia\Conturi.mdf;Integrated Security=True"))
            {
                connection.Open();
                String command = String.Format(@"select * from Conturi where Username = '{0}' and Parola = '{1}'", usernameUser, passwordUser);
                SqlCommand cmd = new SqlCommand(command, connection);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    isLoggedIn = true;
                    AccountForm accountForm = new AccountForm();
                    accountForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The introduced credentials are incorrect!", "Incorrect credentials.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Clear(); textBoxPassword.Clear();
                }
            }
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            IntroForm introForm = new IntroForm();
            introForm.Show();
            this.Hide();
        }
    }
}
