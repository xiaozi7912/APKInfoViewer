using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApkInfoViewer
{
    public partial class Form1 : Form
    {
        private String AAPT_PATH = Directory.GetCurrentDirectory() + @"\aapt.exe";

        public Form1()
        {
            InitializeComponent();
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
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "FullName";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo selectedItem = listBox1.SelectedItem as FileInfo;
            String filePath = selectedItem.FullName;
            Console.WriteLine("filePath : " + filePath);
            showSelectedInfo(filePath);
        }
    }
}
