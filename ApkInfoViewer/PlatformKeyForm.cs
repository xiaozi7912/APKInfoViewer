using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApkInfoViewer {
    public partial class PlatformKeyForm : Form {
        private ConfigManager _ConfgiManager { get; set; }

        public PlatformKeyForm() {
            InitializeComponent();
        }

        private void PlatformKeyForm_Load(object sender, EventArgs e) {
            _ConfgiManager = new ConfigManager();
            listBoxKeyList.DisplayMember = "description";
            listBoxKeyList.ValueMember = "description";

            if (_ConfgiManager.keyList != null) {
                foreach (PlatformKey platformKey in _ConfgiManager.keyList) {
                    listBoxKeyList.Items.Add(platformKey);
                }
            }
        }

        private void buttonSelectFile_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();

            //dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.Filter = "*.pem|*.pem";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK) {
                textBoxFilePath.Text = dialog.FileName;
            }
        }

        private void buttonSelectPK8_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();

            //dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.Filter = "*.pk8|*.pk8";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK) {
                textBoxSelectPK8.Text = dialog.FileName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            String desc = textBoxDesc.Text;
            String pemPath = textBoxFilePath.Text;
            String pk8Path = textBoxSelectPK8.Text;

            if (!String.IsNullOrEmpty(pemPath) && !String.IsNullOrEmpty(pk8Path) && !String.IsNullOrEmpty(desc)) {
                _ConfgiManager.addPlatformKey(new PlatformKey {
                    description = desc,
                    path_pem = pemPath,
                    path_pk8 = pk8Path
                });
                textBoxDesc.Text = String.Empty;
                textBoxFilePath.Text = String.Empty;
                textBoxSelectPK8.Text = String.Empty;
            }
        }
    }
}
