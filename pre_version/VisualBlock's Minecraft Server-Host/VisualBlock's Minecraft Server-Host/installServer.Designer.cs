namespace VBMSH
{
    partial class installServ
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(installServ));
            this.createServercfg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customIPenable = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.serverMotd = new System.Windows.Forms.TextBox();
            this.customPortenable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.onlineMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.whiteList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.viewDistance = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.spawnProtection = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.allowFlight = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pvp = new System.Windows.Forms.ComboBox();
            this.maxPlayer = new System.Windows.Forms.ComboBox();
            this.rconEnabled = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createServercfg
            // 
            this.createServercfg.BackColor = System.Drawing.SystemColors.Control;
            this.createServercfg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createServercfg.Location = new System.Drawing.Point(12, 376);
            this.createServercfg.Name = "createServercfg";
            this.createServercfg.Size = new System.Drawing.Size(585, 23);
            this.createServercfg.TabIndex = 15;
            this.createServercfg.Text = "Create";
            this.createServercfg.UseVisualStyleBackColor = false;
            this.createServercfg.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server-Name";
            // 
            // serverName
            // 
            this.serverName.BackColor = System.Drawing.SystemColors.Window;
            this.serverName.Location = new System.Drawing.Point(12, 31);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(276, 20);
            this.serverName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rcon Enabled";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // customPort
            // 
            this.customPort.Enabled = false;
            this.customPort.Location = new System.Drawing.Point(12, 148);
            this.customPort.MaxLength = 5;
            this.customPort.Name = "customPort";
            this.customPort.Size = new System.Drawing.Size(276, 20);
            this.customPort.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Custom IP";
            // 
            // customIP
            // 
            this.customIP.Enabled = false;
            this.customIP.Location = new System.Drawing.Point(12, 208);
            this.customIP.Name = "customIP";
            this.customIP.Size = new System.Drawing.Size(276, 20);
            this.customIP.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LawnGreen;
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Max Players";
            // 
            // customIPenable
            // 
            this.customIPenable.AutoSize = true;
            this.customIPenable.BackColor = System.Drawing.Color.Transparent;
            this.customIPenable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customIPenable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customIPenable.ForeColor = System.Drawing.Color.LawnGreen;
            this.customIPenable.Location = new System.Drawing.Point(103, 184);
            this.customIPenable.Name = "customIPenable";
            this.customIPenable.Size = new System.Drawing.Size(185, 23);
            this.customIPenable.TabIndex = 14;
            this.customIPenable.Text = "Check for Custom IP";
            this.customIPenable.UseVisualStyleBackColor = false;
            this.customIPenable.CheckedChanged += new System.EventHandler(this.customIPenable_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LawnGreen;
            this.label6.Location = new System.Drawing.Point(12, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Motd";
            // 
            // serverMotd
            // 
            this.serverMotd.Location = new System.Drawing.Point(12, 328);
            this.serverMotd.Name = "serverMotd";
            this.serverMotd.Size = new System.Drawing.Size(276, 20);
            this.serverMotd.TabIndex = 6;
            // 
            // customPortenable
            // 
            this.customPortenable.AutoSize = true;
            this.customPortenable.BackColor = System.Drawing.Color.Transparent;
            this.customPortenable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customPortenable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customPortenable.ForeColor = System.Drawing.Color.LawnGreen;
            this.customPortenable.Location = new System.Drawing.Point(86, 125);
            this.customPortenable.Name = "customPortenable";
            this.customPortenable.Size = new System.Drawing.Size(202, 23);
            this.customPortenable.TabIndex = 13;
            this.customPortenable.Text = "Check for Custom Port";
            this.customPortenable.UseVisualStyleBackColor = false;
            this.customPortenable.CheckedChanged += new System.EventHandler(this.customPortenable_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LawnGreen;
            this.label7.Location = new System.Drawing.Point(492, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Online-Mode";
            // 
            // onlineMode
            // 
            this.onlineMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.onlineMode.FormattingEnabled = true;
            this.onlineMode.Items.AddRange(new object[] {
            "True",
            "False"});
            this.onlineMode.Location = new System.Drawing.Point(321, 30);
            this.onlineMode.Name = "onlineMode";
            this.onlineMode.Size = new System.Drawing.Size(276, 21);
            this.onlineMode.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LawnGreen;
            this.label8.Location = new System.Drawing.Point(512, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "White-List";
            // 
            // whiteList
            // 
            this.whiteList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whiteList.FormattingEnabled = true;
            this.whiteList.Items.AddRange(new object[] {
            "True",
            "False"});
            this.whiteList.Location = new System.Drawing.Point(321, 90);
            this.whiteList.Name = "whiteList";
            this.whiteList.Size = new System.Drawing.Size(276, 21);
            this.whiteList.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LawnGreen;
            this.label9.Location = new System.Drawing.Point(479, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "View-Distance";
            // 
            // viewDistance
            // 
            this.viewDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewDistance.FormattingEnabled = true;
            this.viewDistance.Items.AddRange(new object[] {
            "3",
            "4",
            "5 (Low)",
            "6",
            "7",
            "8",
            "9",
            "10 (Normal)",
            "11",
            "12",
            "13",
            "14",
            "15 (Highest)"});
            this.viewDistance.Location = new System.Drawing.Point(321, 148);
            this.viewDistance.Name = "viewDistance";
            this.viewDistance.Size = new System.Drawing.Size(276, 21);
            this.viewDistance.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LawnGreen;
            this.label10.Location = new System.Drawing.Point(451, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Spawn-Protection";
            // 
            // spawnProtection
            // 
            this.spawnProtection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spawnProtection.FormattingEnabled = true;
            this.spawnProtection.Items.AddRange(new object[] {
            "0 (Disabled)",
            "2",
            "4",
            "8",
            "12",
            "16",
            "20",
            "24",
            "28",
            "32",
            "40",
            "48",
            "56",
            "64",
            "128",
            "256"});
            this.spawnProtection.Location = new System.Drawing.Point(321, 208);
            this.spawnProtection.Name = "spawnProtection";
            this.spawnProtection.Size = new System.Drawing.Size(276, 21);
            this.spawnProtection.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LawnGreen;
            this.label11.Location = new System.Drawing.Point(499, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Allow Flight";
            // 
            // allowFlight
            // 
            this.allowFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allowFlight.FormattingEnabled = true;
            this.allowFlight.Items.AddRange(new object[] {
            "True",
            "False"});
            this.allowFlight.Location = new System.Drawing.Point(321, 270);
            this.allowFlight.Name = "allowFlight";
            this.allowFlight.Size = new System.Drawing.Size(276, 21);
            this.allowFlight.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LawnGreen;
            this.label12.Location = new System.Drawing.Point(555, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "PVP";
            // 
            // pvp
            // 
            this.pvp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pvp.FormattingEnabled = true;
            this.pvp.Items.AddRange(new object[] {
            "True",
            "False"});
            this.pvp.Location = new System.Drawing.Point(321, 328);
            this.pvp.Name = "pvp";
            this.pvp.Size = new System.Drawing.Size(275, 21);
            this.pvp.TabIndex = 12;
            // 
            // maxPlayer
            // 
            this.maxPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxPlayer.FormattingEnabled = true;
            this.maxPlayer.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "20",
            "24",
            "30",
            "38",
            "42",
            "56",
            "64",
            "72",
            "80",
            "94",
            "100"});
            this.maxPlayer.Location = new System.Drawing.Point(12, 270);
            this.maxPlayer.Name = "maxPlayer";
            this.maxPlayer.Size = new System.Drawing.Size(276, 21);
            this.maxPlayer.TabIndex = 5;
            // 
            // rconEnabled
            // 
            this.rconEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rconEnabled.FormattingEnabled = true;
            this.rconEnabled.Items.AddRange(new object[] {
            "True",
            "False"});
            this.rconEnabled.Location = new System.Drawing.Point(12, 90);
            this.rconEnabled.Name = "rconEnabled";
            this.rconEnabled.Size = new System.Drawing.Size(276, 21);
            this.rconEnabled.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LawnGreen;
            this.label13.Location = new System.Drawing.Point(12, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(218, 19);
            this.label13.TabIndex = 30;
            this.label13.Text = "Be sure to filled all options!!";
            // 
            // installServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 411);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rconEnabled);
            this.Controls.Add(this.maxPlayer);
            this.Controls.Add(this.pvp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.allowFlight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.spawnProtection);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.viewDistance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.whiteList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.onlineMode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customPortenable);
            this.Controls.Add(this.serverMotd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customIPenable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createServercfg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "installServ";
            this.Text = "VisualBlock\'s Minecraft Server-Host Installation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createServercfg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox customIPenable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serverMotd;
        private System.Windows.Forms.CheckBox customPortenable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox onlineMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox whiteList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox viewDistance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox spawnProtection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox allowFlight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox pvp;
        private System.Windows.Forms.ComboBox maxPlayer;
        private System.Windows.Forms.ComboBox rconEnabled;
        private System.Windows.Forms.Label label13;
    }
}

