namespace DogTopia
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelBreed = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxClassify = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.labelText2 = new System.Windows.Forms.Label();
            this.labelText1 = new System.Windows.Forms.Label();
            this.pictureBoxDetails = new System.Windows.Forms.PictureBox();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBreed
            // 
            this.labelBreed.BackColor = System.Drawing.Color.Transparent;
            this.labelBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreed.ForeColor = System.Drawing.Color.Maroon;
            this.labelBreed.Location = new System.Drawing.Point(662, 357);
            this.labelBreed.Name = "labelBreed";
            this.labelBreed.Size = new System.Drawing.Size(264, 83);
            this.labelBreed.TabIndex = 5;
            this.labelBreed.Text = "Press on Add to find out";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::DogTopia.Properties.Resources.Logo1;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(569, 600);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxAddPicture
            // 
            this.pictureBoxAddPicture.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAddPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddPicture.BackgroundImage")));
            this.pictureBoxAddPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAddPicture.Location = new System.Drawing.Point(653, 101);
            this.pictureBoxAddPicture.Name = "pictureBoxAddPicture";
            this.pictureBoxAddPicture.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxAddPicture.TabIndex = 9;
            this.pictureBoxAddPicture.TabStop = false;
            this.pictureBoxAddPicture.Click += new System.EventHandler(this.pictureBoxAddPicture_Click);
            // 
            // pictureBoxClassify
            // 
            this.pictureBoxClassify.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClassify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxClassify.BackgroundImage")));
            this.pictureBoxClassify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxClassify.Location = new System.Drawing.Point(826, 101);
            this.pictureBoxClassify.Name = "pictureBoxClassify";
            this.pictureBoxClassify.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxClassify.TabIndex = 10;
            this.pictureBoxClassify.TabStop = false;
            this.pictureBoxClassify.Click += new System.EventHandler(this.pictureBoxClassify_Click);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.BackgroundImage")));
            this.pictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogin.Location = new System.Drawing.Point(630, 473);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogin.TabIndex = 13;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Visible = false;
            this.pictureBoxLogin.Click += new System.EventHandler(this.pictureBoxLogin_Click);
            // 
            // labelText2
            // 
            this.labelText2.AutoSize = true;
            this.labelText2.BackColor = System.Drawing.Color.Transparent;
            this.labelText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText2.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.labelText2.Location = new System.Drawing.Point(639, 319);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(269, 25);
            this.labelText2.TabIndex = 13;
            this.labelText2.Text = "The breed of this dog is:";
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.BackColor = System.Drawing.Color.Transparent;
            this.labelText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.labelText1.Location = new System.Drawing.Point(648, 9);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(340, 25);
            this.labelText1.TabIndex = 12;
            this.labelText1.Text = "Let\'s find the breed of this dog!";
            // 
            // pictureBoxDetails
            // 
            this.pictureBoxDetails.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetails.BackgroundImage")));
            this.pictureBoxDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDetails.Location = new System.Drawing.Point(826, 473);
            this.pictureBoxDetails.Name = "pictureBoxDetails";
            this.pictureBoxDetails.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxDetails.TabIndex = 14;
            this.pictureBoxDetails.TabStop = false;
            this.pictureBoxDetails.Visible = false;
            this.pictureBoxDetails.Click += new System.EventHandler(this.pictureBoxDetails_Click);
            // 
            // pictureBoxGoBack
            // 
            this.pictureBoxGoBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGoBack.BackgroundImage")));
            this.pictureBoxGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxGoBack.Location = new System.Drawing.Point(575, 0);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(80, 95);
            this.pictureBoxGoBack.TabIndex = 15;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DogTopia.Properties.Resources.Gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pictureBoxGoBack);
            this.Controls.Add(this.pictureBoxDetails);
            this.Controls.Add(this.labelText2);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.labelBreed);
            this.Controls.Add(this.labelText1);
            this.Controls.Add(this.pictureBoxClassify);
            this.Controls.Add(this.pictureBoxAddPicture);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DogTopia";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelBreed;
        private System.Windows.Forms.PictureBox pictureBoxAddPicture;
        private System.Windows.Forms.PictureBox pictureBoxClassify;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxDetails;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
    }
}