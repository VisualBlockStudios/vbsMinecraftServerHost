using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

/*
 * Core.cs for VisualBlock Studios Minecraft Server Host
 * Author: Leon K. ,
 * 
 * VisualBlock Studios
 * Licensed under GNU v.3
 */
public class Core
{
    [STAThread]
    public int latestBuildNum;
	public static Core()
	{
        try{
            Application.Run(/*new Application*/);
            if(!File.Exists(@"C:\Users\Public\Documents\VisualBlock\Error.txt")){
                File.Move(@"C:\Users\Public\Documents\VisualBlock\Error.txt", @"C:\Users\Public\Documents\VisualBlock\Error\Error.txt");
            }
        }
        catch (Exception ex){
            Error(ex, true);
        }
	}
    void Update()
    {
        //On program load look for newest Version
		//Update logic at Runtime
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
            errorInFile.Write(ErrorMessage, @"C:\Users\Public\Documents\VisualBlock\Error.txt");
            errorInFile.Close();
        }
        else{
            MessageBox.Show(ErrorMessage, "Error");
        }
    }
}
