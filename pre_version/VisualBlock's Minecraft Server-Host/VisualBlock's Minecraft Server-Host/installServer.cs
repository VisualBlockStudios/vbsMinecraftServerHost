using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBMSH
{
    public partial class installServ : Form
    {
        appConfig appcon = new appConfig();
        public installServ()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            createServerCfg();
            appcon.installServcreated(false);
            appcon.writeExe();
            Application.Restart();
        }
        public void createServerCfg()
        {
            string dateDay = DateTime.Now.ToString("yyyyMMdd");
            string serverProperties;
            string CFGInfo = "#Minecraft server" + serverName.Text + " properties created with VBMSH.\n#" + dateDay + "\n#VisualBlock's Minecraft Server-Host Program";
            string GeneratorSettings = "generator-settings=";
            string AllowNether = "allow-nether=true";
            string LevelName = "level-name=world";
            string EnableQuery = "enable-query=false";
            string AllowFlight = "allow-flight=" + allowFlight.SelectedIndex.ToString();
            string defaultPort = "server-port=25565";
            string LevelType = "level-type=DEFAULT";
            string EnableRcon = "enable-rcon=false";
            string LevelSeed = "level-seed=VisualBlock Studios HOME";
            string defaultIP = "server-ip=";
            string MaxBuildHeight = "max-build-height=256";
            string SpawnNPCS = "spawn-npcs=true";
            string WhiteList = "white-list=" + whiteList.SelectedIndex.ToString();
            string SpawnAnimals = "spawn-animals=true";
            string SnooperEnabled = "snooper-enabled=true";
            string HardcoreMode = "hardcore=false";
            string TexturePack = "texture-pack=";
            string OnlineMode = "online-mode=" + onlineMode.SelectedIndex.ToString();
            string PVP = "pvp=" + pvp.SelectedIndex.ToString();
            string Difficulty = "difficulty=1";
            string EnabledCommandBlock = "enable-command-block=false";
            string Gamemode = "gamemode=0";
            string MaxPlayers = "max-players=" + maxPlayer.SelectedIndex.ToString();
            string SpawnMonsters = "spawn-monsters=true";
            string GenerateStructures = "generate-structures=true";
            string ViewDistance = "view-distance=" + viewDistance.SelectedIndex.ToString();
            string SpawnProtection = "spawn-protection=" + spawnProtection.SelectedIndex.ToString();
            string MOTD = "motd=" + serverMotd.Text;

            if (customIPenable.Checked)
            {
                defaultIP = "server-ip=" + customIP.Text;
            }
            if (customPortenable.Checked)
            {
                defaultPort = "server-port=" + customPort.Text;
            }
                serverProperties = CFGInfo + "\n" + GeneratorSettings + "\n" + AllowNether + "\n" + LevelName + "\n" +
                EnableQuery + "\n" + AllowFlight + "\n" + defaultPort + "\n" + LevelType + "\n" + EnableRcon + "\n" +
                LevelSeed + "\n" + MaxBuildHeight + "\n" + SpawnNPCS + "\n" + WhiteList + "\n" + SpawnAnimals + "\n" +
                SnooperEnabled + "\n" + HardcoreMode + "\n" + TexturePack + "\n" + OnlineMode + "\n" + PVP + "\n" +
                Difficulty + "\n" + EnabledCommandBlock + "\n" + Gamemode + "\n" + MaxPlayers + "\n" + SpawnMonsters + "\n" +
                GenerateStructures + "\n" + ViewDistance + "\n" + SpawnProtection + "\n" + MOTD;
            try
            {
                appcon.createpathcfg(serverProperties);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void customPortenable_CheckedChanged(object sender, EventArgs e)
        {
            if (customPortenable.Checked == true)
            {
                customPort.Enabled = true;
            }
            else
                customPort.Enabled = false;
        }

        private void customIPenable_CheckedChanged(object sender, EventArgs e)
        {
            if (customIPenable.Checked == true)
            {
                customIP.Enabled = true;
            }
            else
                customIP.Enabled = false;
        }
    }
}
