using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogTopia
{
    public partial class MainForm : Form
    {
        public static string rasaCaine1 = "";
        public static string rasaCaine2 = "";
        public static string rasaCaine3 = "";
        public static string rasaCaineCurent = ""; // Rasa celui mai curent caine clasificat
        public static string pathPoza = "";
        public static string pathPozaCaine1 = "";
        public static string pathPozaCaine2 = "";
        public static string pathPozaCaine3 = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathPoza = ofd.FileName;
                if (pathPoza == pathPozaCaine1 || pathPoza == pathPozaCaine2 || pathPoza == pathPozaCaine3)
                {
                    MessageBox.Show("Ați introdus deja acest câine! Alegeți alt câine!", "Duplicare conținut", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Image imagineCaine = Image.FromFile(pathPoza);
                Size dimensiune = new Size();
                dimensiune.Height = 600;
                dimensiune.Width = 569;
                pictureBoxPoza.BackgroundImage = AccountForm.ResizeImage(imagineCaine, dimensiune);
                labelRasa.Text = "Apăsați pe Clasifică și așteptați să se proceseze!";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            // Daca utilizatorul nu a introdus nicio poza, nu se va putea clasifica.
            if (pathPoza == "") return;

            // full path of python interpreter 
            string python = @"C:\Users\Cosmin\Anaconda3\python.exe";
            string myPythonApp = @"C:\Users\Cosmin\PycharmProjects\pls\main.py";

            // Creeaza un nou proces care realizeaza comunicarea 
            // intre algoritmul de recunoastere a rasei si aplicatia C#
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);

            // Ne asiguram ca putem citi outputul din stdout
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;
            myProcessStartInfo.WorkingDirectory = @"C:\Users\Cosmin\Anaconda3\";
            myProcessStartInfo.CreateNoWindow = true;

            // Incepe aplicatia Python cu 2 parametri:
            // Primul este un pointer catre ea insasi, al doilea este calea fotografiei.
            myProcessStartInfo.Arguments = myPythonApp + " " + pathPoza;

            Process myProcess = new Process();
            // Seteaza informatia de start a procesului
            myProcess.StartInfo = myProcessStartInfo;

            // Se da startul procesului
            myProcess.Start();

            // Citeste output-ul standard al aplicatiei pe care am apelat-o
            StreamReader myStreamReader = myProcess.StandardOutput;
            string myString = myStreamReader.ReadLine();

            // Asteptam pentru a primi semnalul de inchidere al aplicatiei pe care am apelat-o
            myProcess.WaitForExit();

            // Inchide procesul
            myProcess.Close();

            Random r = new Random();
            int pret = (r.Next(100, 1500) / 10) * 10;

            if (ShoppingCartForm.altCaine1 == 1) ShoppingCartForm.altCaine1 = 2;
            if (ShoppingCartForm.altCaine2 == 1) ShoppingCartForm.altCaine2 = 2;
            if (ShoppingCartForm.altCaine3 == 1) ShoppingCartForm.altCaine3 = 2;

            if (rasaCaine1.Trim() == "" || ShoppingCartForm.altCaine1 == 2 || (ShoppingCartForm.maiAdaugaCaine2 == false && ShoppingCartForm.maiAdaugaCaine3 == false))
            {
                rasaCaine1 = myString;
                rasaCaineCurent = rasaCaine1;
                pathPozaCaine1 = pathPoza;
                AccountForm.pretCaine1 = pret;
                AccountForm.pretMancare1 = AccountForm.pretAccesorii1 = ShoppingCartForm.altCaine1 = 0;
            }
            else if ((rasaCaine2.Trim() == "" && ShoppingCartForm.maiAdaugaCaine2 == true) || ShoppingCartForm.altCaine2 == 2 || ShoppingCartForm.maiAdaugaCaine3 == false)
            {
                rasaCaine2 = myString;
                rasaCaineCurent = rasaCaine2;
                pathPozaCaine2 = pathPoza;
                AccountForm.pretCaine2 = pret;
                AccountForm.pretMancare2 = AccountForm.pretAccesorii2 = ShoppingCartForm.altCaine2 = 0;
            }
            else if ((rasaCaine3.Trim() == "" && ShoppingCartForm.maiAdaugaCaine3 == true) || ShoppingCartForm.altCaine3 == 2  || 
                (rasaCaine1.Trim() != "" && rasaCaine2.Trim() != ""))
            {
                rasaCaine3 = myString;
                rasaCaineCurent = rasaCaine3;
                pathPozaCaine3 = pathPoza;
                AccountForm.pretCaine3 = pret;
                AccountForm.pretMancare3 = AccountForm.pretAccesorii3 = ShoppingCartForm.altCaine3 = 0;
            }
            labelRasa.Text = rasaCaineCurent.Replace('_', ' ');
            pictureBox3.Show();
            pictureBox4.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (LoginForm.isLoggedIn == true)
            {
                AccountForm accountForm = new AccountForm();
                accountForm.Show();
                this.Hide();
            }
            else
            {
                LoginForm loginform = new LoginForm();
                loginform.Show();
                this.Hide();
            }

            // Reintializam alegerile din "Accessorii"
            AccessoriesForm.cumparaAc1 = AccessoriesForm.cumparaAc2 = AccessoriesForm.cumparaAc3 = AccessoriesForm.cumparaAc4 =
                AccessoriesForm.cumparaAc5 = AccessoriesForm.cumparaAc6 = false;
            // Reintializam alegerile din "Food"
            FoodForm.cumparaFood1 = FoodForm.cumparaFood2 = FoodForm.cumparaFood3 = FoodForm.cumparaFood4 =
                FoodForm.cumparaFood5 = FoodForm.cumparaFood6 = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (rasaCaineCurent == "") // Cazul in care nu s-a clasificat inca poza
            {
                MessageBox.Show("Mai întâi aflați rasa câinelui!", "Lipsă rasă de câine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string pathWikipediaRasa = @"https://google.com/search?q=";
            pathWikipediaRasa += rasaCaineCurent.Replace('_', '+');
            Process.Start("chrome.exe", pathWikipediaRasa);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pathPoza != pathPozaCaine1 && pathPoza != pathPozaCaine2 && pathPoza != pathPozaCaine3)
            {
                if (pathPozaCaine3.Trim() != "") pathPoza = pathPozaCaine3;
                 else if (pathPozaCaine2.Trim() != "") pathPoza = pathPozaCaine2;
                  else pathPoza = pathPozaCaine1;
            }
            IntroForm intr = new IntroForm();
            intr.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
