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
    public partial class AccountForm : Form
    {
        public static Image ResizeImage(Image image, Size newSize)
        {
            Image newImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics GFX = Graphics.FromImage((Bitmap)newImage))
            {
                GFX.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }
            return newImage;
        }

        public AccountForm()
        {
            InitializeComponent();
            if (MainForm.rasaCaine != "") // Afisam fotografia doar daca utilizatorul si-a clasificat cainele
            {
                Image imagineCaine = Image.FromFile(MainForm.pathPoza);
                Size dimensiune = new Size();
                dimensiune.Height = 449;
                dimensiune.Width = 619;
                pictureBox8.Image = ResizeImage(imagineCaine, dimensiune);
                panelContact.Hide();
                panel1.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panelContact.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
