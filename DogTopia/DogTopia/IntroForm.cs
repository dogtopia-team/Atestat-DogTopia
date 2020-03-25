using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogTopia
{
    public partial class IntroForm : Form
    {
        public static string pathWorkingDirectory = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 9);
        public IntroForm()
        {
            InitializeComponent();
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            if (LoginForm.isLoggedIn == true)
            {
                AccountForm accountForm = new AccountForm();
                accountForm.Show();
                this.Hide();
            }
            else
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void pictureBoxStart_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
