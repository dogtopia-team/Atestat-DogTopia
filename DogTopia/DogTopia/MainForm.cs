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
        public static string stBreedDog = "";
        public static string ndBreedDog = "";
        public static string rdBreedDog = "";
        public static string breedCurrentDog = ""; // The breed of the current classified dog
        public static string pathPicture = "";
        public static string pathPictureStDog = "";
        public static string pathPictureNdDog = "";
        public static string pathPictureRdDog = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBoxAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathPicture = ofd.FileName;
                if (pathPicture == pathPictureStDog || pathPicture == pathPictureNdDog || pathPicture == pathPictureRdDog)
                {
                    MessageBox.Show("You have already introduced this dog! Choose another dog!", "Duplicate content", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Image imageDog = Image.FromFile(pathPicture);
                Size dimension = new Size();
                dimension.Height = 600;
                dimension.Width = 569;
                pictureBoxLogo.BackgroundImage = AccountForm.ResizeImage(imageDog, dimension);
                labelBreed.Text = "Press on Classify and wait for processing!";
            }
        }

        private void pictureBoxClassify_Click(object sender, EventArgs e)
        {

            // If the user introduces no picture, the classifier will not start
            if (pathPicture == "") return;

            // Full path of python interpreter 
            string python = @"C:\Users\Cosmin\Anaconda3\python.exe";
            string myPythonApp = IntroForm.pathWorkingDirectory + @"classifier\main.py";
           // string myPythonApp = @"C:\Users\Cosmin\PycharmProjects\classifier\main.py";

            // Create a new process to communicate with the Python Script
            ProcessStartInfo proccesStartInfo = new ProcessStartInfo(python);

            // Make sure the output will be read from the stdout channel
            proccesStartInfo.UseShellExecute = false;
            proccesStartInfo.RedirectStandardOutput = true;
            proccesStartInfo.WorkingDirectory = @"C:\Users\Cosmin\Anaconda3\";
            proccesStartInfo.CreateNoWindow = true;

            // Run the Python Script with 2 arguments
            // The first argument will be a pointer to itself, the second argument will be a path to the picture.
            proccesStartInfo.Arguments = myPythonApp + " " + pathPicture;

            Process pythonProcess = new Process();
            // Set the Start information
            pythonProcess.StartInfo = proccesStartInfo;

            // Start the process
            pythonProcess.Start();

            // Read the standard output of the called script
            StreamReader streamReader = pythonProcess.StandardOutput;
            string breedClassifiedDog = streamReader.ReadLine();

            // Wait for the exit signal of the process
            pythonProcess.WaitForExit();

            // Close the process
            pythonProcess.Close();

            // Random generation of the dog's price
            Random r = new Random();
            int price = (r.Next(100, 1500) / 10) * 10;

            if (ShoppingCartForm.anotherDogSt == 1) ShoppingCartForm.anotherDogSt = 2;
            if (ShoppingCartForm.anotherDogNd == 1) ShoppingCartForm.anotherDogNd = 2;
            if (ShoppingCartForm.anotherDogRd == 1) ShoppingCartForm.anotherDogRd = 2;

            if (stBreedDog.Trim() == "" || ShoppingCartForm.anotherDogSt == 2 || (ShoppingCartForm.addSecondDog == false && ShoppingCartForm.addThirdDog == false))
            {
                stBreedDog = breedClassifiedDog;
                breedCurrentDog = stBreedDog;
                pathPictureStDog = pathPicture;
                AccountForm.priceStDog = price;
                AccountForm.priceFoodStDog = AccountForm.priceAccessoriesStDog = ShoppingCartForm.anotherDogSt = 0;
            }
            else if ((ndBreedDog.Trim() == "" && ShoppingCartForm.addSecondDog == true) || ShoppingCartForm.anotherDogNd == 2 || ShoppingCartForm.addThirdDog == false)
            {
                ndBreedDog = breedClassifiedDog;
                breedCurrentDog = ndBreedDog;
                pathPictureNdDog = pathPicture;
                AccountForm.priceNdDog = price;
                AccountForm.priceFoodNdDog = AccountForm.priceAccessoriesNdDog = ShoppingCartForm.anotherDogNd = 0;
            }
            else if ((rdBreedDog.Trim() == "" && ShoppingCartForm.addThirdDog == true) || ShoppingCartForm.anotherDogRd == 2  || 
                (stBreedDog.Trim() != "" && ndBreedDog.Trim() != ""))
            {
                rdBreedDog = breedClassifiedDog;
                breedCurrentDog = rdBreedDog;
                pathPictureRdDog = pathPicture;
                AccountForm.priceRdDog = price;
                AccountForm.priceFoodRdDog = AccountForm.priceAccessoriesRdDog = ShoppingCartForm.anotherDogRd = 0;
            }
            labelBreed.Text = breedCurrentDog.Replace('_', ' ');
            pictureBoxLogin.Show();
            pictureBoxDetails.Visible = true;
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
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

            // Reinitialization of the choices in the "Accessories" Tab
            AccessoriesForm.buyAccessory1 = AccessoriesForm.buyAccessory2 = AccessoriesForm.buyAccessory3 = AccessoriesForm.buyAccessory4 =
                AccessoriesForm.buyAccessory5 = AccessoriesForm.buyAccessory6 = false;
            // Reinitialization of the choices in the "Food" Tab
            FoodForm.buyFood1 = FoodForm.buyFood2 = FoodForm.buyFood3 = FoodForm.buyFood4 =
                FoodForm.buyFood5 = FoodForm.buyFood6 = false;
        }

        private void pictureBoxDetails_Click(object sender, EventArgs e)
        {
            if (breedCurrentDog == "") // Case where the dog was not successfully classified.
            {
                MessageBox.Show("The breed of the dog is missing", "Incorrect breed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string pathWikipediaBreed = @"https://google.com/search?q=";
            pathWikipediaBreed += breedCurrentDog.Replace('_', '+');
            Process.Start("chrome.exe", pathWikipediaBreed);
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            if (pathPicture != pathPictureStDog && pathPicture != pathPictureNdDog && pathPicture != pathPictureRdDog)
            {
                if (pathPictureRdDog.Trim() != "") pathPicture = pathPictureRdDog;
                 else if (pathPictureNdDog.Trim() != "") pathPicture = pathPictureNdDog;
                  else pathPicture = pathPictureStDog;
            }
            IntroForm introForm = new IntroForm();
            introForm.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
