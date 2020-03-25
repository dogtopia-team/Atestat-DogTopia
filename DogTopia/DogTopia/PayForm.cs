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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
            labelTotal.Text = ShoppingCartForm.total.ToString() + ",00";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            textBoxName.CharacterCasing = CharacterCasing.Upper;
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            ShoppingCartForm shoppingCartForm = new ShoppingCartForm();
            shoppingCartForm.Show();
            this.Hide();
        }

        private void pictureBoxPlaceOrder_Click(object sender, EventArgs e)
        {
            // Verify the First Name and the Surname (minimum 2 characters)
            int numberWords = textBoxName.Text.Split(' ').Length;
            if (numberWords < 2)
            {
                MessageBox.Show("Introduce the First Name and the Surname", "Incomplete field.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Clear();
                return;
            }

            // Verify Card Number (PIN) - 16 digits, other charcters are not allowed
            int lengthCardNumber = textBoxCardNumber.Text.Length;
            if (lengthCardNumber != 16)
            {
                MessageBox.Show("The Card Number needs to be 16 digits long!", "Invalid Card Number.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCardNumber.Clear();
                return;
            }
            string cardNumber = textBoxCardNumber.Text.Trim();
            for (int index = 0; index < cardNumber.Length; index++)
            {
                if (!char.IsNumber(cardNumber[index]))
                {
                    MessageBox.Show("The Card Number can only have digits!", "Invalid Card Number.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCardNumber.Clear();
                    return;
                }
            }

            // Verify if the expiration date is greater or equal than the current date
            DateTime cardDate;
            DateTime currentDate = DateTime.Now;
            int month = 0;
            if (!int.TryParse(textBoxMonth.Text, out month))
            {
                MessageBox.Show("Introduce only digits corresponding to the month.", "Month - invalid characters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMonth.Clear();
                return;
            }

            int year = 0;
            if (!int.TryParse(textBoxYear.Text, out year))
            {
                MessageBox.Show("Introduce only digits corresponding to the year.", "Year - invalid characters.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYear.Clear();
                return;
            }

            cardDate = new DateTime(2000 + year, month, 1, 0, 0, 0);
            int resultCompare = DateTime.Compare(currentDate, cardDate);
            if (resultCompare > 0)
            {
                MessageBox.Show("Introduce the date of a valid card!", "Expired card.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verify the CVV/CVC code - 3 digits, other characters are not allowed
            int lengthCode = textBoxCVVCode.Text.Length;
            if (lengthCode != 3)
            {
                MessageBox.Show("The CVV/CVC code can only have 3 digits!", "Invalid CVV/CVC code.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCVVCode.Clear();
                return;
            }

            string CVC = textBoxCVVCode.Text.Trim();
            for (int i = 0; i < CVC.Length; i++)
            {
                if (!char.IsNumber(CVC[i]))
                {
                    MessageBox.Show("The CVV/CVC code can only have digits", "Invalid CVV/CVC code.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCVVCode.Clear();
                    return;
                }
            }

            // A message box is shown for order confirmation
            MessageBox.Show("The order has been placed! Thank you!", "Confirmed order.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // If everything works, go back to AccountForm
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
            this.Hide();
        }
    }
}
