using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApkInfoViewer {
    public partial class ToolForm : Form {
        private ConfigManager _ConfigManager { get; set; }

        public ToolForm() {
            InitializeComponent();
        }

        private void buttonADBPath_Click(object sender, EventArgs e) {
            Console.WriteLine("buttonADBPath_Click");
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK) {
                textBoxADBPath.Text = dialog.FileName;
                _ConfigManager.setADBPath(dialog.FileName);
            }
        }

        private void ToolForm_Load(object sender, EventArgs e) {
            _ConfigManager = new ConfigManager();

            if (_ConfigManager.path_ADB != null) {
                textBoxADBPath.Text = _ConfigManager.path_ADB;
            }
            if (_ConfigManager.path_AAPT != null) {
                textBoxAAPTPath.Text = _ConfigManager.path_AAPT;
            }
            if (_ConfigManager.path_SIGNAPK != null) {
                textBoxSIGNAPKPath.Text = _ConfigManager.path_SIGNAPK;
            }
        }

        private void buttonAAPTPath_Click(object sender, EventArgs e) {
            Console.WriteLine("buttonAAPTPath_Click");
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK) {
                textBoxAAPTPath.Text = dialog.FileName;
                _ConfigManager.setAAPTPath(dialog.FileName);
            }
        }

        private void buttonSIGNAPKPath_Click(object sender, EventArgs e) {
            Console.WriteLine("buttonSIGNAPKPath_Click");
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK) {
                textBoxSIGNAPKPath.Text = dialog.FileName;
                _ConfigManager.setSIGNAPKPath(dialog.FileName);
            }
        }
    }
}
