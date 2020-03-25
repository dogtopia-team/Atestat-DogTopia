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
    public partial class SignUpForm : Form
    {
        public static bool hasSpecialCharacters(TextBox textToBeVerified)
        {
            string stringToBeVerified = textToBeVerified.Text.Trim();
            for (int i = 0; i < stringToBeVerified.Length; i++)
                if (stringToBeVerified[i] != ' ' && stringToBeVerified[i] != '-' && !Char.IsLetterOrDigit(stringToBeVerified[i])) return true;
            return false;
        }

        public static bool hasSpacesOrDashes(TextBox textToBeVerified)
        {
            string stringToBeVerified = textToBeVerified.Text;
            for (int i = 0; i < stringToBeVerified.Length; i++)
                if (stringToBeVerified[i] == ' ' ||  stringToBeVerified[i] == '-') return true;
            return false;
        }

        public SignUpForm()
        {
            InitializeComponent();
            textBoxUserSurname.Clear();
            textBoxUserFirstname.Clear();
            textBoxUserUsername.Clear();
            textBoxUserEmail.Clear();
            textBoxUserPassword.Clear();
            textBoxConfirmUsername.Clear();
            checkBoxAgreeConditions.Checked = false;
            checkBoxAgreePersonalData.Checked = false;
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            if (hasSpecialCharacters(textBoxUserSurname) == true)
            {
                textBoxUserSurname.Clear();
                MessageBox.Show("Please introduce a surname that has no special characters!", "Special characters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hasSpecialCharacters(textBoxUserFirstname) == true)
            {
                textBoxUserFirstname.Clear();
                MessageBox.Show("Please introduce a first name that has no special characters!", "Special characters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hasSpecialCharacters(textBoxUserUsername) == true)
            {
                textBoxUserUsername.Clear();
                MessageBox.Show("Please introduce an username that has no special characters!", "Special characters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hasSpecialCharacters(textBoxUserPassword) == true || hasSpacesOrDashes(textBoxUserPassword) == true)
            {
                textBoxUserPassword.Clear();
                MessageBox.Show("Please introduce a password that has no special characters!", "Special characters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(textBoxUserSurname.Text.Trim()) || String.IsNullOrEmpty(textBoxUserFirstname.Text.Trim()) || String.IsNullOrEmpty(textBoxUserUsername.Text.Trim()) || String.IsNullOrEmpty(textBoxUserEmail.Text.Trim())
                || String.IsNullOrEmpty(textBoxUserPassword.Text.Trim()) || String.IsNullOrEmpty(textBoxConfirmUsername.Text.Trim()))
            {
                MessageBox.Show("Please complete all of the mandatory fields!", "Incomplete fields.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBoxAgreeConditions.Checked == false || checkBoxAgreePersonalData.Checked == false)
            {
                MessageBox.Show("To continue you have to consent to DogTopia's policy and personal data processing!", "DogTopia's policy/Data processing.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxUserPassword.Text != textBoxConfirmUsername.Text)
            {
                MessageBox.Show("Please introduce again the passwords!", "The passwords don't match.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserPassword.Clear();
                textBoxConfirmUsername.Clear();
                return;
            }

            if (!textBoxUserEmail.Text.Contains("@") || !textBoxUserEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Please introduce a valid email adress!", "Invalid email adress.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserEmail.Clear();
                return;
            }
            // If there's no problem, add the data to the database.
            string surname = textBoxUserSurname.Text.Trim();
            string firstname = textBoxUserFirstname.Text.Trim();
            string emailAdress = textBoxUserEmail.Text.Trim();
            string username = textBoxUserUsername.Text.Trim();
            string password = textBoxUserPassword.Text.Trim();
            
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Atestat-DogTopia\DogTopia\DogTopia\Conturi.mdf;Integrated Security=True"))
            {
                connection.Open();
                String command = String.Format(@"insert into Conturi(Nume, Prenume, Email, Username, Parola) 
                    values('{0}', '{1}', '{2}', '{3}', '{4}')", surname, firstname, emailAdress, username, password);
                SqlCommand cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();
            }

            // If there's no problem, go to LoginForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); 
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            IntroForm introForm = new IntroForm();
            introForm.Show();
            this.Hide();
        }
    }
}
