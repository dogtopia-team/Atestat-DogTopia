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
    public partial class ShoppingCartForm : Form
    {
        public static bool maiAdaugaCaine2 = false;
        public static bool maiAdaugaCaine3 = false;
        public ShoppingCartForm()
        {
            InitializeComponent();
            if (MainForm.rasaCaine1.Trim() != "") labelCaine1.Text = MainForm.rasaCaine1.Replace('_', ' ');
            if (MainForm.rasaCaine2.Trim() != "") labelCaine2.Text = MainForm.rasaCaine2.Replace('_', ' ');
            if (MainForm.rasaCaine3.Trim() != "") labelCaine3.Text = MainForm.rasaCaine3.Replace('_', ' ');
            labelC1.Text = AccountForm.pretCaine1.ToString() + ",00";
            labelC2.Text = AccountForm.pretCaine2.ToString() + ",00";
            labelC3.Text = AccountForm.pretCaine3.ToString() + ",00";
            labelM1.Text = AccountForm.pretMancare1.ToString() + ",00";
            labelM2.Text = AccountForm.pretMancare2.ToString() + ",00";
            labelM3.Text = AccountForm.pretMancare3.ToString() + ",00";
            labelA1.Text = AccountForm.pretAccesorii1.ToString() + ",00";
            labelA2.Text = AccountForm.pretAccesorii2.ToString() + ",00";
            labelA3.Text = AccountForm.pretAccesorii3.ToString() + ",00";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelCaine2_Click(object sender, EventArgs e)
        {
            if (MainForm.rasaCaine1.Trim() == "") return;
            maiAdaugaCaine2 = true;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void labelCaine3_Click(object sender, EventArgs e)
        {
            if (MainForm.rasaCaine2.Trim() == "") return;
            maiAdaugaCaine3 = true;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
