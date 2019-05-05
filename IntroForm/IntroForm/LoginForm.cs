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

namespace IntroForm
{
    public partial class LoginForm : Form
    {
        public static bool isLoggedIn = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SignUpForm signform = new SignUpForm();
            signform.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (SignUpForm.areCaractereSpeciale(textBox1) == true)
            {
                textBox1.Clear();
                MessageBox.Show("Te rugăm să introduci un username care să nu conțină caractere speciale!", "Caractere speciale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SignUpForm.areCaractereSpeciale(textBox2) == true || SignUpForm.contineSpatiiSauCratime(textBox2) == true)
            {
                textBox2.Clear();
                MessageBox.Show("Te rugăm să introduci o parolă care să nu conțină caractere speciale!", "Caractere speciale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(textBox1.Text.Trim()) || String.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                MessageBox.Show("Te rugăm să completezi toate câmpurile!", "Câmpuri necompletate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string usernameUser = textBox1.Text.Trim();
            string parolaUser = textBox2.Text.Trim();

            //using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\dogtopia-team\Atestat-DogTopia\IntroForm\IntroForm\Conturi.mdf;Integrated Security=True"))
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Source\Repos\Atestat-DogTopia\IntroForm\IntroForm\Conturi.mdf;Integrated Security=True"))
            {
                conn.Open();
                String command = String.Format(@"select * from Conturi where Username = '{0}' and Parola = '{1}'", usernameUser, parolaUser);
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    isLoggedIn = true;
                    AccountForm acc = new AccountForm();
                    acc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datele introduse sunt incorecte!", "Date incorecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear(); textBox2.Clear();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            IntroForm intr = new IntroForm();
            intr.Show();
            this.Hide();
        }
    }
}
