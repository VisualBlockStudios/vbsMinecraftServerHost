namespace VBMSH
{
    partial class serverScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverScreen));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.isServerOnline = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.isServerOnlinebar = new System.Windows.Forms.ToolStripStatusLabel();
            this.versionInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serverStartenstoppenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.with512Mb = new System.Windows.Forms.ToolStripMenuItem();
            this.with1GB = new System.Windows.Forms.ToolStripMenuItem();
            this.with15GB = new System.Windows.Forms.ToolStripMenuItem();
            this.with2GB = new System.Windows.Forms.ToolStripMenuItem();
            this.with25GB = new System.Windows.Forms.ToolStripMenuItem();
            this.with3GB = new System.Windows.Forms.ToolStripMenuItem();
            this.with35GB = new System.Windows.Forms.ToolStripMenuItem();
            this.with4GB = new System.Windows.Forms.ToolStripMenuItem();
            this.stopServer = new System.Windows.Forms.ToolStripMenuItem();
            this.worldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.autoBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.all10Minbackup = new System.Windows.Forms.ToolStripMenuItem();
            this.all20Minbackup = new System.Windows.Forms.ToolStripMenuItem();
            this.all30Minbackup = new System.Windows.Forms.ToolStripMenuItem();
            this.everyHourbackup = new System.Windows.Forms.ToolStripMenuItem();
            this.everySecondHourbackup = new System.Windows.Forms.ToolStripMenuItem();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banList = new System.Windows.Forms.ToolStripMenuItem();
            this.banIPList = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteList = new System.Windows.Forms.ToolStripMenuItem();
            this.opList = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadLatestServer = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleOutput = new System.Windows.Forms.RichTextBox();
            this.consoleInput = new System.Windows.Forms.TextBox();
            this.ramUsage = new System.Windows.Forms.Label();
            this.processID = new System.Windows.Forms.Label();
            this.onlinePlayer = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isServerOnline,
            this.toolStripStatusLabel1,
            this.isServerOnlinebar,
            this.versionInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // isServerOnline
            // 
            this.isServerOnline.BackColor = System.Drawing.Color.Red;
            this.isServerOnline.ForeColor = System.Drawing.Color.LawnGreen;
            this.isServerOnline.Name = "isServerOnline";
            this.isServerOnline.Size = new System.Drawing.Size(43, 17);
            this.isServerOnline.Text = "Offline";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // isServerOnlinebar
            // 
            this.isServerOnlinebar.BackColor = System.Drawing.Color.Red;
            this.isServerOnlinebar.Name = "isServerOnlinebar";
            this.isServerOnlinebar.Size = new System.Drawing.Size(781, 17);
            this.isServerOnlinebar.Text = resources.GetString("isServerOnlinebar.Text");
            // 
            // versionInfo
            // 
            this.versionInfo.IsLink = true;
            this.versionInfo.Name = "versionInfo";
            this.versionInfo.Size = new System.Drawing.Size(41, 17);
            this.versionInfo.Text = "V.1.0.0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverStartenstoppenToolStripMenuItem,
            this.worldToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.listsToolStripMenuItem,
            this.downloadLatestServer,
            this.cleanFolderToolStripMenuItem,
            this.showHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serverStartenstoppenToolStripMenuItem
            // 
            this.serverStartenstoppenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServerToolStripMenuItem,
            this.stopServer});
            this.serverStartenstoppenToolStripMenuItem.Name = "serverStartenstoppenToolStripMenuItem";
            this.serverStartenstoppenToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.serverStartenstoppenToolStripMenuItem.Text = "Start/Stop Server";
            // 
            // startServerToolStripMenuItem
            // 
            this.startServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.with512Mb,
            this.with1GB,
            this.with15GB,
            this.with2GB,
            this.with25GB,
            this.with3GB,
            this.with35GB,
            this.with4GB});
            this.startServerToolStripMenuItem.Name = "startServerToolStripMenuItem";
            this.startServerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.startServerToolStripMenuItem.Text = "Start Server";
            // 
            // with512Mb
            // 
            this.with512Mb.Name = "with512Mb";
            this.with512Mb.Size = new System.Drawing.Size(166, 22);
            this.with512Mb.Text = "with 512 MB Ram";
            this.with512Mb.Click += new System.EventHandler(this.with512Mb_Click);
            // 
            // with1GB
            // 
            this.with1GB.Name = "with1GB";
            this.with1GB.Size = new System.Drawing.Size(166, 22);
            this.with1GB.Text = "with 1 GB Ram";
            // 
            // with15GB
            // 
            this.with15GB.Name = "with15GB";
            this.with15GB.Size = new System.Drawing.Size(166, 22);
            this.with15GB.Text = "with 1.5 GB Ram";
            // 
            // with2GB
            // 
            this.with2GB.Name = "with2GB";
            this.with2GB.Size = new System.Drawing.Size(166, 22);
            this.with2GB.Text = "with 2 GB Ram";
            // 
            // with25GB
            // 
            this.with25GB.Name = "with25GB";
            this.with25GB.Size = new System.Drawing.Size(166, 22);
            this.with25GB.Text = "with 2.5 GB Ram";
            // 
            // with3GB
            // 
            this.with3GB.Name = "with3GB";
            this.with3GB.Size = new System.Drawing.Size(166, 22);
            this.with3GB.Text = "with 3 GB Ram";
            // 
            // with35GB
            // 
            this.with35GB.Name = "with35GB";
            this.with35GB.Size = new System.Drawing.Size(166, 22);
            this.with35GB.Text = "with 3.5 GB Ram";
            // 
            // with4GB
            // 
            this.with4GB.Name = "with4GB";
            this.with4GB.Size = new System.Drawing.Size(166, 22);
            this.with4GB.Text = "with 4 GB Ram";
            // 
            // stopServer
            // 
            this.stopServer.Name = "stopServer";
            this.stopServer.Size = new System.Drawing.Size(133, 22);
            this.stopServer.Text = "Stop Server";
            this.stopServer.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // worldToolStripMenuItem
            // 
            this.worldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveWorld,
            this.loadWorld});
            this.worldToolStripMenuItem.Name = "worldToolStripMenuItem";
            this.worldToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.worldToolStripMenuItem.Text = "World";
            // 
            // saveWorld
            // 
            this.saveWorld.Name = "saveWorld";
            this.saveWorld.Size = new System.Drawing.Size(135, 22);
            this.saveWorld.Text = "Save World";
            // 
            // loadWorld
            // 
            this.loadWorld.Name = "loadWorld";
            this.loadWorld.Size = new System.Drawing.Size(135, 22);
            this.loadWorld.Text = "Load World";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadBackup,
            this.autoBackupToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // loadBackup
            // 
            this.loadBackup.Name = "loadBackup";
            this.loadBackup.Size = new System.Drawing.Size(142, 22);
            this.loadBackup.Text = "Load Backup";
            // 
            // autoBackupToolStripMenuItem
            // 
            this.autoBackupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.all10Minbackup,
            this.all20Minbackup,
            this.all30Minbackup,
            this.everyHourbackup,
            this.everySecondHourbackup});
            this.autoBackupToolStripMenuItem.Name = "autoBackupToolStripMenuItem";
            this.autoBackupToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.autoBackupToolStripMenuItem.Text = "Auto Backup";
            // 
            // all10Minbackup
            // 
            this.all10Minbackup.Name = "all10Minbackup";
            this.all10Minbackup.Size = new System.Drawing.Size(171, 22);
            this.all10Minbackup.Text = "All 10 min";
            // 
            // all20Minbackup
            // 
            this.all20Minbackup.Name = "all20Minbackup";
            this.all20Minbackup.Size = new System.Drawing.Size(171, 22);
            this.all20Minbackup.Text = "All 20 min";
            // 
            // all30Minbackup
            // 
            this.all30Minbackup.Name = "all30Minbackup";
            this.all30Minbackup.Size = new System.Drawing.Size(171, 22);
            this.all30Minbackup.Text = "All 30 min";
            // 
            // everyHourbackup
            // 
            this.everyHourbackup.Name = "everyHourbackup";
            this.everyHourbackup.Size = new System.Drawing.Size(171, 22);
            this.everyHourbackup.Text = "Every hour";
            // 
            // everySecondHourbackup
            // 
            this.everySecondHourbackup.Name = "everySecondHourbackup";
            this.everySecondHourbackup.Size = new System.Drawing.Size(171, 22);
            this.everySecondHourbackup.Text = "Every second hour";
            // 
            // listsToolStripMenuItem
            // 
            this.listsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banList,
            this.banIPList,
            this.whiteList,
            this.opList});
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.listsToolStripMenuItem.Text = "List\'s";
            // 
            // banList
            // 
            this.banList.Name = "banList";
            this.banList.Size = new System.Drawing.Size(132, 22);
            this.banList.Text = "Ban-List";
            // 
            // banIPList
            // 
            this.banIPList.Name = "banIPList";
            this.banIPList.Size = new System.Drawing.Size(132, 22);
            this.banIPList.Text = "Ban-IP-List";
            // 
            // whiteList
            // 
            this.whiteList.Name = "whiteList";
            this.whiteList.Size = new System.Drawing.Size(132, 22);
            this.whiteList.Text = "White-List";
            // 
            // opList
            // 
            this.opList.Name = "opList";
            this.opList.Size = new System.Drawing.Size(132, 22);
            this.opList.Text = "OP-List";
            // 
            // downloadLatestServer
            // 
            this.downloadLatestServer.Name = "downloadLatestServer";
            this.downloadLatestServer.Size = new System.Drawing.Size(142, 20);
            this.downloadLatestServer.Text = "Download Latest Server";
            this.downloadLatestServer.Click += new System.EventHandler(this.downloadLatestServer_Click);
            // 
            // cleanFolderToolStripMenuItem
            // 
            this.cleanFolderToolStripMenuItem.Name = "cleanFolderToolStripMenuItem";
            this.cleanFolderToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cleanFolderToolStripMenuItem.Text = "Clean Folder";
            // 
            // showHelp
            // 
            this.showHelp.Name = "showHelp";
            this.showHelp.Size = new System.Drawing.Size(44, 20);
            this.showHelp.Text = "Help";
            // 
            // consoleOutput
            // 
            this.consoleOutput.Location = new System.Drawing.Point(12, 386);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.Size = new System.Drawing.Size(860, 222);
            this.consoleOutput.TabIndex = 2;
            this.consoleOutput.Text = "";
            // 
            // consoleInput
            // 
            this.consoleInput.Location = new System.Drawing.Point(12, 616);
            this.consoleInput.Name = "consoleInput";
            this.consoleInput.Size = new System.Drawing.Size(860, 20);
            this.consoleInput.TabIndex = 3;
            // 
            // ramUsage
            // 
            this.ramUsage.AutoSize = true;
            this.ramUsage.Location = new System.Drawing.Point(13, 367);
            this.ramUsage.Name = "ramUsage";
            this.ramUsage.Size = new System.Drawing.Size(69, 13);
            this.ramUsage.TabIndex = 4;
            this.ramUsage.Text = "Ram-Usage: ";
            // 
            // processID
            // 
            this.processID.AutoSize = true;
            this.processID.Location = new System.Drawing.Point(743, 367);
            this.processID.Name = "processID";
            this.processID.Size = new System.Drawing.Size(65, 13);
            this.processID.TabIndex = 5;
            this.processID.Text = "Process-ID: ";
            // 
            // onlinePlayer
            // 
            this.onlinePlayer.FormattingEnabled = true;
            this.onlinePlayer.Location = new System.Drawing.Point(642, 28);
            this.onlinePlayer.Name = "onlinePlayer";
            this.onlinePlayer.Size = new System.Drawing.Size(230, 329);
            this.onlinePlayer.TabIndex = 6;
            // 
            // serverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.onlinePlayer);
            this.Controls.Add(this.processID);
            this.Controls.Add(this.ramUsage);
            this.Controls.Add(this.consoleInput);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "serverScreen";
            this.Text = "Server-Side Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.serverScreen_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel isServerOnline;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel isServerOnlinebar;
        private System.Windows.Forms.ToolStripStatusLabel versionInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serverStartenstoppenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorld;
        private System.Windows.Forms.ToolStripMenuItem loadWorld;
        private System.Windows.Forms.RichTextBox consoleOutput;
        private System.Windows.Forms.TextBox consoleInput;
        private System.Windows.Forms.Label ramUsage;
        private System.Windows.Forms.Label processID;
        private System.Windows.Forms.ToolStripMenuItem startServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem with512Mb;
        private System.Windows.Forms.ToolStripMenuItem with1GB;
        private System.Windows.Forms.ToolStripMenuItem with15GB;
        private System.Windows.Forms.ToolStripMenuItem with2GB;
        private System.Windows.Forms.ToolStripMenuItem with25GB;
        private System.Windows.Forms.ToolStripMenuItem with3GB;
        private System.Windows.Forms.ToolStripMenuItem with35GB;
        private System.Windows.Forms.ToolStripMenuItem with4GB;
        private System.Windows.Forms.ToolStripMenuItem stopServer;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBackup;
        private System.Windows.Forms.ToolStripMenuItem autoBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem all10Minbackup;
        private System.Windows.Forms.ToolStripMenuItem all20Minbackup;
        private System.Windows.Forms.ToolStripMenuItem all30Minbackup;
        private System.Windows.Forms.ToolStripMenuItem everyHourbackup;
        private System.Windows.Forms.ToolStripMenuItem everySecondHourbackup;
        private System.Windows.Forms.ToolStripMenuItem listsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banList;
        private System.Windows.Forms.ToolStripMenuItem banIPList;
        private System.Windows.Forms.ToolStripMenuItem whiteList;
        private System.Windows.Forms.ToolStripMenuItem opList;
        private System.Windows.Forms.ToolStripMenuItem showHelp;
        private System.Windows.Forms.ToolStripMenuItem downloadLatestServer;
        private System.Windows.Forms.ListBox onlinePlayer;
        private System.Windows.Forms.ToolStripMenuItem cleanFolderToolStripMenuItem;

    }
}