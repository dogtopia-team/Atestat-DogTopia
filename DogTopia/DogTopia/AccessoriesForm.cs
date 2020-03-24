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
        public static bool cumparaAc1 = false;
        public static bool cumparaAc2 = false;
        public static bool cumparaAc3 = false;
        public static bool cumparaAc4 = false;
        public static bool cumparaAc5 = false;
        public static bool cumparaAc6 = false;
        public AccessoriesForm()
        {
           InitializeComponent();
           if (cumparaAc1 == true) checkBoxAc1.Checked = true;
            else checkBoxAc1.Checked = false;
           if (cumparaAc2 == true) checkBoxAc2.Checked = true;
            else checkBoxAc2.Checked = false;
           if (cumparaAc3 == true) checkBoxAc3.Checked = true;
            else checkBoxAc3.Checked = false;
           if (cumparaAc4 == true) checkBoxAc4.Checked = true;
            else checkBoxAc4.Checked = false;
           if (cumparaAc5 == true) checkBoxAc5.Checked = true;
            else checkBoxAc5.Checked = false;
           if (cumparaAc6 == true) checkBoxAc6.Checked = true;
            else checkBoxAc6.Checked = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (MainForm.pathPozaCaine1 == MainForm.pathPoza)
            {
                AccountForm.pretAccesorii1 = 0;
                if (cumparaAc1) AccountForm.pretAccesorii1 += 5;
                if (cumparaAc2) AccountForm.pretAccesorii1 += 7;
                if (cumparaAc3) AccountForm.pretAccesorii1 += 10;
                if (cumparaAc4) AccountForm.pretAccesorii1 += 7;
                if (cumparaAc5) AccountForm.pretAccesorii1 += 15;
                if (cumparaAc6) AccountForm.pretAccesorii1 += 50;
            }
            else if (MainForm.pathPozaCaine2 == MainForm.pathPoza)
            {
                AccountForm.pretAccesorii2 = 0;
                if (cumparaAc1) AccountForm.pretAccesorii2 += 5;
                if (cumparaAc2) AccountForm.pretAccesorii2 += 7;
                if (cumparaAc3) AccountForm.pretAccesorii2 += 10;
                if (cumparaAc4) AccountForm.pretAccesorii2 += 7;
                if (cumparaAc5) AccountForm.pretAccesorii2 += 15;
                if (cumparaAc6) AccountForm.pretAccesorii2 += 50;
            }
            else if (MainForm.pathPozaCaine3 == MainForm.pathPoza)
            {
                AccountForm.pretAccesorii3 = 0;
                if (cumparaAc1) AccountForm.pretAccesorii3 += 5;
                if (cumparaAc2) AccountForm.pretAccesorii3 += 7;
                if (cumparaAc3) AccountForm.pretAccesorii3 += 10;
                if (cumparaAc4) AccountForm.pretAccesorii3 += 7;
                if (cumparaAc5) AccountForm.pretAccesorii3 += 15;
                if (cumparaAc6) AccountForm.pretAccesorii3 += 50;
            }

            AccountForm accountForm = new AccountForm();
            accountForm.Show();
            this.Hide();
        }

        private void checkBoxAc1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc1.Checked == true) cumparaAc1 = true;
             else cumparaAc1 = false;
        }

        private void checkBoxAc2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc2.Checked == true) cumparaAc2 = true;
            else cumparaAc2 = false;
        }

        private void checkBoxAc3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc3.Checked == true) cumparaAc3 = true;
            else cumparaAc3 = false;
        }

        private void checkBoxAc4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc4.Checked == true) cumparaAc4 = true;
            else cumparaAc4 = false;
        }

        private void checkBoxAc5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc5.Checked == true) cumparaAc5 = true;
            else cumparaAc5 = false;
        }

        private void checkBoxAc6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAc6.Checked == true) cumparaAc6 = true;
            else cumparaAc6 = false;
        }
    }
}
