namespace ApkInfoViewer {
    partial class PlatformKeyForm {
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
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxKeyList = new System.Windows.Forms.ListBox();
            this.textBoxSelectPK8 = new System.Windows.Forms.TextBox();
            this.buttonSelectPK8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.AutoSize = true;
            this.buttonSelectFile.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonSelectFile.Location = new System.Drawing.Point(397, 11);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(75, 27);
            this.buttonSelectFile.TabIndex = 0;
            this.buttonSelectFile.Text = "Select";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 12);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(379, 23);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxDesc.Location = new System.Drawing.Point(12, 80);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(379, 23);
            this.textBoxDesc.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonSave.Location = new System.Drawing.Point(397, 77);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxKeyList
            // 
            this.listBoxKeyList.Font = new System.Drawing.Font("Consolas", 10F);
            this.listBoxKeyList.FormattingEnabled = true;
            this.listBoxKeyList.ItemHeight = 15;
            this.listBoxKeyList.Location = new System.Drawing.Point(12, 120);
            this.listBoxKeyList.Name = "listBoxKeyList";
            this.listBoxKeyList.Size = new System.Drawing.Size(460, 229);
            this.listBoxKeyList.TabIndex = 4;
            this.listBoxKeyList.SelectedIndexChanged += new System.EventHandler(this.listBoxKeyList_SelectedIndexChanged);
            // 
            // textBoxSelectPK8
            // 
            this.textBoxSelectPK8.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxSelectPK8.Location = new System.Drawing.Point(12, 47);
            this.textBoxSelectPK8.Name = "textBoxSelectPK8";
            this.textBoxSelectPK8.ReadOnly = true;
            this.textBoxSelectPK8.Size = new System.Drawing.Size(379, 23);
            this.textBoxSelectPK8.TabIndex = 5;
            // 
            // buttonSelectPK8
            // 
            this.buttonSelectPK8.AutoSize = true;
            this.buttonSelectPK8.Font = new System.Drawing.Font("Consolas", 10F);
            this.buttonSelectPK8.Location = new System.Drawing.Point(397, 44);
            this.buttonSelectPK8.Name = "buttonSelectPK8";
            this.buttonSelectPK8.Size = new System.Drawing.Size(75, 27);
            this.buttonSelectPK8.TabIndex = 6;
            this.buttonSelectPK8.Text = "Select";
            this.buttonSelectPK8.UseVisualStyleBackColor = true;
            this.buttonSelectPK8.Click += new System.EventHandler(this.buttonSelectPK8_Click);
            // 
            // PlatformKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.buttonSelectPK8);
            this.Controls.Add(this.textBoxSelectPK8);
            this.Controls.Add(this.listBoxKeyList);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonSelectFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlatformKeyForm";
            this.Text = "PlatformKeyForm";
            this.Load += new System.EventHandler(this.PlatformKeyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxKeyList;
        private System.Windows.Forms.TextBox textBoxSelectPK8;
        private System.Windows.Forms.Button buttonSelectPK8;
    }
}