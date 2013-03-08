using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

public class Core
{
    public int latestBuildNum;
	public static Core()
	{
        try{
            Application.Run(/*new Application*/);
        }
        catch (Exception ex){
            Error(ex, true);
        }
	}
    void Update()
    {
        //On program load look for newest Version
    }
    public void Updater(bool latestBuild, int customBuild = latestBuildNum)
    {
        if (latestBuild = true)
        {
            //download Latest build and restart
            Application.Restart();
        }
    }
    public void Error(String ErrorMessage, bool writeinFile)
    {
        if (writeinFile == true)/*Write in a file located at C:\Users\Public\Documents\VisualBlock*/{
            TextWriter errorInFile = new TextWriter();
            errorInFile.Write(ErrorMessage, @"C:\Users\Public\Documents\VisualBlock");
            errorInFile.Close();
        }
        else{
            MessageBox.Show(ErrorMessage, "Error");
        }
    }
}
