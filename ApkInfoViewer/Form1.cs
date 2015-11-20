using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ApkInfoViewer
{
    public partial class Form1 : Form
    {
        private String ADB_PATH = Directory.GetCurrentDirectory() + @"\adb.exe";
        private String AAPT_PATH = Directory.GetCurrentDirectory() + @"\aapt.exe";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "FullName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshDeviceList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                folderBrowser.SelectedPath = textBox2.Text;
            }
            folderBrowser.ShowDialog();

            if (!String.IsNullOrEmpty(folderBrowser.SelectedPath))
            {
                listBox1.Items.Clear();
                textBox2.Text = folderBrowser.SelectedPath;

                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowser.SelectedPath);
                foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                {
                    Console.WriteLine("Extension : " + fileInfo.Extension);
                    if (fileInfo.Extension.ToLower().Equals(".apk"))
                    {
                        listBox1.Items.Add(fileInfo);
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int selectedApkCount = listBox1.SelectedItems.Count;
            int selectedDeviceCount = listBox2.SelectedItems.Count;

            if (selectedApkCount != 0 && selectedDeviceCount != 0)
            {
                String selectedFilePath = (listBox1.SelectedItem as FileInfo).FullName;
                progressBar1.Maximum = selectedDeviceCount;
                progressBar1.Value = 0;
                Console.WriteLine("selectedFilePath : " + selectedFilePath);
                foreach (object selectedItem in listBox2.SelectedItems)
                {
                    Console.WriteLine("selectedItem : " + selectedItem);
                    new Thread(() =>
                    {
                        installAPK(selectedItem.ToString(), selectedFilePath);
                    }).Start();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo selectedItem = listBox1.SelectedItem as FileInfo;
            String filePath = selectedItem.FullName;
            Console.WriteLine("filePath : " + filePath);
            showSelectedInfo(filePath);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void showSelectedInfo(String filePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = AAPT_PATH;
            startInfo.Arguments = String.Format("d badging {0}", filePath);

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    Regex regex = new Regex(@".+ name='([\w\.-]+)' versionCode='([\w\.-]+)' versionName='([\w\.-]+)'", RegexOptions.IgnoreCase);
                    String readLine = exeProcess.StandardOutput.ReadLine();
                    Console.WriteLine(readLine);
                    //MatchCollection matches = regex.Matches(readLine);
                    Console.WriteLine(regex.Match(readLine).Groups.Count);
                    Console.WriteLine(regex.Match(readLine).Groups[0]);
                    Console.WriteLine(regex.Match(readLine).Groups[1]);
                    Console.WriteLine(regex.Match(readLine).Groups[2]);
                    Console.WriteLine(regex.Match(readLine).Groups[3]);
                    textBox3.Text = regex.Match(readLine).Groups[1].Value;
                    textBox4.Text = regex.Match(readLine).Groups[2].Value;
                    textBox5.Text = regex.Match(readLine).Groups[3].Value;
                    Console.WriteLine(regex.Matches(readLine).Count);
                    Console.WriteLine(regex.IsMatch(readLine));
                }
            }
            catch (Exception e)
            {

            }
        }

        private void refreshDeviceList()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = ADB_PATH;
            startInfo.Arguments = String.Format("devices");
            listBox2.Items.Clear();

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    Regex regex = new Regex(@"([\w\.-:]+)\tdevice", RegexOptions.IgnoreCase);
                    while (!exeProcess.StandardOutput.EndOfStream)
                    {
                        String readLine = exeProcess.StandardOutput.ReadLine();
                        Console.WriteLine(readLine);
                        if (regex.IsMatch(readLine))
                        {
                            Match match = regex.Match(readLine);
                            listBox2.Items.Add(match.Groups[1]);
                            Console.WriteLine(match.Groups[0]);
                            Console.WriteLine(match.Groups[1]);
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        private void installAPK(String device, String filePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = ADB_PATH;
            startInfo.Arguments = String.Format("-s {0} install -r {1}", device, filePath);

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    while (!exeProcess.StandardOutput.EndOfStream)
                    {
                        String readLine = exeProcess.StandardOutput.ReadLine();
                        Console.WriteLine(readLine);
                        if (readLine.ToLower().Equals("success"))
                        {
                            progressBar1.Invoke(new Action(() =>
                            {
                                progressBar1.Value++;
                            }));
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
