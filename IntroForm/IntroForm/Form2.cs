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
    public partial class Form2 : Form
    {

        // aici o sa vina o functie de resize pt poza(mai jos, dar aici...)

        string pathPoza = "";
        public Form2()
        {
            InitializeComponent();
            labelRasa.Text = "";

            // panel1 contine urmatoarele: labelRasa, cu textul aferent si butonul de login
            // initial sunt ascunse
            panel1.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labelRasa.Text = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathPoza = ofd.FileName;
                pictureBoxPoza.Image = Image.FromFile(pathPoza);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*
            // Daca utilizator nu a introdus nicio poza, nu se va putea clasifica.
            if (pathPoza == "") return;

            labelRasa.Text = "";
            // full path of python interpreter 
            string python = @"C:\Users\Admin\Anaconda3\python.exe";
            string myPythonApp = @"C:\Atestat\classificator.py";

            // dummy parameters to send Python script  
            string s = pathPoza;
            // Create new process start info 
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);

            // make sure we can read the output from stdout
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;
            myProcessStartInfo.WorkingDirectory = @"C:\Users\Admin\Anaconda3\";
            myProcessStartInfo.CreateNoWindow = true;

            // start python app with 3 arguments  
            // 1st argument is pointer to itself, 2nd and 3rd are actual arguments we want to send 
            myProcessStartInfo.Arguments = myPythonApp + " " + s;

            Process myProcess = new Process();
            // assign start information to the process 
            myProcess.StartInfo = myProcessStartInfo;

            // start process 
            myProcess.Start();

            // Read the standard output of the app we called.  
            StreamReader myStreamReader = myProcess.StandardOutput;
            string myString = myStreamReader.ReadLine();

            // wait exit signal from the app we called 
            myProcess.WaitForExit();

            // close the process 
            myProcess.Close();

            // write the output we got from python app 
            //Console.WriteLine("Value received from script: " + myString);
            labelRasa.Text = myString;
            */

            // daca utilizatorul apasa butonul Clasifica, panel1 apare, semn ca acesta si-a ales un caine.
            panel1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }
    }
}
