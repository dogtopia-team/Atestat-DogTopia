using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroForm
{
    public partial class AccountForm : Form
    {
        public static int pretMancare1 = 0;
        public static int pretMancare2 = 0;
        public static int pretMancare3 = 0;

        public static int pretAccesorii1 = 0;
        public static int pretAccesorii2 = 0;
        public static int pretAccesorii3 = 0;

        public static int pretCaine1 = 0;
        public static int pretCaine2 = 0;
        public static int pretCaine3 = 0;

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
            if (MainForm.rasaCaine1 != "") // Afisam fotografia doar daca utilizatorul si-a clasificat cainele
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
            LoginForm.isLoggedIn = false;
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                panel1.Show();
                panelContact.Hide();
            }
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (MainForm.rasaCaine1.Trim() == "") return;
            Random r = new Random();
            int pret = (r.Next(10, 50) / 10) * 10;
            if (pretMancare1 == 0) pretMancare1 = pret;
            else if (pretMancare2 == 0) pretMancare2 = pret;
            else if (pretMancare3 == 0) pretMancare3 = pret;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MainForm.rasaCaine1.Trim() == "") return;
            Random r = new Random();
            int pret = (r.Next(100, 250) / 10) * 10;
            if (pretAccesorii1 == 0) pretAccesorii1 = pret;
            else if (pretAccesorii2 == 0) pretAccesorii2 = pret;
            else if (pretAccesorii3 == 0) pretAccesorii3 = pret;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panelContact.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ShoppingCartForm shopping = new ShoppingCartForm();
            shopping.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string pathWebSite = @"C:/Users/Admin/source/repos/dogtopia-team/Atestat-DogTopia/IntroForm/IntroForm/Resources/DogTopia-Website/index.html";
            Process.Start("chrome.exe", pathWebSite);
        }
    }
}