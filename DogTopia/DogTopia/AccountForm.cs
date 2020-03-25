using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogTopia
{
    public partial class AccountForm : Form
    {
        public static int priceFoodStDog = 0;
        public static int priceFoodNdDog = 0;
        public static int priceFoodRdDog = 0;

        public static int priceAccessoriesStDog = 0;
        public static int priceAccessoriesNdDog = 0;
        public static int priceAccessoriesRdDog = 0;

        public static int priceStDog = 0;
        public static int priceNdDog = 0;
        public static int priceRdDog = 0;

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
            if (MainForm.stBreedDog != "") // Show the image only if the dog was classified
            {
                Image imageDog = Image.FromFile(MainForm.pathPicture);
                Size dimension = new Size();
                dimension.Height = 449;
                dimension.Width = 619;
                pictureBoxPictureDog.Image = ResizeImage(imageDog, dimension);
                panelContact.Hide();
                panelInitial.Show();
            }
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            // Reset account details
            priceFoodStDog = priceFoodNdDog = priceFoodRdDog = 0;
            priceAccessoriesStDog = priceAccessoriesNdDog = priceAccessoriesRdDog = 0;
            priceStDog = priceNdDog = priceRdDog = 0;
            MainForm.stBreedDog = MainForm.ndBreedDog = MainForm.rdBreedDog = MainForm.breedCurrentDog = "";
            MainForm.pathPictureStDog = MainForm.pathPictureNdDog = MainForm.pathPictureRdDog = MainForm.pathPicture = "";
            ShoppingCartForm.anotherDogSt = ShoppingCartForm.anotherDogNd = ShoppingCartForm.anotherDogRd = 0;
            ShoppingCartForm.addSecondDog = ShoppingCartForm.addThirdDog = false;
            ShoppingCartForm.total = 0;
            LoginForm.isLoggedIn = false;
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            if (panelInitial.Visible == true)
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                panelInitial.Show();
                panelContact.Hide();
            }
        }

        private void pictureBoxContact_Click(object sender, EventArgs e)
        {
            panelInitial.Hide();
            panelContact.Show();
        }

        private void pictureBoxFood_Click(object sender, EventArgs e)
        {
            if (MainForm.stBreedDog.Trim() == "")
            {
                MessageBox.Show("You have to introduce a dog!", "Missing dog.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FoodForm foodForm = new FoodForm();
            foodForm.Show();
            this.Hide();
        }

        private void pictureBoxAccessories_Click(object sender, EventArgs e)
        {
            if (MainForm.stBreedDog.Trim() == "")
            {
                MessageBox.Show("You have to introduce a dog!", "Missing dog.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AccessoriesForm accessoriesForm = new AccessoriesForm();
            accessoriesForm.Show();
            this.Hide();
        }

        private void pictureBoxSendMail_Click(object sender, EventArgs e)
        {
            richTextBoxMesage.Clear();
            textBoxSubject.Clear();
            panelInitial.Show();
            panelContact.Hide();
        }

        private void pictureBoxAddToCart_Click(object sender, EventArgs e)
        {
            ShoppingCartForm shoppingCartForm = new ShoppingCartForm();
            shoppingCartForm.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string pathWebSite = IntroForm.pathWorkingDirectory + @"Resources\DogTopia-Website\index.html";
            Process.Start("chrome.exe", pathWebSite);
        }
    }
}