namespace ApkInfoViewer {
    partial class ToolForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelADBPath = new System.Windows.Forms.Label();
            this.textBoxADBPath = new System.Windows.Forms.TextBox();
            this.buttonADBPath = new System.Windows.Forms.Button();
            this.labelAAPTPath = new System.Windows.Forms.Label();
            this.textBoxAAPTPath = new System.Windows.Forms.TextBox();
            this.buttonAAPTPath = new System.Windows.Forms.Button();
            this.labelSIGNAPKPath = new System.Windows.Forms.Label();
            this.textBoxSIGNAPKPath = new System.Windows.Forms.TextBox();
            this.buttonSIGNAPKPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelADBPath
            // 
            this.labelADBPath.AutoSize = true;
            this.labelADBPath.Font = new System.Drawing.Font("Constantia", 10F);
            this.labelADBPath.Location = new System.Drawing.Point(12, 9);
            this.labelADBPath.Name = "labelADBPath";
            this.labelADBPath.Size = new System.Drawing.Size(68, 17);
            this.labelADBPath.TabIndex = 0;
            this.labelADBPath.Text = "ADB Path";
            // 
            // textBoxADBPath
            // 
            this.textBoxADBPath.Enabled = false;
            this.textBoxADBPath.Font = new System.Drawing.Font("Constantia", 10F);
            this.textBoxADBPath.Location = new System.Drawing.Point(15, 29);
            this.textBoxADBPath.Name = "textBoxADBPath";
            this.textBoxADBPath.Size = new System.Drawing.Size(277, 24);
            this.textBoxADBPath.TabIndex = 1;
            // 
            // buttonADBPath
            // 
            this.buttonADBPath.AutoSize = true;
            this.buttonADBPath.Font = new System.Drawing.Font("Constantia", 10F);
            this.buttonADBPath.Location = new System.Drawing.Point(298, 24);
            this.buttonADBPath.Name = "buttonADBPath";
            this.buttonADBPath.Size = new System.Drawing.Size(75, 30);
            this.buttonADBPath.TabIndex = 2;
            this.buttonADBPath.Text = "Select";
            this.buttonADBPath.UseVisualStyleBackColor = true;
            this.buttonADBPath.Click += new System.EventHandler(this.buttonADBPath_Click);
            // 
            // labelAAPTPath
            // 
            this.labelAAPTPath.AutoSize = true;
            this.labelAAPTPath.Font = new System.Drawing.Font("Constantia", 10F);
            this.labelAAPTPath.Location = new System.Drawing.Point(12, 60);
            this.labelAAPTPath.Name = "labelAAPTPath";
            this.labelAAPTPath.Size = new System.Drawing.Size(75, 17);
            this.labelAAPTPath.TabIndex = 3;
            this.labelAAPTPath.Text = "AAPT Path";
            // 
            // textBoxAAPTPath
            // 
            this.textBoxAAPTPath.Enabled = false;
            this.textBoxAAPTPath.Font = new System.Drawing.Font("Constantia", 10F);
            this.textBoxAAPTPath.Location = new System.Drawing.Point(15, 80);
            this.textBoxAAPTPath.Name = "textBoxAAPTPath";
            this.textBoxAAPTPath.Size = new System.Drawing.Size(277, 24);
            this.textBoxAAPTPath.TabIndex = 4;
            // 
            // buttonAAPTPath
            // 
            this.buttonAAPTPath.AutoSize = true;
            this.buttonAAPTPath.Font = new System.Drawing.Font("Constantia", 10F);
            this.buttonAAPTPath.Location = new System.Drawing.Point(298, 76);
            this.buttonAAPTPath.Name = "buttonAAPTPath";
            this.buttonAAPTPath.Size = new System.Drawing.Size(75, 29);
            this.buttonAAPTPath.TabIndex = 5;
            this.buttonAAPTPath.Text = "Select";
            this.buttonAAPTPath.UseVisualStyleBackColor = true;
            this.buttonAAPTPath.Click += new System.EventHandler(this.buttonAAPTPath_Click);
            // 
            // labelSIGNAPKPath
            // 
            this.labelSIGNAPKPath.AutoSize = true;
            this.labelSIGNAPKPath.Font = new System.Drawing.Font("Constantia", 10F);
            this.labelSIGNAPKPath.Location = new System.Drawing.Point(12, 110);
            this.labelSIGNAPKPath.Name = "labelSIGNAPKPath";
            this.labelSIGNAPKPath.Size = new System.Drawing.Size(90, 17);
            this.labelSIGNAPKPath.TabIndex = 6;
            this.labelSIGNAPKPath.Text = "SignApk Path";
            // 
            // textBoxSIGNAPKPath
            // 
            this.textBoxSIGNAPKPath.Enabled = false;
            this.textBoxSIGNAPKPath.Font = new System.Drawing.Font("Constantia", 10F);
            this.textBoxSIGNAPKPath.Location = new System.Drawing.Point(15, 130);
            this.textBoxSIGNAPKPath.Name = "textBoxSIGNAPKPath";
            this.textBoxSIGNAPKPath.Size = new System.Drawing.Size(277, 24);
            this.textBoxSIGNAPKPath.TabIndex = 7;
            // 
            // buttonSIGNAPKPath
            // 
            this.buttonSIGNAPKPath.AutoSize = true;
            this.buttonSIGNAPKPath.Font = new System.Drawing.Font("Constantia", 10F);
            this.buttonSIGNAPKPath.Location = new System.Drawing.Point(298, 127);
            this.buttonSIGNAPKPath.Name = "buttonSIGNAPKPath";
            this.buttonSIGNAPKPath.Size = new System.Drawing.Size(75, 27);
            this.buttonSIGNAPKPath.TabIndex = 8;
            this.buttonSIGNAPKPath.Text = "Select";
            this.buttonSIGNAPKPath.UseVisualStyleBackColor = true;
            this.buttonSIGNAPKPath.Click += new System.EventHandler(this.buttonSIGNAPKPath_Click);
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.buttonSIGNAPKPath);
            this.Controls.Add(this.textBoxSIGNAPKPath);
            this.Controls.Add(this.labelSIGNAPKPath);
            this.Controls.Add(this.buttonAAPTPath);
            this.Controls.Add(this.textBoxAAPTPath);
            this.Controls.Add(this.labelAAPTPath);
            this.Controls.Add(this.buttonADBPath);
            this.Controls.Add(this.textBoxADBPath);
            this.Controls.Add(this.labelADBPath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolForm";
            this.Text = "ToolForm";
            this.Load += new System.EventHandler(this.ToolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelADBPath;
        private System.Windows.Forms.TextBox textBoxADBPath;
        private System.Windows.Forms.Button buttonADBPath;
        private System.Windows.Forms.Label labelAAPTPath;
        private System.Windows.Forms.TextBox textBoxAAPTPath;
        private System.Windows.Forms.Button buttonAAPTPath;
        private System.Windows.Forms.Label labelSIGNAPKPath;
        private System.Windows.Forms.TextBox textBoxSIGNAPKPath;
        private System.Windows.Forms.Button buttonSIGNAPKPath;
    }
}