using System;
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
    public partial class ShoppingCartForm : Form
    {
        /* 0 - The user doesn't want another dog
         * 1 - The user wants another dog, but he might change his mind and keep the dog.
         * 2 - The user wants another dog, he changes the dog.
         */
        public static int anotherDogSt = 0;
        public static int anotherDogNd = 0;
        public static int anotherDogRd = 0;
        public static bool addSecondDog = false;
        public static bool addThirdDog = false;
        public static int total = 0;
        public ShoppingCartForm()
        {
            InitializeComponent();
            if (MainForm.stBreedDog.Trim() != "")
            {
                labelAddAnotherDog1.Text = MainForm.stBreedDog.Replace('_', ' ');
                checkBoxFood1.Enabled = checkBoxAccessories1.Enabled = true;
                if (AccountForm.priceFoodStDog != 0) checkBoxFood1.Checked = true;
                if (AccountForm.priceAccessoriesStDog != 0) checkBoxAccessories1.Checked = true;
                labelAnotherDog1.Visible = true;

                Image imageDog = Image.FromFile(MainForm.pathPictureStDog); // Add the image of the dog to pictureBoxStDog
                pictureBoxStDog.BackgroundImage = imageDog; 

            }
            if (MainForm.ndBreedDog.Trim() != "")
            {
                labelAddAnotherDog2.Text = MainForm.ndBreedDog.Replace('_', ' ');
                checkBoxFood2.Enabled = checkBoxAccessories2.Enabled = true;
                if (AccountForm.priceFoodNdDog != 0) checkBoxFood2.Checked = true;
                if (AccountForm.priceAccessoriesNdDog != 0) checkBoxAccessories2.Checked = true;
                labelAnotherDog2.Visible = true;

                Image imageDog = Image.FromFile(MainForm.pathPictureNdDog); // // Add the image of the dog to pictureBoxNdDog
                pictureBoxNdDog.BackgroundImage = imageDog;
            }
            if (MainForm.rdBreedDog.Trim() != "")
            {
                labelAddAnotherDog3.Text = MainForm.rdBreedDog.Replace('_', ' ');
                checkBoxFood3.Enabled = checkBoxAccessories3.Enabled = true;
                if (AccountForm.priceFoodRdDog != 0) checkBoxFood3.Checked = true;
                if (AccountForm.priceAccessoriesRdDog != 0) checkBoxAccessories3.Checked = true;
                labelAnotherDog3.Visible = true;

                Image imageDog = Image.FromFile(MainForm.pathPictureRdDog); // Add the image of the dog to pictureBoxRdDog
                pictureBoxRdDog.BackgroundImage = imageDog;
            }
            labelStDog.Text = AccountForm.priceStDog.ToString() + ",00";
            labelNdDog.Text = AccountForm.priceNdDog.ToString() + ",00";
            labelRdDog.Text = AccountForm.priceRdDog.ToString() + ",00";
            total = AccountForm.priceAccessoriesStDog + AccountForm.priceAccessoriesNdDog + AccountForm.priceAccessoriesRdDog +
                    AccountForm.priceStDog + AccountForm.priceNdDog + AccountForm.priceRdDog +
                    AccountForm.priceFoodStDog + AccountForm.priceFoodNdDog + AccountForm.priceFoodRdDog;
            labelTotal.Text = total.ToString() + ",00";
        }
        private void labelAddAnotherDog2_Click(object sender, EventArgs e)
        {
            if (MainForm.stBreedDog.Trim() == "" || MainForm.ndBreedDog.Trim() != "") return;
            addSecondDog = true;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void labelAddAnotherDog3_Click(object sender, EventArgs e)
        {
            if (MainForm.ndBreedDog.Trim() == "" || MainForm.rdBreedDog.Trim() != "") return;
            addThirdDog = true;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void checkBoxFood1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood1.Checked == true)
            {
                if (AccountForm.priceFoodStDog == 0)
                {
                    MessageBox.Show("You didn't add any products in the food section! We added for you in the shopping cart a \"Classic\" Food pachet!",
                       "Missing products.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.priceFoodStDog = 10;
                    
                }
                labelPriceFoodStDog.Text = AccountForm.priceFoodStDog.ToString() + ",00";
                total += AccountForm.priceFoodStDog;
            }
            else
            {
                total -= AccountForm.priceFoodStDog;
                labelPriceFoodStDog.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void checkBoxFood2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood2.Checked == true)
            {
                if (AccountForm.priceFoodNdDog == 0)
                {
                    MessageBox.Show("You didn't add any products in the food section! We added for you in the shopping cart a \"Classic\" Food pachet!",
                       "Missing products.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.priceFoodNdDog = 10;
                }
                labelPriceFoodNdDog.Text = AccountForm.priceFoodNdDog.ToString() + ",00";
                total += AccountForm.priceFoodNdDog;
            }
            else
            {
                total -= AccountForm.priceFoodNdDog;
                labelPriceFoodNdDog.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void checkBoxFood3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood3.Checked == true)
            {
                if (AccountForm.priceFoodRdDog == 0)
                {
                    MessageBox.Show("You didn't add any products in the food section! We added for you in the shopping cart a \"Classic\" Food pachet!",
                        "Missing products.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.priceFoodRdDog = 10;
                }
                labelPriceFoodRdDog.Text = AccountForm.priceFoodRdDog.ToString() + ",00";
                total += AccountForm.priceFoodRdDog;
            }
            else
            {
                total -= AccountForm.priceFoodRdDog;
                labelPriceFoodRdDog.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void checkBoxAccessories1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAccessories1.Checked == true)
            {
                if (AccountForm.priceAccessoriesStDog == 0)
                {
                    MessageBox.Show("You didn't add any products in the accessories section! We added for you in the shopping cart a \"Classic\" " +
                        "Accessories pachet!", "Missing products.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.priceAccessoriesStDog = 17;
                }
                labelPriceAccessoriesStDog.Text = AccountForm.priceAccessoriesStDog.ToString() + ",00";
                total += AccountForm.priceAccessoriesStDog;
            }
            else
            {
                total -= AccountForm.priceAccessoriesStDog;
                labelPriceAccessoriesStDog.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void checkBoxAccessories2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAccessories2.Checked == true)
            {
                if (AccountForm.priceAccessoriesNdDog == 0)
                {
                    MessageBox.Show("You didn't add any products in the accessories section! We added for you in the shopping cart a \"Classic\" " +
                        "Accessories pachet!", "Missing products.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.priceAccessoriesNdDog = 17;
                }
                labelPriceAccessoriesNdDog.Text = AccountForm.priceAccessoriesNdDog.ToString() + ",00";
                total += AccountForm.priceAccessoriesNdDog;
            }
            else
            {
                total -= AccountForm.priceAccessoriesNdDog;
                labelPriceAccessoriesNdDog.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void checkBoxAccessories3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAccessories3.Checked == true)
            {
                if (AccountForm.priceAccessoriesRdDog == 0)
                {
                    MessageBox.Show("You didn't add any products in the accessories section! We added for you in the shopping cart a \"Classic\" " +
                        "Accessories pachet!", "Missing products.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.priceAccessoriesRdDog = 17;
                }
                labelPriceAccessoriesRdDog.Text = AccountForm.priceAccessoriesRdDog.ToString() + ",00";
                total += AccountForm.priceAccessoriesRdDog;
            }
            else
            {
                total -= AccountForm.priceAccessoriesRdDog;
                labelPriceAccessoriesRdDog.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void labelAddAnotherDog1_Click(object sender, EventArgs e)
        {
            if (MainForm.stBreedDog.Trim() != "") return;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void labelAnotherDog1_Click(object sender, EventArgs e)
        {
            anotherDogSt = 1;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void labelAnotherDog2_Click(object sender, EventArgs e)
        {
            anotherDogNd = 1;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void labelAnotherDog3_Click(object sender, EventArgs e)
        {
            anotherDogRd = 1;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
            this.Hide();
        }

        private void pictureBoxPay_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("The shopping cart is empty!", "Empty shopping cart.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PayForm payForm = new PayForm();
            payForm.Show();
            this.Hide();
        }
    }
}