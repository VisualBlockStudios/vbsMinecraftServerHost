using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace VBMSH
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\vmsh.vbsd"))
            {
                appConfig appcon = new appConfig();
                appcon.installServcreated(true);
            }
            TextReader tr = new StreamReader(@"C:\Users\Public\Documents\Visualblock\vmsh.vbsd");
            string outputtr = tr.ReadToEnd();
            tr.Close();
            //!File.Exists(@"C:\Users\Public\Documents\Visualblock\vmsh.vbsd")
            if (outputtr == "First_Run=0" || !File.Exists(@"C:\Users\Public\Documents\Visualblock\vmsh.vbsd"))
            {
                Application.Run(new installServ());
            }
            else if (outputtr == "First_Run=1" && File.Exists(@"C:\Users\Public\Documents\Visualblock\vmsh.vbsd"))
            {
                Application.Run(new serverScreen());
            }
            else if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\vmsh.vbsd"))
            {
                MessageBox.Show("Run the Program as Admin if it won't work!");
            }
            else
            {
                File.Delete(@"C:\Users\Public\Documents\Visualblock\vmsh.vbsd");
                Application.Restart();
            }
        }
    }
}
