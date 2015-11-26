namespace ApkInfoViewer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
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
            this.apkListBoxMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apkListBoxMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.apkListBoxMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.apkListBoxMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceListBoxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deviceListBoxMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apkListBoxMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.apkListBoxMenu.SuspendLayout();
            this.deviceListBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(13, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 22);
            this.textBox2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Consolas", 9F);
            this.button2.Location = new System.Drawing.Point(338, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(104, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(319, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(104, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(319, 22);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(104, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(319, 22);
            this.textBox5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "PackageName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "VersionCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "VersionName";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(13, 272);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(414, 186);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 14;
            this.listBox2.Location = new System.Drawing.Point(13, 151);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(414, 116);
            this.listBox2.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 463);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(414, 18);
            this.progressBar1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Activity";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(104, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 22);
            this.textBox1.TabIndex = 17;
            // 
            // apkListBoxMenu
            // 
            this.apkListBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apkListBoxMenuItem1,
            this.apkListBoxMenuItem2,
            this.apkListBoxMenuItem3,
            this.toolStripSeparator1,
            this.apkListBoxMenuItem5,
            this.toolStripSeparator2,
            this.apkListBoxMenuItem4});
            this.apkListBoxMenu.Name = "apkListBoxMenu";
            this.apkListBoxMenu.ShowImageMargin = false;
            this.apkListBoxMenu.Size = new System.Drawing.Size(128, 148);
            this.apkListBoxMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.apkListBoxMenu_ItemClicked);
            // 
            // apkListBoxMenuItem1
            // 
            this.apkListBoxMenuItem1.Name = "apkListBoxMenuItem1";
            this.apkListBoxMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.apkListBoxMenuItem1.Text = "Install APK";
            // 
            // apkListBoxMenuItem2
            // 
            this.apkListBoxMenuItem2.Name = "apkListBoxMenuItem2";
            this.apkListBoxMenuItem2.Size = new System.Drawing.Size(127, 22);
            this.apkListBoxMenuItem2.Text = "Uinstall APK";
            // 
            // apkListBoxMenuItem3
            // 
            this.apkListBoxMenuItem3.Name = "apkListBoxMenuItem3";
            this.apkListBoxMenuItem3.Size = new System.Drawing.Size(127, 22);
            this.apkListBoxMenuItem3.Text = "Start APP";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // apkListBoxMenuItem4
            // 
            this.apkListBoxMenuItem4.Name = "apkListBoxMenuItem4";
            this.apkListBoxMenuItem4.Size = new System.Drawing.Size(127, 22);
            this.apkListBoxMenuItem4.Text = "Refresh APKs";
            // 
            // deviceListBoxMenu
            // 
            this.deviceListBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceListBoxMenuItem1});
            this.deviceListBoxMenu.Name = "deviceListBoxMenu";
            this.deviceListBoxMenu.ShowImageMargin = false;
            this.deviceListBoxMenu.Size = new System.Drawing.Size(138, 26);
            this.deviceListBoxMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.deviceListBoxMenu_ItemClicked);
            // 
            // deviceListBoxMenuItem1
            // 
            this.deviceListBoxMenuItem1.Name = "deviceListBoxMenuItem1";
            this.deviceListBoxMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.deviceListBoxMenuItem1.Text = "Refresh Devices";
            // 
            // apkListBoxMenuItem5
            // 
            this.apkListBoxMenuItem5.Name = "apkListBoxMenuItem5";
            this.apkListBoxMenuItem5.Size = new System.Drawing.Size(127, 22);
            this.apkListBoxMenuItem5.Text = "Rename";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 491);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APKInfoViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.apkListBoxMenu.ResumeLayout(false);
            this.deviceListBoxMenu.ResumeLayout(false);
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
    }
}

