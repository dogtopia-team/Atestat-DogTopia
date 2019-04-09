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

        string pathPoza = "";
        public Form2()
        {
            InitializeComponent();
            labelRasa.Text = "";
        }

        private void buttonAdaugaPoza_Click(object sender, EventArgs e)
        {
            labelRasa.Text = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathPoza = ofd.FileName;
            }
        }

        private void buttonAfiseazaPoza_Click(object sender, EventArgs e)
        {
            if (pathPoza != "") pictureBoxPoza.Image = Image.FromFile(pathPoza);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClasifica_Click(object sender, EventArgs e)
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
        }
    }
}
