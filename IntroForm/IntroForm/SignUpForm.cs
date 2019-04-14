using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroForm
{
    public partial class SignUpForm : Form
    {
        private bool areCaractereSpeciale(TextBox x)
        {
            string sir = x.Text.Trim();

            for (int i = 0; i < sir.Length; i++)
                if (sir[i] != ' ' && sir[i] != '-' && !Char.IsLetterOrDigit(sir[i])) return true;
            return false;
        }

        private bool contineSpatiiSauCratime(TextBox x)
        {
            string sir = x.Text;

            for (int i = 0; i < sir.Length; i++)
                if (sir[i] == ' ' ||sir[i] == '-') return true;
            return false;
        }

        public SignUpForm()
        {
            InitializeComponent();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (areCaractereSpeciale(textBox1) == true)
            {
                textBox1.Clear();
                MessageBox.Show("Te rugăm să introduci un nume care să nu conțină caractere speciale!", "Caractere speciale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (areCaractereSpeciale(textBox2) == true)
            {
                textBox2.Clear();
                MessageBox.Show("Te rugăm să introduci un prenume care să nu conțină caractere speciale!", "Caractere speciale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (areCaractereSpeciale(textBox3) == true)
            {
                textBox3.Clear();
                MessageBox.Show("Te rugăm să introduci un username care să nu conțină caractere speciale!", "Caractere speciale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (areCaractereSpeciale(textBox5) == true || contineSpatiiSauCratime(textBox5) == true)
            {
                textBox5.Clear();
                MessageBox.Show("Te rugăm să introduci o parolă care să nu conțină caractere speciale!", "Caractere speciale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(textBox1.Text.Trim()) || String.IsNullOrEmpty(textBox2.Text.Trim()) || String.IsNullOrEmpty(textBox3.Text.Trim()) || String.IsNullOrEmpty(textBox4.Text.Trim())
                || String.IsNullOrEmpty(textBox5.Text.Trim()) || String.IsNullOrEmpty(textBox6.Text.Trim()))
            {
                MessageBox.Show("Te rugăm să completezi toate câmpurile!", "Câmpuri necompletate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBox1.Checked == false || checkBox2.Checked == false)
            {
                MessageBox.Show("Pentru a continua trebuie sa fii de acord cu politica DogTopia si cu prelucrarea datelor!", "Politica DogTopia/Prelucrare date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Te rugăm să reintroduci parolele", "Parolelele nu corespund", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Clear();
                textBox6.Clear();
                return;
            }

            if (!textBox4.Text.Contains("@") || !textBox4.Text.Contains(".com"))
            {
                MessageBox.Show("Te rugăm să introduci un email valid", "Adresă de email invalidă", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Clear();
                return;
            }

            // daca nu este nicio problema, se va intra in aplicatie
            AccountFormcs acc = new AccountFormcs();
            acc.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            IntroForm intr = new IntroForm();
            intr.Show();
            this.Hide();
        }
    }
}
