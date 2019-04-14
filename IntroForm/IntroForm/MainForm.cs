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

namespace IntroForm
{
    public partial class MainForm : Form
    {
        public static string rasaCaine = "";
        public static string pathPoza = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static Image ResizeImage(Image image, Size newSize)
        {
            Image newImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics GFX = Graphics.FromImage((Bitmap)newImage))
            {
                GFX.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }
            return newImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathPoza = ofd.FileName;
                Image imagineCaine = Image.FromFile(pathPoza);
                Size dimensiune = new Size();
                dimensiune.Height = 600;
                dimensiune.Width = 569;
                pictureBoxPoza.Image = ResizeImage(imagineCaine, dimensiune);
                labelRasa.Text = "Apăsați pe Clasifică și așteptați să se proceseze!";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            // Daca utilizatorul nu a introdus nicio poza, nu se va putea clasifica.
            if (pathPoza == "") return;

            // full path of python interpreter 
            string python = @"C:\Users\Admin\Anaconda3\python.exe";
            string myPythonApp = @"C:\Atestat\classificator.py";

            // Creeaza un nou proces care realizeaza comunicarea 
            // intre algoritmul de recunoastere a rasei si aplicatia C#
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);

            // Ne asiguram ca putem citi outputul din stdout
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;
            myProcessStartInfo.WorkingDirectory = @"C:\Users\Admin\Anaconda3\";
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

            // Afiseaza output-ul (rasa cainelui) pe care l-am primit
            rasaCaine = myString;
            labelRasa.Text = rasaCaine.Replace('_', ' ');
            pictureBox3.Show();
            pictureBox4.Visible = true; 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (rasaCaine == "") // Cazul in care nu s-a clasificat inca poza
            {
                MessageBox.Show("Mai întâi aflați rasa câinelui!");
                return;
            }
            string pathWikipediaRasa = @"https://en.wikipedia.org/wiki/";
            pathWikipediaRasa += rasaCaine;
            Process.Start("chrome.exe", pathWikipediaRasa);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            IntroForm intr = new IntroForm();
            intr.Show();
            this.Hide();
        }
    }
}
