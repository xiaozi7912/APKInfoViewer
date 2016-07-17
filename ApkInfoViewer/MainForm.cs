using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ApkInfoViewer {
    public partial class MainForm : Form {
        private ConfigManager _ConfigManager { get; set; }
        private String ADB_PATH { get; set; }
        private String AAPT_PATH { get; set; }

        public MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "FullName";

            listBox1.ContextMenuStrip = apkListBoxMenu;
            listBox2.ContextMenuStrip = deviceListBoxMenu;

            comboBoxSignSystem.DisplayMember = "description";
        }

        private void button1_Click(object sender, EventArgs e) {
            refreshDeviceList();
        }

        private void button2_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (!String.IsNullOrEmpty(textBox2.Text)) {
                folderBrowser.SelectedPath = textBox2.Text;
            } else {
                folderBrowser.SelectedPath = Directory.GetCurrentDirectory();
            }
            folderBrowser.ShowDialog();

            textBox2.Text = folderBrowser.SelectedPath;
            refreshAPKList();
        }

        private void button3_Click(object sender, EventArgs e) {
            int selectedApkCount = listBox1.SelectedItems.Count;
            int selectedDeviceCount = listBox2.SelectedItems.Count;

            if (selectedApkCount == 0) {
                MessageBox.Show("Select an apk.");
            } else if (selectedDeviceCount == 0) {
                MessageBox.Show("Select a device.");
            }

            if (selectedApkCount != 0 && selectedDeviceCount != 0) {
                String selectedFilePath = (listBox1.SelectedItem as FileInfo).FullName;
                progressBar1.Maximum = selectedDeviceCount;
                progressBar1.Value = 0;
                Console.WriteLine("selectedFilePath : " + selectedFilePath);
                foreach (object selectedItem in listBox2.SelectedItems) {
                    Console.WriteLine("selectedItem : " + selectedItem);
                    new Thread(() => {
                        installAPK(selectedItem.ToString(), selectedFilePath);
                    }).Start();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            int selectedApkCount = listBox1.SelectedItems.Count;
            int selectedDeviceCount = listBox2.SelectedItems.Count;

            if (selectedApkCount != 0 && selectedDeviceCount != 0) {
                String packageName = textBox3.Text;
                String activityName = textBox1.Text;

                foreach (object selectedItem in listBox2.SelectedItems) {
                    Console.WriteLine("selectedItem : " + selectedItem);
                    new Thread(() => {
                        startApp(selectedItem.ToString(), packageName, activityName);
                    }).Start();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            refreshAPKList();
        }

        private void button6_Click(object sender, EventArgs e) {
            int selectedApkCount = listBox1.SelectedItems.Count;
            int selectedDeviceCount = listBox2.SelectedItems.Count;

            if (selectedApkCount == 0) {
                MessageBox.Show("Select an apk.");
            } else if (selectedDeviceCount == 0) {
                MessageBox.Show("Select a device.");
            }

            if (selectedApkCount != 0 && selectedDeviceCount != 0) {
                String selectedFilePath = (listBox1.SelectedItem as FileInfo).FullName;
                progressBar1.Maximum = selectedDeviceCount;
                progressBar1.Value = 0;
                Console.WriteLine("selectedFilePath : " + selectedFilePath);
                foreach (object selectedItem in listBox2.SelectedItems) {
                    Console.WriteLine("selectedItem : " + selectedItem);
                    new Thread(() => {
                        uninstallAPK(selectedItem.ToString(), textBox3.Text);
                    }).Start();
                }
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e) {
            listBox1.SelectedIndex = listBox1.IndexFromPoint(e.X, e.Y);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            FileInfo selectedItem = listBox1.SelectedItem as FileInfo;

            if (selectedItem != null) {
                String filePath = selectedItem.FullName;
                Console.WriteLine("filePath : " + filePath);
                showSelectedInfo(filePath);
            }
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e) {
            listBox2.SelectedIndex = listBox2.IndexFromPoint(e.X, e.Y);
        }

        private void apkListBoxMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            ToolStripItem selectedItem = e.ClickedItem;
            Console.WriteLine("selectedItem.Name : " + selectedItem.Name);
            Console.WriteLine("selectedItem.Text : " + selectedItem.Text);
            Console.WriteLine("apkListBoxMenuItem1.Name : " + apkListBoxMenuItem1.Name);
            Console.WriteLine("apkListBoxMenuItem2.Name : " + apkListBoxMenuItem2.Name);
            Console.WriteLine("apkListBoxMenuItem3.Name : " + apkListBoxMenuItem3.Name);
            Console.WriteLine("apkListBoxMenuItem4.Name : " + apkListBoxMenuItem4.Name);
            Console.WriteLine("apkListBoxMenuItem5.Name : " + apkListBoxMenuItem5.Name);

            if (selectedItem.Name.Equals(apkListBoxMenuItem1.Name)) {
                onInstallAPKClicked();
            } else if (selectedItem.Name.Equals(apkListBoxMenuItem2.Name)) {
                onUninstallAPKClicked();
            } else if (selectedItem.Name.Equals(apkListBoxMenuItem3.Name)) {
                onStartAPPClicked();
            } else if (selectedItem.Name.Equals(apkListBoxMenuItem4.Name)) {
                onRefreshAPKListClicked();
            } else if (selectedItem.Name.Equals(apkListBoxMenuItem5.Name)) {
                onRenameAPKClicked();
            }
        }

        private void deviceListBoxMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            ToolStripItem selectedItem = e.ClickedItem;
            Console.WriteLine("selectedItem.Name : " + selectedItem.Name);
            Console.WriteLine("selectedItem.Text : " + selectedItem.Text);
            Console.WriteLine("deviceListBoxMenuItem1.Name : " + deviceListBoxMenuItem1.Name);

            if (selectedItem.Name.Equals(deviceListBoxMenuItem1.Name)) {
                onRefreshDeviceListClicked();
            } else if (selectedItem.Name.Equals(deviceListBoxMenuItem2.Name)) {
                onRebootDeviceClicked();
            }
        }

        private void onInstallAPKClicked() {
            int selectedApkCount = listBox1.SelectedItems.Count;
            int selectedDeviceCount = listBox2.SelectedItems.Count;

            if (selectedApkCount == 0) {
                MessageBox.Show("Select an apk.");
            } else if (selectedDeviceCount == 0) {
                MessageBox.Show("Select a device.");
            }

            if (selectedApkCount != 0 && selectedDeviceCount != 0) {
                String selectedFilePath = (listBox1.SelectedItem as FileInfo).FullName;
                progressBar1.Maximum = selectedDeviceCount;
                progressBar1.Value = 0;
                Console.WriteLine("selectedFilePath : " + selectedFilePath);
                foreach (object selectedItem in listBox2.SelectedItems) {
                    Console.WriteLine("selectedItem : " + selectedItem);
                    new Thread(() => {
                        installAPK(selectedItem.ToString(), selectedFilePath);
                    }).Start();
                }
            }
        }

        private void onUninstallAPKClicked() {
            int selectedApkCount = listBox1.SelectedItems.Count;
            int selectedDeviceCount = listBox2.SelectedItems.Count;

            if (selectedApkCount == 0) {
                MessageBox.Show("Select an apk.");
            } else if (selectedDeviceCount == 0) {
                MessageBox.Show("Select a device.");
            }

            if (selectedApkCount != 0 && selectedDeviceCount != 0) {
                String selectedFilePath = (listBox1.SelectedItem as FileInfo).FullName;
                progressBar1.Maximum = selectedDeviceCount;
                progressBar1.Value = 0;
                Console.WriteLine("selectedFilePath : " + selectedFilePath);
                foreach (object selectedItem in listBox2.SelectedItems) {
                    Console.WriteLine("selectedItem : " + selectedItem);
                    new Thread(() => {
                        uninstallAPK(selectedItem.ToString(), textBox3.Text);
                    }).Start();
                }
            }
        }

        private void onStartAPPClicked() {
            int selectedApkCount = listBox1.SelectedItems.Count;
            int selectedDeviceCount = listBox2.SelectedItems.Count;

            if (selectedApkCount != 0 && selectedDeviceCount != 0) {
                String packageName = textBox3.Text;
                String activityName = textBox1.Text;

                foreach (object selectedItem in listBox2.SelectedItems) {
                    Console.WriteLine("selectedItem : " + selectedItem);
                    new Thread(() => {
                        startApp(selectedItem.ToString(), packageName, activityName);
                    }).Start();
                }
            }
        }

        private void onRenameAPKClicked() {
            int selectedApkCount = listBox1.SelectedItems.Count;

            if (selectedApkCount != 0) {
                FileInfo selectedItem = listBox1.SelectedItem as FileInfo;
                String packageName = textBox3.Text;
                String versionCode = textBox4.Text;
                String versionName = textBox5.Text;
                Console.WriteLine("selectedItem.FullName : " + selectedItem.FullName);
                Console.WriteLine("selectedItem.Name : " + selectedItem.Name);
                Console.WriteLine("selectedItem.DirectoryName : " + selectedItem.DirectoryName);

                try {
                    File.Move(selectedItem.FullName, String.Format("{0}\\{1}.{2}_{3}.apk",
                        selectedItem.DirectoryName,
                        packageName,
                        versionCode,
                        versionName));
                    refreshAPKList();
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void onRefreshAPKListClicked() {
            refreshAPKList();
        }

        private void onRefreshDeviceListClicked() {
            refreshDeviceList();
        }

        private void onRebootDeviceClicked() {
            int selectedDeviceCount = listBox2.SelectedItems.Count;

            if (selectedDeviceCount != 0) {
                foreach (object selectedItem in listBox2.SelectedItems) {
                    Console.WriteLine("selectedItem : " + selectedItem);
                    new Thread(() => {
                        rebootDevice(selectedItem.ToString());
                    }).Start();
                }
            }
        }

        private void refreshAPKList() {
            String folderPath = textBox2.Text;
            listBox1.Items.Clear();

            if (!String.IsNullOrEmpty(folderPath)) {
                textBox2.Text = folderPath;

                DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
                foreach (FileInfo fileInfo in directoryInfo.GetFiles()) {
                    Console.WriteLine("Extension : " + fileInfo.Extension);
                    if (fileInfo.Extension.ToLower().Equals(".apk")) {
                        String filteString = textBoxPackageFilte.Text;
                        if (!String.IsNullOrEmpty(filteString)) {
                            if (fileInfo.Name.Contains(filteString)) {
                                listBox1.Items.Add(fileInfo);
                            }
                        } else {
                            listBox1.Items.Add(fileInfo);
                        }
                    }
                }
            }
        }

        private void showSelectedInfo(String filePath) {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = AAPT_PATH;
            startInfo.Arguments = String.Format("d badging {0}", filePath);

            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox1.Text = String.Empty;

            try {
                using (Process exeProcess = Process.Start(startInfo)) {
                    while (!exeProcess.StandardOutput.EndOfStream) {
                        String readLine = exeProcess.StandardOutput.ReadLine();
                        Console.WriteLine(readLine);

                        if (readLine.StartsWith("package")) {
                            Regex regex = new Regex(@".+ name='([\w\s\.-]+)' versionCode='([\w\s\.-]+)' versionName='([\w\s\.-]+)'", RegexOptions.IgnoreCase);
                            textBox3.Text = regex.Match(readLine).Groups[1].Value;
                            textBox4.Text = regex.Match(readLine).Groups[2].Value;
                            textBox5.Text = regex.Match(readLine).Groups[3].Value;
                        } else if (readLine.StartsWith("launchable")) {
                            Regex regex = new Regex(@"name='([\w\.-]+)'");
                            textBox1.Text = regex.Match(readLine).Groups[1].Value;
                        }
                    }
                }
            } catch (Exception e) {

            }
        }

        private void refreshDeviceList() {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = ADB_PATH;
            startInfo.Arguments = String.Format("devices");
            listBox2.Items.Clear();

            try {
                using (Process exeProcess = Process.Start(startInfo)) {
                    Regex regex = new Regex(@"([\w\.-:]+)\tdevice", RegexOptions.IgnoreCase);
                    while (!exeProcess.StandardOutput.EndOfStream) {
                        String readLine = exeProcess.StandardOutput.ReadLine();
                        Console.WriteLine(readLine);
                        if (regex.IsMatch(readLine)) {
                            Match match = regex.Match(readLine);
                            listBox2.Items.Add(match.Groups[1]);
                            Console.WriteLine(match.Groups[0]);
                            Console.WriteLine(match.Groups[1]);
                        }
                    }
                }
            } catch (Exception e) {

            }
        }

        private void rebootDevice(String device) {
            Console.WriteLine("rebootDevice");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = ADB_PATH;
            startInfo.Arguments = String.Format("-s {0} reboot", device);
            Console.WriteLine(String.Format("-s {0} reboot", device));

            try {
                using (Process exeProcess = Process.Start(startInfo)) {
                    while (!exeProcess.StandardOutput.EndOfStream) {
                        String readLine = exeProcess.StandardOutput.ReadLine();
                        Console.WriteLine(readLine);
                    }
                }
            } catch (Exception e) {

            }
        }

        private void installAPK(String device, String filePath) {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = ADB_PATH;
            startInfo.Arguments = String.Format("-s {0} install -r {1}", device, filePath);

            try {
                using (Process exeProcess = Process.Start(startInfo)) {
                    while (!exeProcess.StandardOutput.EndOfStream) {
                        String readLine = exeProcess.StandardOutput.ReadLine();
                        Console.WriteLine(readLine);
                        if (readLine.ToLower().Equals("success")) {
                            progressBar1.Invoke(new Action(() => {
                                progressBar1.Value++;
                            }));
                        } else if (readLine.StartsWith("Failure")) {
                            MessageBox.Show(readLine);
                        }
                    }
                }
            } catch (Exception e) {

            }
        }

        private void uninstallAPK(String device, String packageName) {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = ADB_PATH;
            startInfo.Arguments = String.Format("-s {0} uninstall {1}", device, packageName);

            try {
                using (Process exeProcess = Process.Start(startInfo)) {
                    while (!exeProcess.StandardOutput.EndOfStream) {
                        String readLine = exeProcess.StandardOutput.ReadLine();
                        Console.WriteLine(readLine);
                        if (readLine.ToLower().Equals("success")) {
                            progressBar1.Invoke(new Action(() => {
                                progressBar1.Value++;
                            }));
                        } else if (readLine.StartsWith("Failure")) {
                            MessageBox.Show(readLine);
                        }
                    }
                }
            } catch (Exception e) {

            }
        }

        private void startApp(String device, String packageName, String activityName) {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = ADB_PATH;
            startInfo.Arguments = String.Format("-s {0} shell am start -n {1}/{2}", device, packageName, activityName);

            try {
                using (Process exeProcess = Process.Start(startInfo)) {
                    while (!exeProcess.StandardOutput.EndOfStream) {
                        String readLine = exeProcess.StandardOutput.ReadLine();
                        Console.WriteLine(readLine);

                        if (readLine.StartsWith("Error:")) {
                            MessageBox.Show(readLine);
                        }
                    }
                }
            } catch (Exception e) {

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void preferencesItemPlatformKey_Click(object sender, EventArgs e) {
            new PlatformKeyForm().Show();
        }

        private void preferencesItemTool_Click(object sender, EventArgs e) {
            new ToolForm().Show();
        }

        private void MainForm_Activated(object sender, EventArgs e) {
            Console.WriteLine("MainForm_Activated");
            _ConfigManager = new ConfigManager();

            ADB_PATH = _ConfigManager.path_ADB;
            AAPT_PATH = _ConfigManager.path_AAPT;

            if (_ConfigManager.keyList != null) {
                comboBoxSignSystem.Items.Clear();

                foreach (PlatformKey platformKey in _ConfigManager.keyList) {
                    comboBoxSignSystem.Items.Add(platformKey);
                }
                comboBoxSignSystem.SelectedIndex = 0;
            }
        }

        private void MainForm_Deactivate(object sender, EventArgs e) {
            Console.WriteLine("MainForm_Deactivate");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void groupBoxDevice_Enter(object sender, EventArgs e) {

        }

        private void buttonPackageFilte_Click(object sender, EventArgs e) {
            refreshAPKList();
        }

        private void textBoxPackageFilte_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                refreshAPKList();
            }
        }

        private void buttonRefreshDevice_Click(object sender, EventArgs e) {
            refreshDeviceList();
        }

        private void buttonSignSystem_Click(object sender, EventArgs e) {
            int selectedApkCount = listBox1.SelectedItems.Count;

            if (selectedApkCount != 0) {
                FileInfo selectedAPK = listBox1.SelectedItem as FileInfo;
                PlatformKey selectedKey = comboBoxSignSystem.SelectedItem as PlatformKey;
                String packageName = textBox3.Text;
                String versionCode = textBox4.Text;
                String versionName = textBox5.Text;
                String systemName = selectedAPK.FullName.Insert(selectedAPK.FullName.LastIndexOf("apk"), "system.");
                Console.WriteLine("selectedItem.FullName : " + selectedAPK.FullName);
                Console.WriteLine("selectedItem.Name : " + selectedAPK.Name);
                Console.WriteLine("selectedItem.DirectoryName : " + selectedAPK.DirectoryName);
                Console.WriteLine("selectedKey.description : " + selectedKey.description);
                Console.WriteLine("selectedKey.path_pem : " + selectedKey.path_pem);
                Console.WriteLine("selectedKey.path_pk8 : " + selectedKey.path_pk8);
                Console.WriteLine("selectedAPK.FullName.LastIndexOf(\"apk\") : " + selectedAPK.FullName.LastIndexOf("apk"));
                Console.WriteLine("systemName : " + systemName);

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "java.exe";
                //java - jar signapk.jar platform.x509.pem platform.pk8 old_apk new_apk
                startInfo.Arguments = String.Format("-jar '{0}' '{1}' '{2}' '{3}' '{4}'",
                    _ConfigManager.path_SIGNAPK,
                    selectedKey.path_pem,
                    selectedKey.path_pk8,
                    selectedAPK.FullName,
                    systemName);
                Console.WriteLine("startInfo.Arguments : " + startInfo.Arguments);

                try {
                    using (Process exeProcess = Process.Start(startInfo)) {
                        Console.WriteLine("exeProcess.ProcessName : " + exeProcess.ProcessName);
                        exeProcess.WaitForExit();

                        while (!exeProcess.StandardOutput.EndOfStream) {
                            String readLine = exeProcess.StandardOutput.ReadLine();
                            Console.WriteLine(readLine);

                            if (readLine.StartsWith("Error:")) {
                                MessageBox.Show(readLine);
                            }
                        }
                        Console.WriteLine("done");
                    }
                } catch (Exception exception) {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
