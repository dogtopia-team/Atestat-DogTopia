namespace DogTopia
{
    partial class PayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelDetailsAccount = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.labelSlash = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelCodeCVV = new System.Windows.Forms.Label();
            this.textBoxCVVCode = new System.Windows.Forms.TextBox();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.pictureBoxPlaceOrder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaceOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::DogTopia.Properties.Resources.Logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(175, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelDetailsAccount
            // 
            this.labelDetailsAccount.AutoSize = true;
            this.labelDetailsAccount.BackColor = System.Drawing.Color.Transparent;
            this.labelDetailsAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailsAccount.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDetailsAccount.Location = new System.Drawing.Point(12, 282);
            this.labelDetailsAccount.Name = "labelDetailsAccount";
            this.labelDetailsAccount.Size = new System.Drawing.Size(207, 31);
            this.labelDetailsAccount.TabIndex = 2;
            this.labelDetailsAccount.Text = "Account details:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(203, 328);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(158, 26);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 328);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(185, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "First name and surname:";
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNumber.Location = new System.Drawing.Point(92, 357);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(105, 20);
            this.labelCardNumber.TabIndex = 6;
            this.labelCardNumber.Text = "Card number:";
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCardNumber.Location = new System.Drawing.Point(203, 357);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(158, 26);
            this.textBoxCardNumber.TabIndex = 5;
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.labelExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpirationDate.Location = new System.Drawing.Point(78, 388);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(119, 20);
            this.labelExpirationDate.TabIndex = 8;
            this.labelExpirationDate.Text = "Expiration date:";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonth.Location = new System.Drawing.Point(203, 385);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(34, 26);
            this.textBoxMonth.TabIndex = 7;
            this.textBoxMonth.Text = "MM";
            // 
            // labelSlash
            // 
            this.labelSlash.AutoSize = true;
            this.labelSlash.BackColor = System.Drawing.Color.Transparent;
            this.labelSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlash.Location = new System.Drawing.Point(243, 384);
            this.labelSlash.Name = "labelSlash";
            this.labelSlash.Size = new System.Drawing.Size(20, 29);
            this.labelSlash.TabIndex = 9;
            this.labelSlash.Text = "/";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(269, 385);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(34, 26);
            this.textBoxYear.TabIndex = 10;
            this.textBoxYear.Text = "YY";
            // 
            // labelCodeCVV
            // 
            this.labelCodeCVV.AutoSize = true;
            this.labelCodeCVV.BackColor = System.Drawing.Color.Transparent;
            this.labelCodeCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodeCVV.Location = new System.Drawing.Point(78, 417);
            this.labelCodeCVV.Name = "labelCodeCVV";
            this.labelCodeCVV.Size = new System.Drawing.Size(122, 20);
            this.labelCodeCVV.TabIndex = 12;
            this.labelCodeCVV.Text = "CVV/CVC code:";
            // 
            // textBoxCVVCode
            // 
            this.textBoxCVVCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCVVCode.Location = new System.Drawing.Point(200, 414);
            this.textBoxCVVCode.Name = "textBoxCVVCode";
            this.textBoxCVVCode.Size = new System.Drawing.Size(158, 26);
            this.textBoxCVVCode.TabIndex = 11;
            // 
            // pictureBoxGoBack
            // 
            this.pictureBoxGoBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGoBack.BackgroundImage = global::DogTopia.Properties.Resources.btnBack;
            this.pictureBoxGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxGoBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(73, 73);
            this.pictureBoxGoBack.TabIndex = 38;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTotal.Location = new System.Drawing.Point(140, 447);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(45, 24);
            this.labelTotal.TabIndex = 40;
            this.labelTotal.Text = "0,00";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelTotalPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTotalPrice.Location = new System.Drawing.Point(78, 447);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(56, 24);
            this.labelTotalPrice.TabIndex = 41;
            this.labelTotalPrice.Text = "Total:";
            // 
            // pictureBoxPlaceOrder
            // 
            this.pictureBoxPlaceOrder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlaceOrder.BackgroundImage = global::DogTopia.Properties.Resources.btn_comanda;
            this.pictureBoxPlaceOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPlaceOrder.Location = new System.Drawing.Point(203, 495);
            this.pictureBoxPlaceOrder.Name = "pictureBoxPlaceOrder";
            this.pictureBoxPlaceOrder.Size = new System.Drawing.Size(250, 93);
            this.pictureBoxPlaceOrder.TabIndex = 42;
            this.pictureBoxPlaceOrder.TabStop = false;
            this.pictureBoxPlaceOrder.Click += new System.EventHandler(this.pictureBoxPlaceOrder_Click);
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DogTopia.Properties.Resources.Gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.pictureBoxPlaceOrder);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.pictureBoxGoBack);
            this.Controls.Add(this.labelCodeCVV);
            this.Controls.Add(this.textBoxCVVCode);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelSlash);
            this.Controls.Add(this.labelExpirationDate);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDetailsAccount);
            this.Controls.Add(this.pictureBoxLogo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DogTopia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaceOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelDetailsAccount;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Label labelSlash;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelCodeCVV;
        private System.Windows.Forms.TextBox textBoxCVVCode;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.PictureBox pictureBoxPlaceOrder;
    }
}