namespace ApkInfoViewer {
    partial class MainForm {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.apkListBoxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.apkListBoxMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.apkListBoxMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apkListBoxMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClearData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.apkListBoxMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.apkListBoxMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceListBoxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deviceListBoxMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deviceListBoxMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesItemPlatformKey = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.groupBoxDevice = new System.Windows.Forms.GroupBox();
            this.textBoxAdbShell = new System.Windows.Forms.TextBox();
            this.buttonRefreshDevice = new System.Windows.Forms.Button();
            this.groupBoxAPK = new System.Windows.Forms.GroupBox();
            this.textBoxPlatformKey = new System.Windows.Forms.TextBox();
            this.buttonSignSystem = new System.Windows.Forms.Button();
            this.comboBoxSignSystem = new System.Windows.Forms.ComboBox();
            this.textBoxPackageFilte = new System.Windows.Forms.TextBox();
            this.buttonPackageFilte = new System.Windows.Forms.Button();
            this.textBoxSendText = new System.Windows.Forms.TextBox();
            this.buttonSendText = new System.Windows.Forms.Button();
            this.apkListBoxMenu.SuspendLayout();
            this.deviceListBoxMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBoxDevice.SuspendLayout();
            this.groupBoxAPK.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBox2.Location = new System.Drawing.Point(12, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(619, 23);
            this.textBox2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Consolas", 10F);
            this.button2.Location = new System.Drawing.Point(637, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBox3.Location = new System.Drawing.Point(108, 441);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(430, 23);
            this.textBox3.TabIndex = 5;
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBox4.Location = new System.Drawing.Point(108, 470);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(430, 23);
            this.textBox4.TabIndex = 6;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBox5.Location = new System.Drawing.Point(108, 499);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(430, 23);
            this.textBox5.TabIndex = 7;
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F);
            this.label1.Location = new System.Drawing.Point(6, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "PackageName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F);
            this.label2.Location = new System.Drawing.Point(6, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "VersionCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F);
            this.label3.Location = new System.Drawing.Point(6, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "VersionName";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(532, 319);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Consolas", 10F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(5, 22);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(150, 319);
            this.listBox2.TabIndex = 13;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 698);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(710, 18);
            this.progressBar1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F);
            this.label4.Location = new System.Drawing.Point(6, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Activity";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBox1.Location = new System.Drawing.Point(108, 528);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(430, 23);
            this.textBox1.TabIndex = 17;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // apkListBoxMenu
            // 
            this.apkListBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apkListBoxMenuItem3,
            this.apkListBoxMenuItem1,
            this.apkListBoxMenuItem2,
            this.menuItemClearData,
            this.toolStripSeparator1,
            this.apkListBoxMenuItem5,
            this.toolStripSeparator2,
            this.apkListBoxMenuItem4});
            this.apkListBoxMenu.Name = "apkListBoxMenu";
            this.apkListBoxMenu.ShowImageMargin = false;
            this.apkListBoxMenu.Size = new System.Drawing.Size(122, 148);
            this.apkListBoxMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.apkListBoxMenu_ItemClicked);
            // 
            // apkListBoxMenuItem3
            // 
            this.apkListBoxMenuItem3.Name = "apkListBoxMenuItem3";
            this.apkListBoxMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.apkListBoxMenuItem3.Text = "Start APP";
            // 
            // apkListBoxMenuItem1
            // 
            this.apkListBoxMenuItem1.Name = "apkListBoxMenuItem1";
            this.apkListBoxMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.apkListBoxMenuItem1.Text = "Install APK";
            // 
            // apkListBoxMenuItem2
            // 
            this.apkListBoxMenuItem2.Name = "apkListBoxMenuItem2";
            this.apkListBoxMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.apkListBoxMenuItem2.Text = "Uinstall APK";
            // 
            // menuItemClearData
            // 
            this.menuItemClearData.Name = "menuItemClearData";
            this.menuItemClearData.Size = new System.Drawing.Size(121, 22);
            this.menuItemClearData.Text = "Clear Data";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // apkListBoxMenuItem5
            // 
            this.apkListBoxMenuItem5.Name = "apkListBoxMenuItem5";
            this.apkListBoxMenuItem5.Size = new System.Drawing.Size(121, 22);
            this.apkListBoxMenuItem5.Text = "Rename";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
            // 
            // apkListBoxMenuItem4
            // 
            this.apkListBoxMenuItem4.Name = "apkListBoxMenuItem4";
            this.apkListBoxMenuItem4.Size = new System.Drawing.Size(121, 22);
            this.apkListBoxMenuItem4.Text = "Refresh APKs";
            // 
            // deviceListBoxMenu
            // 
            this.deviceListBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceListBoxMenuItem2,
            this.toolStripSeparator3,
            this.deviceListBoxMenuItem1});
            this.deviceListBoxMenu.Name = "deviceListBoxMenu";
            this.deviceListBoxMenu.ShowImageMargin = false;
            this.deviceListBoxMenu.Size = new System.Drawing.Size(138, 54);
            this.deviceListBoxMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.deviceListBoxMenu_ItemClicked);
            // 
            // deviceListBoxMenuItem2
            // 
            this.deviceListBoxMenuItem2.Name = "deviceListBoxMenuItem2";
            this.deviceListBoxMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.deviceListBoxMenuItem2.Text = "Reboot";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(134, 6);
            // 
            // deviceListBoxMenuItem1
            // 
            this.deviceListBoxMenuItem1.Name = "deviceListBoxMenuItem1";
            this.deviceListBoxMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.deviceListBoxMenuItem1.Text = "Refresh Devices";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPreferences});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(734, 24);
            this.menuStrip.TabIndex = 18;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // itemPreferences
            // 
            this.itemPreferences.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesItemTool,
            this.preferencesItemPlatformKey});
            this.itemPreferences.Name = "itemPreferences";
            this.itemPreferences.Size = new System.Drawing.Size(84, 20);
            this.itemPreferences.Text = "Preferences";
            // 
            // preferencesItemTool
            // 
            this.preferencesItemTool.Name = "preferencesItemTool";
            this.preferencesItemTool.Size = new System.Drawing.Size(142, 22);
            this.preferencesItemTool.Text = "Tools";
            this.preferencesItemTool.Click += new System.EventHandler(this.preferencesItemTool_Click);
            // 
            // preferencesItemPlatformKey
            // 
            this.preferencesItemPlatformKey.Name = "preferencesItemPlatformKey";
            this.preferencesItemPlatformKey.Size = new System.Drawing.Size(142, 22);
            this.preferencesItemPlatformKey.Text = "PlatformKey";
            this.preferencesItemPlatformKey.Click += new System.EventHandler(this.preferencesItemPlatformKey_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 739);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(734, 22);
            this.statusStrip.TabIndex = 19;
            this.statusStrip.Text = "statusStrip1";
            // 
            // groupBoxDevice
            // 
            this.groupBoxDevice.Controls.Add(this.textBoxAdbShell);
            this.groupBoxDevice.Controls.Add(this.buttonRefreshDevice);
            this.groupBoxDevice.Controls.Add(this.listBox2);
            this.groupBoxDevice.Font = new System.Drawing.Font("Consolas", 10F);
            this.groupBoxDevice.Location = new System.Drawing.Point(12, 60);
            this.groupBoxDevice.Name = "groupBoxDevice";
            this.groupBoxDevice.Size = new System.Drawing.Size(160, 600);
            this.groupBoxDevice.TabIndex = 20;
            this.groupBoxDevice.TabStop = false;
            this.groupBoxDevice.Text = "Device List";
            this.groupBoxDevice.Enter += new System.EventHandler(this.groupBoxDevice_Enter);
            // 
            // textBoxAdbShell
            // 
            this.textBoxAdbShell.Location = new System.Drawing.Point(6, 379);
            this.textBoxAdbShell.Name = "textBoxAdbShell";
            this.textBoxAdbShell.ReadOnly = true;
            this.textBoxAdbShell.Size = new System.Drawing.Size(148, 23);
            this.textBoxAdbShell.TabIndex = 15;
            this.textBoxAdbShell.Click += new System.EventHandler(this.textBoxAdbShell_Click);
            this.textBoxAdbShell.TextChanged += new System.EventHandler(this.textBoxAdbShell_TextChanged);
            // 
            // buttonRefreshDevice
            // 
            this.buttonRefreshDevice.AutoSize = true;
            this.buttonRefreshDevice.Location = new System.Drawing.Point(6, 346);
            this.buttonRefreshDevice.Name = "buttonRefreshDevice";
            this.buttonRefreshDevice.Size = new System.Drawing.Size(148, 27);
            this.buttonRefreshDevice.TabIndex = 14;
            this.buttonRefreshDevice.Text = "Refresh";
            this.buttonRefreshDevice.UseVisualStyleBackColor = true;
            this.buttonRefreshDevice.Click += new System.EventHandler(this.buttonRefreshDevice_Click);
            // 
            // groupBoxAPK
            // 
            this.groupBoxAPK.Controls.Add(this.textBoxPlatformKey);
            this.groupBoxAPK.Controls.Add(this.buttonSignSystem);
            this.groupBoxAPK.Controls.Add(this.comboBoxSignSystem);
            this.groupBoxAPK.Controls.Add(this.textBoxPackageFilte);
            this.groupBoxAPK.Controls.Add(this.buttonPackageFilte);
            this.groupBoxAPK.Controls.Add(this.listBox1);
            this.groupBoxAPK.Controls.Add(this.label1);
            this.groupBoxAPK.Controls.Add(this.label2);
            this.groupBoxAPK.Controls.Add(this.label3);
            this.groupBoxAPK.Controls.Add(this.label4);
            this.groupBoxAPK.Controls.Add(this.textBox3);
            this.groupBoxAPK.Controls.Add(this.textBox1);
            this.groupBoxAPK.Controls.Add(this.textBox4);
            this.groupBoxAPK.Controls.Add(this.textBox5);
            this.groupBoxAPK.Font = new System.Drawing.Font("Consolas", 10F);
            this.groupBoxAPK.Location = new System.Drawing.Point(178, 60);
            this.groupBoxAPK.Name = "groupBoxAPK";
            this.groupBoxAPK.Size = new System.Drawing.Size(544, 600);
            this.groupBoxAPK.TabIndex = 21;
            this.groupBoxAPK.TabStop = false;
            this.groupBoxAPK.Text = "APK List";
            // 
            // textBoxPlatformKey
            // 
            this.textBoxPlatformKey.Location = new System.Drawing.Point(6, 412);
            this.textBoxPlatformKey.Name = "textBoxPlatformKey";
            this.textBoxPlatformKey.ReadOnly = true;
            this.textBoxPlatformKey.Size = new System.Drawing.Size(532, 23);
            this.textBoxPlatformKey.TabIndex = 22;
            this.textBoxPlatformKey.Click += new System.EventHandler(this.textBoxPlatformKey_Click);
            this.textBoxPlatformKey.TextChanged += new System.EventHandler(this.textBoxPlatformKey_TextChanged);
            // 
            // buttonSignSystem
            // 
            this.buttonSignSystem.AutoSize = true;
            this.buttonSignSystem.Location = new System.Drawing.Point(463, 380);
            this.buttonSignSystem.Name = "buttonSignSystem";
            this.buttonSignSystem.Size = new System.Drawing.Size(75, 27);
            this.buttonSignSystem.TabIndex = 21;
            this.buttonSignSystem.Text = "System";
            this.buttonSignSystem.UseVisualStyleBackColor = true;
            this.buttonSignSystem.Click += new System.EventHandler(this.buttonSignSystem_Click);
            // 
            // comboBoxSignSystem
            // 
            this.comboBoxSignSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSignSystem.FormattingEnabled = true;
            this.comboBoxSignSystem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxSignSystem.Location = new System.Drawing.Point(6, 383);
            this.comboBoxSignSystem.Name = "comboBoxSignSystem";
            this.comboBoxSignSystem.Size = new System.Drawing.Size(447, 23);
            this.comboBoxSignSystem.TabIndex = 20;
            this.comboBoxSignSystem.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignSystem_SelectedIndexChanged);
            // 
            // textBoxPackageFilte
            // 
            this.textBoxPackageFilte.Location = new System.Drawing.Point(6, 350);
            this.textBoxPackageFilte.Name = "textBoxPackageFilte";
            this.textBoxPackageFilte.Size = new System.Drawing.Size(447, 23);
            this.textBoxPackageFilte.TabIndex = 19;
            this.textBoxPackageFilte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPackageFilte_KeyPress);
            // 
            // buttonPackageFilte
            // 
            this.buttonPackageFilte.AutoSize = true;
            this.buttonPackageFilte.Location = new System.Drawing.Point(463, 347);
            this.buttonPackageFilte.Name = "buttonPackageFilte";
            this.buttonPackageFilte.Size = new System.Drawing.Size(75, 27);
            this.buttonPackageFilte.TabIndex = 18;
            this.buttonPackageFilte.Text = "Filte";
            this.buttonPackageFilte.UseVisualStyleBackColor = true;
            this.buttonPackageFilte.Click += new System.EventHandler(this.buttonPackageFilte_Click);
            // 
            // textBoxSendText
            // 
            this.textBoxSendText.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxSendText.Location = new System.Drawing.Point(12, 669);
            this.textBoxSendText.Name = "textBoxSendText";
            this.textBoxSendText.Size = new System.Drawing.Size(629, 23);
            this.textBoxSendText.TabIndex = 22;
            this.textBoxSendText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSendText_KeyPress);
            this.textBoxSendText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSendText_KeyUp);
            // 
            // buttonSendText
            // 
            this.buttonSendText.AutoSize = true;
            this.buttonSendText.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonSendText.Location = new System.Drawing.Point(647, 666);
            this.buttonSendText.Name = "buttonSendText";
            this.buttonSendText.Size = new System.Drawing.Size(75, 27);
            this.buttonSendText.TabIndex = 23;
            this.buttonSendText.Text = "Send";
            this.buttonSendText.UseVisualStyleBackColor = true;
            this.buttonSendText.Click += new System.EventHandler(this.buttonSendText_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(734, 761);
            this.Controls.Add(this.buttonSendText);
            this.Controls.Add(this.textBoxSendText);
            this.Controls.Add(this.groupBoxAPK);
            this.Controls.Add(this.groupBoxDevice);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APKInfoViewer";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.apkListBoxMenu.ResumeLayout(false);
            this.deviceListBoxMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxDevice.ResumeLayout(false);
            this.groupBoxDevice.PerformLayout();
            this.groupBoxAPK.ResumeLayout(false);
            this.groupBoxAPK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip apkListBoxMenu;
        private System.Windows.Forms.ToolStripMenuItem apkListBoxMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apkListBoxMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem apkListBoxMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem apkListBoxMenuItem4;
        private System.Windows.Forms.ContextMenuStrip deviceListBoxMenu;
        private System.Windows.Forms.ToolStripMenuItem deviceListBoxMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apkListBoxMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deviceListBoxMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem itemPreferences;
        private System.Windows.Forms.ToolStripMenuItem preferencesItemPlatformKey;
        private System.Windows.Forms.ToolStripMenuItem preferencesItemTool;
        private System.Windows.Forms.GroupBox groupBoxDevice;
        private System.Windows.Forms.GroupBox groupBoxAPK;
        private System.Windows.Forms.TextBox textBoxPackageFilte;
        private System.Windows.Forms.Button buttonPackageFilte;
        private System.Windows.Forms.Button buttonRefreshDevice;
        private System.Windows.Forms.Button buttonSignSystem;
        private System.Windows.Forms.ComboBox comboBoxSignSystem;
        private System.Windows.Forms.TextBox textBoxPlatformKey;
        private System.Windows.Forms.ToolStripMenuItem menuItemClearData;
        private System.Windows.Forms.TextBox textBoxAdbShell;
        private System.Windows.Forms.TextBox textBoxSendText;
        private System.Windows.Forms.Button buttonSendText;
    }
}

