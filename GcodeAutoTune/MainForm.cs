using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GcodeAutoTune
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoReplace.Checked)
            {
                CreateFileWatcher(txtInPath.Text);
            }
            else {
                watcher.Dispose();
            }
               
        }


        private void replace() {
            // WaitForFile(txtInPath.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
            
            String fileContent = File.ReadAllText(txtInPath.Text);
            fileContent = fileContent.Replace("FQ1 ", "F5500 ");
            fileContent = fileContent.Replace("FQ2 ", "F5500 ");
            fileContent = fileContent.Replace("FQ3 ", "F5500 ");
            String finalContent = "";
            //MessageBox.Show(breakPos.ToString());
            FileInfo fileInfo = new FileInfo(txtInPath.Text);
            finalContent = fileContent.Substring(0, fileContent.IndexOf("\r\n1 ") + 2);
            finalContent += "1 TOOL DEF 1 \r\n2 TOOL CALL 1 Z S2100\r\n25 L M03 \r\n26 L M08\r\n37 L Z+10.222 F9500\r\n";
            finalContent += fileContent.Substring(fileContent.IndexOf("\r\n38 ") + 2);
            //File.WriteAllText(fileInfo.Directory + @"\2-2.h", finalContent);
           // WaitForFile(txtOutPath.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            File.WriteAllText(txtOutPath.Text, finalContent); 
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            replace();
        }

        private void FileChanged(object source, FileSystemEventArgs e)
        {
            Thread.Sleep(1000);
            replace(); 
            
        }

        FileSystemWatcher watcher;
        public void CreateFileWatcher(string path)
        {
            // Create a new FileSystemWatcher and set its properties.
            watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(path);
            watcher.Filter = Path.GetFileName(path);
            /* Watch for changes in LastAccess and LastWrite times, and 
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            // Only watch text files.

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(FileChanged);

            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

       


        private void btnOutBrows_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "GCode File (*.h)|*.h";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            txtOutPath.Text = dlg.FileName;

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "GCode File (*.h)|*.h";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            txtInPath.Text = dlg.FileName;
            FileInfo fileInfo = new FileInfo(txtInPath.Text);
            txtOutPath.Text = desktopPath+"\\"+fileInfo.Name;
        }
    }

    

}
