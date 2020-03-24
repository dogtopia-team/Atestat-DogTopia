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
        public static bool cumparaFood1 = false;
        public static bool cumparaFood2 = false;
        public static bool cumparaFood3 = false;
        public static bool cumparaFood4 = false;
        public static bool cumparaFood5 = false;
        public static bool cumparaFood6 = false;

        public FoodForm()
        {
            InitializeComponent();
            if (cumparaFood1 == true) checkBoxFood1.Checked = true;
             else checkBoxFood1.Checked = false;
            if (cumparaFood2 == true) checkBoxFood2.Checked = true;
             else checkBoxFood2.Checked = false;
            if (cumparaFood3 == true) checkBoxFood3.Checked = true;
             else checkBoxFood3.Checked = false;
            if (cumparaFood4 == true) checkBoxFood4.Checked = true;
             else checkBoxFood4.Checked = false;
            if (cumparaFood5 == true) checkBoxFood5.Checked = true;
             else checkBoxFood5.Checked = false;
            if (cumparaFood6 == true) checkBoxFood6.Checked = true;
             else checkBoxFood6.Checked = false;
        }

        private void pictureBoxMancareRevino_Click(object sender, EventArgs e)
        {
            if (MainForm.pathPozaCaine1 == MainForm.pathPoza)
            {
                AccountForm.pretMancare1 = 0;
                if (cumparaFood1) AccountForm.pretMancare1 += 5;
                if (cumparaFood2) AccountForm.pretMancare1 += 7;
                if (cumparaFood3) AccountForm.pretMancare1 += 10;
                if (cumparaFood4) AccountForm.pretMancare1 += 12;
                if (cumparaFood5) AccountForm.pretMancare1 += 15;
                if (cumparaFood6) AccountForm.pretMancare1 += 20;
            }
            else if (MainForm.pathPozaCaine2 == MainForm.pathPoza)
            {
                AccountForm.pretMancare2 = 0;
                if (cumparaFood1) AccountForm.pretMancare2 += 5;
                if (cumparaFood2) AccountForm.pretMancare2 += 7;
                if (cumparaFood3) AccountForm.pretMancare2 += 10;
                if (cumparaFood4) AccountForm.pretMancare2 += 12;
                if (cumparaFood5) AccountForm.pretMancare2 += 15;
                if (cumparaFood6) AccountForm.pretMancare2 += 20;
            }
            else if (MainForm.pathPozaCaine3 == MainForm.pathPoza)
            {
                AccountForm.pretMancare3 = 0;
                if (cumparaFood1) AccountForm.pretMancare3 += 5;
                if (cumparaFood2) AccountForm.pretMancare3 += 7;
                if (cumparaFood3) AccountForm.pretMancare3 += 10;
                if (cumparaFood4) AccountForm.pretMancare3 += 12;
                if (cumparaFood5) AccountForm.pretMancare3 += 15;
                if (cumparaFood6) AccountForm.pretMancare3 += 20;
            }
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
            this.Hide();
        }

        private void labelMancareExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxFood1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood1.Checked == true) cumparaFood1 = true;
             else cumparaFood1 = false;
        }

        private void checkBoxFood2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood2.Checked == true) cumparaFood2 = true;
             else cumparaFood2 = false;
        }

        private void checkBoxFood3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood3.Checked == true) cumparaFood3 = true;
             else cumparaFood3 = false;
        }

        private void checkBoxFood4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood4.Checked == true) cumparaFood4 = true;
             else cumparaFood4 = false;
        }

        private void checkBoxFood5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood5.Checked == true) cumparaFood5 = true;
             else cumparaFood5 = false;
        }

        private void checkBoxFood6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFood6.Checked == true) cumparaFood6 = true;
             else cumparaFood6 = false;
        }
    }
}
