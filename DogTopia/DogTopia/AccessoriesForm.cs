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
    public partial class AccessoriesForm : Form
    {
        public static bool buyAccessory1 = false;
        public static bool buyAccessory2 = false;
        public static bool buyAccessory3 = false;
        public static bool buyAccessory4 = false;
        public static bool buyAccessory5 = false;
        public static bool buyAccessory6 = false;
        public AccessoriesForm()
        {
           InitializeComponent();
           if (buyAccessory1 == true) checkBoxAc1.Checked = true;
            else checkBoxAc1.Checked = false;
           if (buyAccessory2 == true) checkBoxAc2.Checked = true;
            else checkBoxAc2.Checked = false;
           if (buyAccessory3 == true) checkBoxAc3.Checked = true;
            else checkBoxAc3.Checked = false;
           if (buyAccessory4 == true) checkBoxAc4.Checked = true;
            else checkBoxAc4.Checked = false;
           if (buyAccessory5 == true) checkBoxAc5.Checked = true;
            else checkBoxAc5.Checked = false;
           if (buyAccessory6 == true) checkBoxAc6.Checked = true;
            else checkBoxAc6.Checked = false;
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            if (MainForm.pathPictureStDog == MainForm.pathPicture)
            {
                AccountForm.priceAccessoriesStDog = 0;
                if (buyAccessory1) AccountForm.priceAccessoriesStDog += 5;
                if (buyAccessory2) AccountForm.priceAccessoriesStDog += 7;
                if (buyAccessory3) AccountForm.priceAccessoriesStDog += 10;
                if (buyAccessory4) AccountForm.priceAccessoriesStDog += 7;
                if (buyAccessory5) AccountForm.priceAccessoriesStDog += 15;
                if (buyAccessory6) AccountForm.priceAccessoriesStDog += 50;
            }
            else if (MainForm.pathPictureNdDog == MainForm.pathPicture)
            {
                AccountForm.priceAccessoriesNdDog = 0;
                if (buyAccessory1) AccountForm.priceAccessoriesNdDog += 5;
                if (buyAccessory2) AccountForm.priceAccessoriesNdDog += 7;
                if (buyAccessory3) AccountForm.priceAccessoriesNdDog += 10;
                if (buyAccessory4) AccountForm.priceAccessoriesNdDog += 7;
                if (buyAccessory5) AccountForm.priceAccessoriesNdDog += 15;
                if (buyAccessory6) AccountForm.priceAccessoriesNdDog += 50;
            }
            else if (MainForm.pathPictureRdDog == MainForm.pathPicture)
            {
                AccountForm.priceAccessoriesRdDog = 0;
                if (buyAccessory1) AccountForm.priceAccessoriesRdDog += 5;
                if (buyAccessory2) AccountForm.priceAccessoriesRdDog += 7;
                if (buyAccessory3) AccountForm.priceAccessoriesRdDog += 10;
                if (buyAccessory4) AccountForm.priceAccessoriesRdDog += 7;
                if (buyAccessory5) AccountForm.priceAccessoriesRdDog += 15;
                if (buyAccessory6) AccountForm.priceAccessoriesRdDog += 50;
            }

            AccountForm accountForm = new AccountForm();
            accountForm.Show();
            this.Hide();
        }

        private void checkBoxAc1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc1.Checked == true) buyAccessory1 = true;
             else buyAccessory1 = false;
        }

        private void checkBoxAc2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc2.Checked == true) buyAccessory2 = true;
            else buyAccessory2 = false;
        }

        private void checkBoxAc3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc3.Checked == true) buyAccessory3 = true;
            else buyAccessory3 = false;
        }

        private void checkBoxAc4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc4.Checked == true) buyAccessory4 = true;
            else buyAccessory4 = false;
        }

        private void checkBoxAc5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc5.Checked == true) buyAccessory5 = true;
            else buyAccessory5 = false;
        }

        private void checkBoxAc6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc6.Checked == true) buyAccessory6 = true;
            else buyAccessory6 = false;
        }
    }
}
