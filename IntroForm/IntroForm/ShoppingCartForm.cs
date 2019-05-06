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
        // 0 - Nu se doreste alt caine
        // 1 - Se doreste alt caine, dar utilizatorul se poate razgandi si sa-l pastreze pana la urma
        // 2 - Se doreste alt caine, se alege alt caine.
        public static int altCaine1 = 0;
        public static int altCaine2 = 0;
        public static int altCaine3 = 0;
        public static bool maiAdaugaCaine2 = false;
        public static bool maiAdaugaCaine3 = false;
        public static int total = 0;
        public ShoppingCartForm()
        {
            InitializeComponent();
            if (MainForm.rasaCaine1.Trim() != "")
            {
                labelCaine1.Text = MainForm.rasaCaine1.Replace('_', ' ');
                checkBoxM1.Enabled = checkBoxA1.Enabled = true;
                if (AccountForm.pretMancare1 != 0) checkBoxM1.Checked = true;
                if (AccountForm.pretAccesorii1 != 0) checkBoxA1.Checked = true;
                labelAltCaine1.Visible = true;

                Image imagineCaine = Image.FromFile(MainForm.pathPozaCaine1); // Adauga imaginea cainelui in pictureBoxCaine1
                Size dimensiune = new Size();
                dimensiune.Height = 155;
                dimensiune.Width = 90;
                pictureBoxCaine1.Image = AccountForm.ResizeImage(imagineCaine, dimensiune);

            }
            if (MainForm.rasaCaine2.Trim() != "")
            {
                labelCaine2.Text = MainForm.rasaCaine2.Replace('_', ' ');
                checkBoxM2.Enabled = checkBoxA2.Enabled = true;
                if (AccountForm.pretMancare2 != 0) checkBoxM2.Checked = true;
                if (AccountForm.pretAccesorii2 != 0) checkBoxA2.Checked = true;
                labelAltCaine2.Visible = true;

                Image imagineCaine = Image.FromFile(MainForm.pathPozaCaine2); // Adauga imaginea cainelui in pictureBoxCaine2
                Size dimensiune = new Size();
                dimensiune.Height = 155;
                dimensiune.Width = 90;
                pictureBoxCaine2.Image = AccountForm.ResizeImage(imagineCaine, dimensiune);
            }
            if (MainForm.rasaCaine3.Trim() != "")
            {
                labelCaine3.Text = MainForm.rasaCaine3.Replace('_', ' ');
                checkBoxM3.Enabled = checkBoxA3.Enabled = true;
                if (AccountForm.pretMancare3 != 0) checkBoxM3.Checked = true;
                if (AccountForm.pretAccesorii3 != 0) checkBoxA3.Checked = true;
                labelAltCaine3.Visible = true;

                Image imagineCaine = Image.FromFile(MainForm.pathPozaCaine3); // Adauga imaginea cainelui in pictureBoxCaine3
                Size dimensiune = new Size();
                dimensiune.Height = 155;
                dimensiune.Width = 90;
                pictureBoxCaine3.Image = AccountForm.ResizeImage(imagineCaine, dimensiune);
            }
            labelC1.Text = AccountForm.pretCaine1.ToString() + ",00";
            labelC2.Text = AccountForm.pretCaine2.ToString() + ",00";
            labelC3.Text = AccountForm.pretCaine3.ToString() + ",00";
            total = AccountForm.pretAccesorii1 + AccountForm.pretAccesorii2 + AccountForm.pretAccesorii3 +
                    AccountForm.pretCaine1 + AccountForm.pretCaine2 + AccountForm.pretCaine3 +
                    AccountForm.pretMancare1 + AccountForm.pretMancare2 + AccountForm.pretMancare3;
            labelTotal.Text = total.ToString() + ",00";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelCaine2_Click(object sender, EventArgs e)
        {
            if (MainForm.rasaCaine1.Trim() == "" || MainForm.rasaCaine2.Trim() != "") return;
            maiAdaugaCaine2 = true;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void labelCaine3_Click(object sender, EventArgs e)
        {
            if (MainForm.rasaCaine2.Trim() == "" || MainForm.rasaCaine3.Trim() != "") return;
            maiAdaugaCaine3 = true;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void checkBoxM1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxM1.Checked == true)
            {
                if (AccountForm.pretMancare1 == 0)
                {
                    MessageBox.Show("Nu ați adăugat niciun produs din secțiunea mâncare! S-a adăugat în coșul de cumpărături un pachet Hrană Clasic.",
                        "Lipsă produse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.pretMancare1 = 10;
                    
                }
                labelM1.Text = AccountForm.pretMancare1.ToString() + ",00";
                total += AccountForm.pretMancare1;
            }
            else
            {
                total -= AccountForm.pretMancare1;
                labelM1.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void checkBoxM2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxM2.Checked == true)
            {
                if (AccountForm.pretMancare2 == 0)
                {
                    MessageBox.Show("Nu ați adăugat niciun produs din secțiunea mâncare! S-a adăugat în coșul de cumpărături un pachet Hrană Clasic.",
                        "Lipsă produse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.pretMancare2 = 10;
                }
                labelM2.Text = AccountForm.pretMancare2.ToString() + ",00";
                total += AccountForm.pretMancare2;
            }
            else
            {
                total -= AccountForm.pretMancare2;
                labelM2.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void checkBoxM3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxM3.Checked == true)
            {
                if (AccountForm.pretMancare3 == 0)
                {
                    MessageBox.Show("Nu ați adăugat niciun produs din secțiunea mâncare! S-a adăugat în coșul de cumpărături un pachet Hrană Clasic.",
                        "Lipsă produse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.pretMancare3 = 10;
                }
                labelM3.Text = AccountForm.pretMancare3.ToString() + ",00";
                total += AccountForm.pretMancare3;
            }
            else
            {
                total -= AccountForm.pretMancare3;
                labelM3.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void checkBoxA1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxA1.Checked == true)
            {
                if (AccountForm.pretAccesorii1 == 0)
                {
                    MessageBox.Show("Nu ați adăugat niciun produs din secțiunea mâncare! S-a adăugat în coșul de cumpărături un pachet Accesorii Clasic.",
                        "Lipsă produse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.pretAccesorii1 = 17;
                }
                labelA1.Text = AccountForm.pretAccesorii1.ToString() + ",00";
                total += AccountForm.pretAccesorii1;
            }
            else
            {
                total -= AccountForm.pretAccesorii1;
                labelA1.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void checkBoxA2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxA2.Checked == true)
            {
                if (AccountForm.pretAccesorii2 == 0)
                {
                    MessageBox.Show("Nu ați adăugat niciun produs din secțiunea mâncare! S-a adăugat în coșul de cumpărături un pachet Accesorii Clasic.",
                        "Lipsă produse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.pretAccesorii2 = 17;
                }
                labelA2.Text = AccountForm.pretAccesorii2.ToString() + ",00";
                total += AccountForm.pretAccesorii2;
            }
            else
            {
                total -= AccountForm.pretAccesorii2;
                labelA2.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void checkBoxA3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxA3.Checked == true)
            {
                if (AccountForm.pretAccesorii3 == 0)
                {
                    MessageBox.Show("Nu ați adăugat niciun produs din secțiunea mâncare! S-a adăugat în coșul de cumpărături un pachet Accesorii Clasic.",
                        "Lipsă produse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountForm.pretAccesorii3 = 17;
                }
                labelA3.Text = AccountForm.pretAccesorii3.ToString() + ",00";
                total += AccountForm.pretAccesorii3;
            }
            else
            {
                total -= AccountForm.pretAccesorii3;
                labelA3.Text = "0,00";
            }
            labelTotal.Text = total.ToString() + ",00";
        }

        private void labelCaine1_Click(object sender, EventArgs e)
        {
            if (MainForm.rasaCaine1.Trim() != "") return;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void labelAltCaine1_Click(object sender, EventArgs e)
        {
            altCaine1 = 1;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void labelAltCaine2_Click(object sender, EventArgs e)
        {
            altCaine2 = 1;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void labelAltCaine3_Click(object sender, EventArgs e)
        {
            altCaine3 = 1;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccountForm acc = new AccountForm();
            acc.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("Coșul de cumpărături este gol!", "Coș de cumpărături gol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PayForm pf = new PayForm();
            pf.Show();
            this.Hide();
        }
    }
}