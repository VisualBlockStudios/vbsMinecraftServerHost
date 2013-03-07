using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VisualBlock_Studios_WPF_Overlay
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// This Code is proper of VisualBlock Studios
    /// and Licensed under GNU General Public License (GPLv3)
    /// </summary>
    public partial class MainWindow : Window
    {
        Process server = new Process();
        ProcessStartInfo serverExe = new ProcessStartInfo();
        WebClient downloader = new WebClient();
        int process_Id;
        bool started;
        public MainWindow()
        {
            InitializeComponent();
            if (!Directory.Exists(@"C:\Users\Public\Documents\VisualBlock"))
            {
                Directory.CreateDirectory(@"C:\Users\Public\Documents\VisualBlock");
            }
            if (!File.Exists(@"C:\Users\Public\Documents\VisualBlock\Minecraft_Server.exe"))
            {
                downloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloader_DownloadProgressChanged);
                downloader.DownloadFileAsync(new Uri("https://s3.amazonaws.com/MinecraftDownload/launcher/Minecraft_Server.exe"), @"C:\Users\Public\Documents\VisualBlock\Minecraft_Server.exe");
                downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(downloader_DownloadFileCompleted);
                status_Label.Content = "Initialising";
                for (int i = 0; i < 4; i++)
                {
                    status_Label.Content += ".";
                }
            }
            else {start_Server.IsEnabled = true;}
            serverExe.FileName = @"C:\Users\Public\Documents\VisualBlock\Minecraft_Server.exe";
            serverExe.RedirectStandardError = true;
            serverExe.RedirectStandardInput = true;
            serverExe.RedirectStandardOutput = true;
            serverExe.UseShellExecute = false;
            serverExe.CreateNoWindow = true;
            serverExe.Verb = "nogui";
            serverExe.StandardOutputEncoding = System.Text.UTF8Encoding.Default;
            serverExe.StandardErrorEncoding = System.Text.UTF8Encoding.Default;
            server.OutputDataReceived += server_OutputDataReceived;
            server.ErrorDataReceived += server_ErrorDataReceived;
        }
        void server_OutputDataReceived(Object sender, DataReceivedEventArgs e)
        {
            //Output zur Konsole Übergeben
        }
        void server_ErrorDataReceived(Object sender, DataReceivedEventArgs e)
        {
            string ex = e.ToString();
            MessageBox.Show(ex);
        }
        private void MouseDown1(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        private void downloader_DownloadProgressChanged(Object sender, DownloadProgressChangedEventArgs e)
        {
            progress_Bar.Value = e.ProgressPercentage;
            status_Label.Content = "Downloading";
        }
        private void downloader_DownloadFileCompleted(Object sender, AsyncCompletedEventArgs e)
        {
            progress_Bar.Value = 0;
            status_Label.Content = "Download Finished! You are now able to start the Server";
            start_Server.IsEnabled = true;
        }
        private void start_Server_Click(object sender, RoutedEventArgs e)
        {
            if (started == false)
            {
                //Server start
                status_Label.Content = "Start Server";
                server.StartInfo = serverExe;
                started = server.Start();
                try
                {
                    process_Id = server.Id;
                    started = true;
                    server.BeginErrorReadLine();
                    server.BeginOutputReadLine();
                    process_Id_Label.Content = "Process-ID : " + process_Id;
                    status_Label.Content = "Server is Running";
                    status_Label.Foreground = Brushes.Green;
                    start_Server.Content = "Stop Server";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    status_Label.Content = "Server stopped caused by an Error";
                    status_Label.Foreground = Brushes.Gray;
                    server.CancelErrorRead();
                    server.CancelOutputRead();
                }
            }
            else
            {
                //Sets the start Server Button to a stop Server Button
                server.CancelErrorRead();
                server.CancelOutputRead();
                server.Kill();
                started = false;
                status_Label.Content = "Stop Server";
                status_Label.Foreground = Brushes.Red;
                process_Id_Label.Content = "Process-ID : ";
            }
        }

        private void server_closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if Window get closed
            if (started == true)
            {
                server.CancelErrorRead();
                server.CancelOutputRead();
                server.Kill();
                process_Id_Label.Content = "Process-ID : ";
                status_Label.Content = "Shutdown";
                status_Label.Foreground = Brushes.Red;
            }
        }
        private void exit_Button_Click(object sender, RoutedEventArgs e)
        {
            if (started == true)
            {
                server.CancelErrorRead();
                server.CancelOutputRead();
                server.Kill();
                process_Id_Label.Content = "Process-ID : ";
                status_Label.Content = "Shutdown";
                status_Label.Foreground = Brushes.Red;
            }
            this.Close();
        }
        private void server_Input_Console_GotFokus(object sender, KeyboardFocusChangedEventArgs e)
        {
            server_Input_Console.Text = "";
        }
        private void server_Input_Console_LostFokus(object sender, KeyboardFocusChangedEventArgs e)
        {
            server_Input_Console.Text = "/say Hello";
        }
        private void server_Input_Console_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Enter))
            {
                server_Grid1.Focus();
            }
        }
        private void minimize_Button_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
