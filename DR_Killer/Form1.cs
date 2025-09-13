using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DR_Killer
{
    public partial class DR_Killer : Form
    {

        static System.Collections.Specialized.StringCollection logForFiles = new System.Collections.Specialized.StringCollection();
        static System.Collections.Specialized.StringCollection logForDir = new System.Collections.Specialized.StringCollection();
        static long size;

        public DR_Killer()
        {
            InitializeComponent();
            size = 0;
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browseMyFolder = new FolderBrowserDialog();

            browseMyFolder.ShowDialog();
            inputTextBox.Text = browseMyFolder.SelectedPath;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            logForFiles.Clear();
            logForDir.Clear();
            outputBox.Clear();
            size = 0;

            if (inputTextBox.Text != "")
            {
                System.IO.DirectoryInfo rootDir = new System.IO.DirectoryInfo(inputTextBox.Text);
                if (rootDir.Exists)
                {
                    WalkDirectoryTree(rootDir);

                    outputBox.AppendText("Directorys:" + Environment.NewLine);
                    foreach (string s in logForDir)
                    {
                        outputBox.AppendText(s);
                        outputBox.AppendText(Environment.NewLine);
                    }

                    outputBox.AppendText("ncb files:" + Environment.NewLine);
                    foreach (string s in logForFiles)
                    {
                        outputBox.AppendText(s);
                        outputBox.AppendText(Environment.NewLine);
                    }
                    double dSize = (double)size / 1024;
                    outputBox.AppendText("Size: " + (dSize / 1024).ToString("F") + " MB");
                }
                else outputBox.AppendText("Ausgangsverzeichnis existiert nicht.");
            }
            else    outputBox.AppendText("Geben Sie ein Ausgangsverzeichnis an.");
        }

        static void WalkDirectoryTree(System.IO.DirectoryInfo root)
        {
            System.IO.DirectoryInfo[] subDirs = null;
            System.IO.FileInfo[] files = null;

            files = root.GetFiles("*.ncb");

            foreach (System.IO.FileInfo f in files)
            {
                logForFiles.Add(f.FullName);
                size += f.Length;
            }

            files = root.GetFiles("*.sdf");

            foreach (System.IO.FileInfo f in files)
            {
                logForFiles.Add(f.FullName);
                size += f.Length;
            }

            subDirs = root.GetDirectories();

            foreach (System.IO.DirectoryInfo sub in subDirs)
            {
                if (sub.Name == "Release" || sub.Name == "Debug" || sub.Name == "ipch")
                {
                    logForDir.Add(sub.FullName);

                    System.IO.FileInfo[] subFiles = null;

                    subFiles = sub.GetFiles("*.*");
                    foreach (System.IO.FileInfo f in subFiles)
                    {
                        size += f.Length;
                    }
                }
            }

            foreach (System.IO.DirectoryInfo dirInfo in subDirs)
            {
                // Resursive call for each subdirectory.
                WalkDirectoryTree(dirInfo);
            }
            
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            outputBox.Clear();

            foreach (string s in logForDir)
            {
                System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(s);
                try
                {
                    dirInfo.Delete(true);
                    outputBox.AppendText("Erfolgreich gelöscht: " + dirInfo.FullName + Environment.NewLine);
                }
                catch
                {
                    outputBox.AppendText("NICHT gelöscht: " + dirInfo.FullName + Environment.NewLine);
                }                
            }

            foreach (string s in logForFiles)
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(s);
                try
                {
                    fInfo.Delete();
                    outputBox.AppendText("Erfolgreich gelöscht: " + fInfo.FullName + Environment.NewLine);
                }
                catch
                {
                    outputBox.AppendText("NICHT gelöscht: " + fInfo.FullName + Environment.NewLine);
                }
            }           
        }
    }
}
