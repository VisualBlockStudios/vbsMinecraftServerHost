using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Security.Permissions;
using System.Security.Principal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBMSH
{
    public partial class serverScreen : Form
    {
        Process p = new Process();
        public string outputConsole;
        public serverScreen()
        {
            InitializeComponent();
            var p = new Process();

        }
        private void downloadLatestServer_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\Public\Documents\Visualblock\minecraft_server.jar"))
            {
                DialogResult dr = MessageBox.Show("Do you want to delete old server.jar?", "Are you Sure", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        System.IO.File.Delete(@"C:\Users\Public\Documents\Visualblock\minecraft_server.jar");
                    }
                    catch (System.IO.IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    try
                    {
                        WebClient minecraftserverDownloader = new WebClient();
                        WebClient minecraftserverDownloader1 = new WebClient();
                        minecraftserverDownloader.DownloadFile("https://s3.amazonaws.com/MinecraftDownload/launcher/minecraft_server.jar", @"C:\Users\Public\Documents\Visualblock\minecraft_server.jar");
                        minecraftserverDownloader1.DownloadFile("https://s3.amazonaws.com/MinecraftDownload/launcher/Minecraft_Server.exe", @"C:\Users\Public\Documents\Visualblock\minecraft_server.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\minecraft_server.jar"))
            {
                try
                {
                    WebClient minecraftserverDownloader = new WebClient();
                    WebClient minecraftserverDownloader1 = new WebClient();
                    minecraftserverDownloader.DownloadFile("https://s3.amazonaws.com/MinecraftDownload/launcher/minecraft_server.jar", @"C:\Users\Public\Documents\Visualblock\minecraft_server.jar");
                    minecraftserverDownloader1.DownloadFile("https://s3.amazonaws.com/MinecraftDownload/launcher/Minecraft_Server.exe", @"C:\Users\Public\Documents\Visualblock\minecraft_server.exe");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void setServerStatus(string isOnline)
        {
            if (isOnline == "true")
            {
                isServerOnline.Text = "Online";
                isServerOnline.BackColor = Color.Green;
                isServerOnlinebar.BackColor = Color.Green;
            }
            else if (isOnline == "false")
            {
                isServerOnline.Text = "Offline";
                isServerOnline.BackColor = Color.Red;
                isServerOnlinebar.BackColor = Color.Red;
            }
            else if (isOnline == "Error")
            {
                isServerOnline.Text = "Error";
                isServerOnline.BackColor = Color.Gray;
                isServerOnlinebar.BackColor = Color.Gray;
            }
            else
            {
                isServerOnline.Text = "Unknown";
                isServerOnline.BackColor = Color.Blue;
                isServerOnlinebar.BackColor = Color.Blue;
            }
        }
        void server_OutputDataReceived(object sendingProcess, DataReceivedEventArgs e)
        {
            outputConsole = e.Data;
        }
        void server_ErrorDataReceived(object sendingProcess, DataReceivedEventArgs e)
        {
            appConfig error = new appConfig();
            error.writeError(e.Data);
        }
        private void with512Mb_Click(object sender, EventArgs e)
        {
            p.StartInfo.FileName = @"java";
            p.StartInfo.Arguments = "-Xms512M " + "-Xmx512M " + "-jar " + "minecraft_server.jar " + "nogui";
                p.StartInfo.UseShellExecute = false;
                p.OutputDataReceived += new DataReceivedEventHandler(server_OutputDataReceived);
                p.ErrorDataReceived += new DataReceivedEventHandler(server_ErrorDataReceived);
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                p.PriorityClass = ProcessPriorityClass.High;
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                try
                {
                    int procId = p.Id;
                    processID.Text = "Process-ID: " + procId;
                    setServerStatus("true");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                    setServerStatus("Error");
                }
                catch (InvalidDataException ex)
                {
                    MessageBox.Show(ex.ToString());
                    setServerStatus("Error");
                }
                catch (InvalidProgramException ex)
                {
                    MessageBox.Show(ex.ToString());
                    setServerStatus("Error");
                }
                catch (SyntaxErrorException ex)
                {
                    MessageBox.Show(ex.ToString());
                    setServerStatus("Error");
                }
                //p.WaitForExit();
        }
        private void serverScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (p == null)

            p.Kill();
            p.CancelErrorRead();
            p.CancelOutputRead();
            setServerStatus("false");
        }
        private void stopServer_Click(object sender, EventArgs e)
        {
            if (p == null)
            p.Kill();
            p.CancelErrorRead();
            p.CancelOutputRead();
            processID.Text = "Process-ID:";
            setServerStatus("false");
        }
    }
}
