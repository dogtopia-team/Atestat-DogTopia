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
    public partial class FoodForm : Form
    {
        public static bool buyFood1 = false;
        public static bool buyFood2 = false;
        public static bool buyFood3 = false;
        public static bool buyFood4 = false;
        public static bool buyFood5 = false;
        public static bool buyFood6 = false;

        public FoodForm()
        {
            InitializeComponent();
            if (buyFood1 == true) checkBoxFood1.Checked = true;
             else checkBoxFood1.Checked = false;
            if (buyFood2 == true) checkBoxFood2.Checked = true;
             else checkBoxFood2.Checked = false;
            if (buyFood3 == true) checkBoxFood3.Checked = true;
             else checkBoxFood3.Checked = false;
            if (buyFood4 == true) checkBoxFood4.Checked = true;
             else checkBoxFood4.Checked = false;
            if (buyFood5 == true) checkBoxFood5.Checked = true;
             else checkBoxFood5.Checked = false;
            if (buyFood6 == true) checkBoxFood6.Checked = true;
             else checkBoxFood6.Checked = false;
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            if (MainForm.pathPictureStDog == MainForm.pathPicture)
            {
                AccountForm.priceFoodStDog = 0;
                if (buyFood1) AccountForm.priceFoodStDog += 5;
                if (buyFood2) AccountForm.priceFoodStDog += 7;
                if (buyFood3) AccountForm.priceFoodStDog += 10;
                if (buyFood4) AccountForm.priceFoodStDog += 12;
                if (buyFood5) AccountForm.priceFoodStDog += 15;
                if (buyFood6) AccountForm.priceFoodStDog += 20;
            }
            else if (MainForm.pathPictureNdDog == MainForm.pathPicture)
            {
                AccountForm.priceFoodNdDog = 0;
                if (buyFood1) AccountForm.priceFoodNdDog += 5;
                if (buyFood2) AccountForm.priceFoodNdDog += 7;
                if (buyFood3) AccountForm.priceFoodNdDog += 10;
                if (buyFood4) AccountForm.priceFoodNdDog += 12;
                if (buyFood5) AccountForm.priceFoodNdDog += 15;
                if (buyFood6) AccountForm.priceFoodNdDog += 20;
            }
            else if (MainForm.pathPictureRdDog == MainForm.pathPicture)
            {
                AccountForm.priceFoodRdDog = 0;
                if (buyFood1) AccountForm.priceFoodRdDog += 5;
                if (buyFood2) AccountForm.priceFoodRdDog += 7;
                if (buyFood3) AccountForm.priceFoodRdDog += 10;
                if (buyFood4) AccountForm.priceFoodRdDog += 12;
                if (buyFood5) AccountForm.priceFoodRdDog += 15;
                if (buyFood6) AccountForm.priceFoodRdDog += 20;
            }
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
            this.Hide();
        }

        private void checkBoxFood1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood1.Checked == true) buyFood1 = true;
             else buyFood1 = false;
        }

        private void checkBoxFood2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood2.Checked == true) buyFood2 = true;
             else buyFood2 = false;
        }

        private void checkBoxFood3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood3.Checked == true) buyFood3 = true;
             else buyFood3 = false;
        }

        private void checkBoxFood4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood4.Checked == true) buyFood4 = true;
             else buyFood4 = false;
        }

        private void checkBoxFood5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood5.Checked == true) buyFood5 = true;
             else buyFood5 = false;
        }

        private void checkBoxFood6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood6.Checked == true) buyFood6 = true;
             else buyFood6 = false;
        }
    }
}
