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
            // Resetare detalii cont.
            pretMancare1 = pretMancare2 = pretMancare3 = pretAccesorii1 = pretAccesorii2 = pretAccesorii3 = pretCaine1 = pretCaine2 = pretCaine3 = 0;
            MainForm.rasaCaine1 = MainForm.rasaCaine2 = MainForm.rasaCaine3 = MainForm.rasaCaineCurent = "";
            MainForm.pathPozaCaine1 = MainForm.pathPozaCaine2 = MainForm.pathPozaCaine3 = MainForm.pathPoza = "";
            ShoppingCartForm.altCaine1 = ShoppingCartForm.altCaine2 = ShoppingCartForm.altCaine3 = 0;
            ShoppingCartForm.maiAdaugaCaine2 = ShoppingCartForm.maiAdaugaCaine3 = false;
            ShoppingCartForm.total = 0;
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
            if (MainForm.rasaCaine1.Trim() == "")
            {
                MessageBox.Show("Introduceți mai întâi un câine!", "Lipsă câine.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FoodForm foodForm = new FoodForm();
            foodForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MainForm.rasaCaine1.Trim() == "")
            {
                MessageBox.Show("Introduceți mai întâi un câine!", "Lipsă câine.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AccessoriesForm accessoriesForm = new AccessoriesForm();
            accessoriesForm.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox1.Clear();
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
            //string pathWebSite = @"C:/Users/Admin/source/repos/Atestat-DogTopia/IntroForm/IntroForm/Resources/DogTopia-Website/index.html";
            Process.Start("chrome.exe", pathWebSite);
        }
    }
}