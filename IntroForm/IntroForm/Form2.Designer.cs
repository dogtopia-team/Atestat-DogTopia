namespace IntroForm
{
    partial class Form2
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
            this.buttonAdaugaPoza = new System.Windows.Forms.Button();
            this.buttonClasifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRasa = new System.Windows.Forms.Label();
            this.pictureBoxPoza = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoza)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdaugaPoza
            // 
            this.buttonAdaugaPoza.Location = new System.Drawing.Point(855, 63);
            this.buttonAdaugaPoza.Name = "buttonAdaugaPoza";
            this.buttonAdaugaPoza.Size = new System.Drawing.Size(106, 52);
            this.buttonAdaugaPoza.TabIndex = 0;
            this.buttonAdaugaPoza.Text = "Adauga";
            this.buttonAdaugaPoza.UseVisualStyleBackColor = true;
            this.buttonAdaugaPoza.Click += new System.EventHandler(this.buttonAdaugaPoza_Click);
            // 
            // buttonClasifica
            // 
            this.buttonClasifica.Location = new System.Drawing.Point(855, 374);
            this.buttonClasifica.Name = "buttonClasifica";
            this.buttonClasifica.Size = new System.Drawing.Size(106, 52);
            this.buttonClasifica.TabIndex = 2;
            this.buttonClasifica.Text = "Clasifica";
            this.buttonClasifica.UseVisualStyleBackColor = true;
            this.buttonClasifica.Click += new System.EventHandler(this.buttonClasifica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rasa acestui caine este:";
            // 
            // labelRasa
            // 
            this.labelRasa.AutoSize = true;
            this.labelRasa.BackColor = System.Drawing.Color.Transparent;
            this.labelRasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRasa.Location = new System.Drawing.Point(823, 470);
            this.labelRasa.Name = "labelRasa";
            this.labelRasa.Size = new System.Drawing.Size(60, 24);
            this.labelRasa.TabIndex = 5;
            this.labelRasa.Text = "label2";
            // 
            // pictureBoxPoza
            // 
            this.pictureBoxPoza.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPoza.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPoza.Name = "pictureBoxPoza";
            this.pictureBoxPoza.Size = new System.Drawing.Size(569, 499);
            this.pictureBoxPoza.TabIndex = 3;
            this.pictureBoxPoza.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(955, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IntroForm.Properties.Resources.Gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRasa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxPoza);
            this.Controls.Add(this.buttonClasifica);
            this.Controls.Add(this.buttonAdaugaPoza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaseset rasa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdaugaPoza;
        private System.Windows.Forms.Button buttonClasifica;
        private System.Windows.Forms.PictureBox pictureBoxPoza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRasa;
        private System.Windows.Forms.Label label4;
    }
}