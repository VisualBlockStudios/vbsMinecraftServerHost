using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBMSH
{
    class appConfig
    {
        private void WriteConf(String configPath, String Configs)
        {
            TextWriter configWriter = new StreamWriter(configPath);
            configWriter.Write(Configs);
            configWriter.Close();
        }
        public void installServcreated(bool createNewFile)
        {
                string firstRun = @"C:\Users\Public\Documents\Visualblock";
                    if (!Directory.Exists(firstRun))
                    {
                        System.IO.Directory.CreateDirectory(firstRun);
                    }
                        if (createNewFile == true)
                        {
                            WriteConf(@"C:\Users\Public\Documents\Visualblock\vmsh.vbsd", "First_Run=0");
                        }
                            if (createNewFile == false)
                            {
                                WriteConf(@"C:\Users\Public\Documents\Visualblock\vmsh.vbsd", "First_Run=1");
                            }
        }
        public void writeError(string errors)
        {
            string errorsDic = @"C:\Users\Public\Documents\Visualblock\Error";
            if (!Directory.Exists(errorsDic))
            {
                System.IO.Directory.CreateDirectory(errorsDic);
            }
            string errorname = @"C:\Users\Public\Documents\Visualblock\Error\errors.txt";
            WriteConf(errorname, errors);
        }
        public void createpathcfg(String ServerProperties)
        {
            if (!Directory.Exists(@"C:\Users\Public\Documents\Visualblock"))
            {
                System.IO.Directory.CreateDirectory(@"C:\Users\Public\Documents\Visualblock");
            }
            if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\Server.properties"))
            {
                WriteConf(@"C:\Users\Public\Documents\Visualblock\Server.properties", ServerProperties);
            }
        }
        public void writeExe()
        {
            if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\512MB.bat"))
            {
            TextWriter tw1 = new StreamWriter(@"C:\Users\Public\Documents\Visualblock\512MB.bat");
            tw1.WriteLine("java -Xms512M -Xmx512M -jar minecraft_server.jar nogui");
            tw1.WriteLine("pause");
            tw1.Close();
            }
            if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\1GB.bat"))
            {
            TextWriter tw2 = new StreamWriter(@"C:\Users\Public\Documents\Visualblock\1GB.bat");
            tw2.WriteLine("java -Xms512M -Xmx1024M -jar minecraft_server.jar nogui");
            tw2.WriteLine("pause");
            tw2.Close();
            }
            if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\1.5GB.bat"))
            {
            TextWriter tw3 = new StreamWriter(@"C:\Users\Public\Documents\Visualblock\1.5GB.bat");
            tw3.WriteLine("java -Xms512M -Xmx1536M -jar minecraft_server.jar nogui\n pause");
            tw3.WriteLine("pause");
            tw3.Close();
            }
            if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\2GB.bat"))
            {
            TextWriter tw4 = new StreamWriter(@"C:\Users\Public\Documents\Visualblock\2GB.bat");
            tw4.WriteLine("java -Xms512M -Xmx2048M -jar minecraft_server.jar nogui\n pause");
            tw4.WriteLine("pause");
            tw4.Close();
            }
            if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\2.5GB.bat"))
            {
            TextWriter tw5 = new StreamWriter(@"C:\Users\Public\Documents\Visualblock\2.5GB.bat");
            tw5.WriteLine("java -Xms512M -Xmx2560M -jar minecraft_server.jar nogui\n pause");
            tw5.WriteLine("pause");
            tw5.Close();
            }
            if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\3GB.bat"))
            {
            TextWriter tw6 = new StreamWriter(@"C:\Users\Public\Documents\Visualblock\3GB.bat");
            tw6.WriteLine("java -Xms512M -Xmx3072M -jar minecraft_server.jar nogui\n pause");
            tw6.WriteLine("pause");
            tw6.Close();
            }
            if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\3.5GB.bat"))
            {
            TextWriter tw7 = new StreamWriter(@"C:\Users\Public\Documents\Visualblock\3.5GB.bat");
            tw7.WriteLine("java -Xms512M -Xmx3584M -jar minecraft_server.jar nogui\n pause");
            tw7.WriteLine("pause");
            tw7.Close();
            }
            if (!File.Exists(@"C:\Users\Public\Documents\Visualblock\4GB.bat"))
            {
            TextWriter tw8 = new StreamWriter(@"C:\Users\Public\Documents\Visualblock\4GB.bat");
            tw8.WriteLine("java -Xms512M -Xmx4096M -jar minecraft_server.jar nogui\n pause");
            tw8.WriteLine("pause");
            tw8.Close();
            }
        }

    }
}
