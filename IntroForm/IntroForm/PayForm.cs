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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.CharacterCasing = CharacterCasing.Upper;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //verificare Nume si prenume(obligatoriu minim 2 cuvinte)
            int nr_cuv = textBox1.Text.Split(' ').Length;
            
            if(nr_cuv < 2)
            {
                MessageBox.Show("Introduceti NUME si PRENUME", "Camp incomplet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                return;
            }

            //verificare PIN(16 cifre, fara alte caractere)
            int lng = textBox2.Text.Length;
            if (lng != 16)
            {
                MessageBox.Show("Codul PIN trebuie sa aiba 16 cifre!", "Cod PIN invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                return;
            }

            string PIN = textBox2.Text.Trim();

            for (int i = 0; i < PIN.Length ; i++)
            {
                if(!char.IsNumber(PIN[i]))
                {
                    MessageBox.Show("Codul PIN trebuie sa aiba DOAR cifre!", "Cod PIN invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                    return;
                }
            }



            //verificare daca data expirarii cardului este mai mare sau egala decat data curenta
            DateTime dataCard;
            DateTime dataCurenta = DateTime.Now;

            int luna;
            if (!int.TryParse(textBox3.Text, out luna))
            {
                MessageBox.Show("Introduceti doar cifrele corespunzatoare lunii", "Luna - caractere invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Clear();
                return;
            }

            int an;
            if (!int.TryParse(textBox4.Text, out an))
            {
                MessageBox.Show("Introduceti doar cifrele corespunzatoare anului", "An - caractere invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Clear();
                return;
            }

            dataCard = new DateTime(2000 + an, luna, 1, 0, 0, 0);

            int result = DateTime.Compare(dataCurenta, dataCard);

            if (result > 0)
            {
                MessageBox.Show("Introduceti datele unui card valabil", "Card expirat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //verificare cod CVV/CVC (3 cifre, fara alte caractere)
            int lngC = textBox5.Text.Length;
            if (lngC != 3)
            {
                MessageBox.Show("Codul CVV/CVC trebuie sa aiba 3 cifre!", "Cod PIN invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Clear();
                return;
            }

            string CVC = textBox5.Text.Trim();

            for (int i = 0; i < CVC.Length; i++)
            {
                if (!char.IsNumber(CVC[i]))
                {
                    MessageBox.Show("Codul CVV/CVC trebuie sa aiba DOAR cifre!", "Cod PIN invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox5.Clear();
                    return;
                }
            }

            //se afiseaza un MessageBox, pentru confirmarea comenzii
            MessageBox.Show("Comanda a fost plasata! Va multumim!", "Confirmare comanda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //se face legatura cu AccountForm, daca totul este in regula
            AccountForm acc = new AccountForm();
            acc.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShoppingCartForm shop = new ShoppingCartForm();
            shop.Show();
            this.Hide();
        }
    }
}
