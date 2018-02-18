using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Booby
{
    public class Program
    {
        // Define static variables shared by class methods.
        private static System.Text.StringBuilder sortOutput = null;
        private static int numOutputLines = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public void installChocolatey()
        {
            string output = String.Empty;
            string installCommand = "Set-ExecutionPolicy Bypass -Scope Process -Force; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "powershell.exe";
            startInfo.Arguments = installCommand;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            process.StartInfo = startInfo;
            process.Start();

            StreamReader reader = process.StandardOutput;
            output = reader.ReadToEnd();
            MessageBox.Show(output);
            MessageBox.Show("Now installing Git. Press any key to continue...");
            InstallGit();

            process.Close();
        }

        public void InstallGit()
        {
            try
            {
                string output = String.Empty;
                string error = String.Empty;
                string installCommand = @"install git -params '/GitAndUnixToolsOnPath'";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\ProgramData\chocolatey\bin\choco.exe";
                startInfo.Arguments = installCommand;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;

                process.StartInfo.RedirectStandardError = true;
                process.StartInfo = startInfo;
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void WhoAmI(string name, string email)
        {
            try
            {
                //Email
                string output = String.Empty;
                string error = String.Empty;
                string installCommand = @"config --global user.email " + "\"" + email + "\"";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\Git\cmd\git.exe";
                startInfo.Arguments = installCommand;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;

                process.StartInfo.RedirectStandardError = true;
                process.StartInfo = startInfo;
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);

                //Name
                output = String.Empty;
                error = String.Empty;
                installCommand = @"config --global user.name " + "\"" + name + "\"";
                System.Diagnostics.Process process2 = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo2 = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo2.FileName = @"C:\Program Files\Git\cmd\git.exe";
                startInfo2.Arguments = installCommand;
                startInfo2.RedirectStandardOutput = true;
                startInfo2.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;

                process2.StartInfo.RedirectStandardError = true;
                process2.StartInfo = startInfo;
                process2.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);
            }

            catch (Exception ex2)
            {
                MessageBox.Show(ex2.ToString());
            }
        }

        public void Clone(string username, string repository)
        {
            try
            {
                string output = String.Empty;
                string error = String.Empty;
                string installCommand = @"clone https://github.com/" + username + @"/" + repository + ".git";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\Git\cmd\git.exe";
                startInfo.Arguments = installCommand;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;

                process.StartInfo.RedirectStandardError = true;
                process.StartInfo = startInfo;
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CreateNewBranch(string branch, string baseBranch, string repository)
        {
            try
            {
                //Checkout
                string output = String.Empty;
                string error = String.Empty;
                string installCommand = @"checkout -b " + branch + " " + baseBranch;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\Git\cmd\git.exe";
                startInfo.Arguments = installCommand;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + repository;

                process.StartInfo.RedirectStandardError = true;
                process.StartInfo = startInfo;
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetStatus(string repository)
        {
            try
            {
                //Checkout
                string output = String.Empty;
                string error = String.Empty;
                string installCommand = @"status";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\Git\cmd\git.exe";
                startInfo.Arguments = installCommand;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + repository;

                process.StartInfo.RedirectStandardError = true;
                process.StartInfo = startInfo;
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void EditFile(string repository)
        {
            System.Diagnostics.Process.Start(repository);
        }

        public string[] BrowseRepository(string repository)
        {
            OpenFileDialog thisDialog = new OpenFileDialog();

            thisDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + repository;
            thisDialog.Multiselect = true;
            thisDialog.Title = "Please Select Source File(s) for Staging";

            if (thisDialog.ShowDialog() == DialogResult.OK)
            {
                return thisDialog.FileNames;
            }

            else return null;
        }

        public void StagingArea(string repository, string fileName)
        {
            try
            {
                //Checkout
                string output = String.Empty;
                string error = String.Empty;
                string installCommand = @"add " + fileName;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\Git\cmd\git.exe";
                startInfo.Arguments = installCommand;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + repository;

                process.StartInfo.RedirectStandardError = true;
                process.StartInfo = startInfo;
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Commit(string repository, string message)
        {
            try
            {
                //Checkout
                string output = String.Empty;
                string error = String.Empty;
                string installCommand = @"commit -m " + "\"" + message + "\"";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\Git\cmd\git.exe";
                startInfo.Arguments = installCommand;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + repository;

                process.StartInfo.RedirectStandardError = true;
                process.StartInfo = startInfo;
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Push(string repository)
        {
            try
            {
                //Checkout
                string output = String.Empty;
                string error = String.Empty;
                string installCommand = String.Empty;
                string currentBranch = GetCurrentBranch(repository).Replace("\n", "");

                installCommand = @"push --set-upstream origin " + currentBranch;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\Git\cmd\git.exe";
                startInfo.Arguments = installCommand;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + repository;

                process.StartInfo.RedirectStandardError = true;
                process.StartInfo = startInfo;
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Incorporate(string repository, string fork, string mergee)
        {
            try
            {
                //Checkout
                string output = String.Empty;
                string error = String.Empty;
                string installCommand = String.Empty;
                string currentBranch = GetCurrentBranch(repository).Replace("\n", "");

                installCommand = @"fetch";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\Git\cmd\git.exe";
                startInfo.Arguments = installCommand;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + repository;

                process.StartInfo.RedirectStandardError = true;
                process.StartInfo = startInfo;
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);

                installCommand = @"merge " + fork + @"/" + mergee;
                startInfo.Arguments = installCommand;

                process.StartInfo = startInfo;
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string GetCurrentBranch(string repository)
        {
            try
            {
                //Checkout
                string output = String.Empty;
                string error = String.Empty;
                string installCommand = String.Empty;
                installCommand = @"rev-parse --abbrev-ref HEAD";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files\Git\cmd\git.exe";
                startInfo.Arguments = installCommand;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;
                startInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + repository;

                process.StartInfo.RedirectStandardError = true;
                process.StartInfo = startInfo;
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    output += reader.ReadToEnd();
                    error += process.StandardError.ReadToEnd();

                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + " " + output);
                    File.AppendAllText("output.txt", Environment.NewLine + DateTime.Now.ToString() + "Error: " + error);
                }

                process.WaitForExit();
                process.Close();

                //if (output != String.Empty) MessageBox.Show(output);
                if (error != String.Empty) MessageBox.Show(error);

                return output;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
